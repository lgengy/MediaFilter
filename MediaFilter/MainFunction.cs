using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MediaFilter
{
    partial class MainForm
    {
        #region 排三
        /// <summary>
        /// 检查文件是否满足纵模式导出
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        private List<string> CheckColumnMode(List<string> list)
        {
            List<string> listRe = new List<string>();

            //纵模式下通过开根后是否有小数点判断结果是否为整数，进而判断文件数是否构成正方形
            if (Math.Sqrt(list.Count).ToString().Split('.').Length == 1)
            {
                int sideLength = Convert.ToInt32(Math.Sqrt(list.Count));
                for (int i = 0; i < sideLength; i++)
                {
                    for (int j = i; j < (sideLength - 1) * sideLength + i + 1; j += sideLength)
                    {
                        listRe.Add(list[j]);
                    }
                }
            }
            else
            {
                MessageBox.Show("导入文件不构成正方形");
            }

            return listRe;
        }

        private void CreateFilterFileOnePlugin(string saveDir, List<string> listFile, ref bool coverExistFile)
        {
            int n = 0;//升数
            string name = ""; //用于计算n
            int pluginCount;//插件个数
            int fileCount = 0;//生成文件个数

            //计算横模式升数
            if (exportMode == 0)
            {
                foreach (string item in listFile)
                {
                    if (!name.Equals(Utils.FindFileNameInPath(item).Split('_')[2]))
                    {
                        n++;
                        name = Utils.FindFileNameInPath(item).Split('_')[2];
                    }
                }
            }
            //计算纵模式升数
            if (exportMode == 1)
            {
                //因为纵模式是正方形，那么各升的文件数是相同的，因此只要计算文件中某一升文件的数量，就可知道文件里的升数
                string oneIssue = Utils.FindFileNameInPath(listFile[0]).Split('_')[2];
                n = listFile.Where(item => Utils.FindFileNameInPath(item).Split('_')[2].Equals(oneIssue)).Count();
            }

            //遍历媒体文件，形成新的过滤文件
            for (int i = 0; i < listFile.Count; i += n)
            {
                pluginCount = 0;

                //当剩余媒体的个数不能形成一个过滤文件时，停止遍历
                if (listFile.Count - i >= n)
                {
                    string saveName = saveDir + "\\" + Utils.FindFileNameInPath(listFile[i]).Split('_')[0] + $"过滤条件单插件-{fileCount++}.flt";

                    if (!coverExistFile && File.Exists(saveName))
                        if(MessageBox.Show("文件已存在，是否覆盖？", "提示", MessageBoxButtons.YesNo) == DialogResult.No) return;
                        else coverExistFile = true;

                    StreamReader srTemplate = new StreamReader(lb_Template.Items[0].ToString(), Encoding.GetEncoding("GB2312"));
                    StreamWriter sw = new StreamWriter(saveName, false, srTemplate.CurrentEncoding);

                    while (!srTemplate.EndOfStream)
                    {
                        string content = srTemplate.ReadLine();
                        if (content.StartsWith("分布纵向"))
                        {
                            if (++pluginCount > nud_PluginCount.Value)
                            {
                                MessageBox.Show("输入插件个数小于模板中插件个数，请仔细检查");
                                srTemplate.Close();
                                sw.Close();
                                return;
                            }

                            StringBuilder sbNewContent = new StringBuilder();
                            //获取每一个文件期数后的后缀
                            string issueSuffix = Regex.Split(content, @"\\" + Utils.Substring(content, "每", "共") + @"\\")[1].Split('\\')[0];

                            sbNewContent.Append(content.Split('=')[0]).Append("=");
                            for (int j = i; j < fileCount * 10; j++)
                            {
                                int issueCount = 0;//期数
                                StreamReader srMedia = new StreamReader(listFile[j]);

                                sbNewContent.Append(Utils.FindFileNameInPath(listFile[j]));
                                while (!srMedia.EndOfStream)
                                {
                                    string mediaContent = srMedia.ReadLine();
                                    if (mediaContent.StartsWith("Y"))
                                    {
                                        issueCount++;
                                        sbNewContent.Append("|").Append(mediaContent.Split('|')[2].Insert(1, ",").Insert(3, ","));
                                    }
                                }
                                sbNewContent.Append("\\" + issueCount + "\\").Append(issueSuffix + "\\");
                            }
                            sbNewContent.Append("#" + Regex.Split(content, @"\\#")[1] + "\\#" + Regex.Split(content, @"\\#")[2]);
                            sw.WriteLine(sbNewContent);
                        }
                        else
                            sw.WriteLine(content);
                    }
                    sw.Flush();
                    sw.Close();
                    srTemplate.Close();
                }
                else break;
            }
        }

        private void CreateFilterFileMultiPlugin(string saveDir, List<string> listFile, ref bool coverExistFile)
        {
            int m;//每个插件要过滤的升数
            int pluginCount = 0;//插件个数

            m = listFile.Count / Convert.ToInt32(nud_PluginCount.Value);

            string saveName = saveDir + "\\" + Utils.FindFileNameInPath(listFile[0]).Split('_')[0] + $"过滤条件{nud_PluginCount.Value}插件.flt";

            if (!coverExistFile && File.Exists(saveName))
                if(MessageBox.Show("文件已存在，是否覆盖？", "提示", MessageBoxButtons.YesNo) == DialogResult.No) return;
                else coverExistFile = true;

            StreamReader srTemplate = new StreamReader(lb_Template.Items[0].ToString(), Encoding.GetEncoding("GB2312"));
            StreamWriter sw = new StreamWriter(saveName, false, srTemplate.CurrentEncoding);
            int j = 0;
            while (!srTemplate.EndOfStream)
            {
                string content = srTemplate.ReadLine();
                if (content.StartsWith("分布纵向"))
                {

                    if (++pluginCount > nud_PluginCount.Value)
                    {
                        MessageBox.Show("输入插件个数小于模板中插件个数，请仔细检查");
                        srTemplate.Close();
                        sw.Close();
                        return;
                    }

                    StringBuilder sbNewContent = new StringBuilder();
                    //获取每一个文件期数后的后缀
                    string issueSuffix = Regex.Split(content, @"\\" + Utils.Substring(content, "每", "共") + @"\\")[1].Split('\\')[0];
                    sbNewContent.Append(content.Split('=')[0]).Append("=");

                    for (int i = j; i < m * pluginCount; i++)
                    {
                        int issueCount = 0;//期数
                        StreamReader srMedia = new StreamReader(listFile[i]);

                        sbNewContent.Append(Utils.FindFileNameInPath(listFile[i]));
                        while (!srMedia.EndOfStream)
                        {
                            string mediaContent = srMedia.ReadLine();
                            if (mediaContent.StartsWith("Y"))
                            {
                                issueCount++;
                                sbNewContent.Append("|").Append(mediaContent.Split('|')[2].Insert(1, ",").Insert(3, ","));
                            }
                        }
                        srMedia.Close();
                        sbNewContent.Append("\\" + issueCount + "\\").Append(issueSuffix + "\\");
                    }
                    sbNewContent.Append("#" + Regex.Split(content, @"\\#")[1] + "\\#" + Regex.Split(content, @"\\#")[2]);
                    sw.WriteLine(sbNewContent);
                    sw.Flush();
                    j += m;
                }
                else
                    sw.WriteLine(content);
            }

            sw.Close();
            srTemplate.Close();
        }
        #endregion

        #region 媒体分割

        private void ExportDividedMedia(List<string> list, bool exportZCB, string saveDir, string name, ref bool coverExistFiles)
        {
            int currentIndex = 0;//当前已输出的文件索引
            if (list.Count == 0) return;
            if(!Directory.Exists(saveDir)) Directory.CreateDirectory(saveDir);

            try
            {
                if (exportZCB)
                {
                    //i用来标记文件序号
                    for (int i = 1; i < Convert.ToInt32(cbx_FileCount_MediaDivide.Text) + 1; i++)
                    {
                        //当剩余文件数不能再形成一个完整文件时停止导出（有点难想）
                        if (currentIndex != 0 && ((list.Count - currentIndex - 1) < (fileGap + 1) * Convert.ToInt32(cbx_IssueCount_MediaDivide.Text))) return;
                        if (currentIndex == 0 && ((list.Count - currentIndex) < (fileGap + 1) * Convert.ToInt32(cbx_IssueCount_MediaDivide.Text)))
                        {
                            //MessageBox.Show("导入文件数量不足以进行切割");
                            return;
                        }

                        string fileName = saveDir + "\\" + name + "批量-" + i + ".zcb";

                        if (!coverExistFiles && File.Exists(fileName))
                            if ((MessageBox.Show("文件已存在，是否覆盖？", "提示", MessageBoxButtons.YesNo) == DialogResult.No)) return;
                            else coverExistFiles = true;

                        StreamWriter sw = new StreamWriter(fileName, false, Encoding.GetEncoding("GB2312"));
                        sw.WriteLine($"E|{cbx_ToleranceStart_MediaDivide.Text}-{cbx_ToleranceEnd_MediaDivide.Text}");
                        //j-计算索引 count-计算已导出个数
                        for (int count = 0; count < Convert.ToInt32(cbx_IssueCount_MediaDivide.Text); count++)
                        {
                            sw.WriteLine($"@1 1 --- --- {list[currentIndex]}");
                            currentIndex += (fileGap + 1);
                        }
                        sw.Flush();
                        sw.Close();
                    }
                }
                else
                {
                    string fileName = saveDir + "\\" + name + "-批量的批量.zbb";

                    if (!coverExistFiles && File.Exists(fileName))
                        if ((MessageBox.Show("文件已存在，是否覆盖？", "提示", MessageBoxButtons.YesNo) == DialogResult.No)) return;
                        else coverExistFiles = true;

                    StreamWriter sw = new StreamWriter(fileName, false, Encoding.GetEncoding("GB2312"));
                    sw.WriteLine($"E|{cbx_ToleranceStart_MediaDivide.Text}-{cbx_ToleranceEnd_MediaDivide.Text}");
                    //j-计算索引 count-计算已导出个数
                    for (int count = 0; count < list.Count; count++)
                    {
                        sw.WriteLine($"@1 1 --- --- {list[currentIndex]}");
                        currentIndex += (fileGap + 1);
                    }
                    sw.Flush();
                    sw.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
        #endregion
    }
}
