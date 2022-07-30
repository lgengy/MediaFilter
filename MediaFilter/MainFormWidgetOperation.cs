using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MediaFilter
{
    partial class MainForm
    {
        #region 导入区

        private void Rdb_ImportFile_CheckedChanged(object sender, EventArgs e)
        {
            importDir = !(sender as RadioButton).Checked;
        }

        private void Btn_ImportMedia_Click(object sender, EventArgs e)
        {
            commonOpenFileDialog.Title = "请选择需要导入的媒体文件";
            commonOpenFileDialog.IsFolderPicker = importDir;
            commonOpenFileDialog.Multiselect = true;
            commonOpenFileDialog.InitialDirectory = Properties.Settings.Default.ImportMediaLocation;

            isFileImport = !importDir;

            if (commonOpenFileDialog.ShowDialog() == Microsoft.WindowsAPICodePack.Dialogs.CommonFileDialogResult.Ok)
            {
                lb_MediaFile.Items.Clear();
                List<FileInfo> listFile = new List<FileInfo>();

                if (importDir) Properties.Settings.Default.ImportMediaLocation = commonOpenFileDialog.FileNames.First();
                else Properties.Settings.Default.ImportMediaLocation = Utils.GetDirectoryFromPath(commonOpenFileDialog.FileNames.First());
                Properties.Settings.Default.Save();

                if (importDir)
                {
                    List<string> listIssue = new List<string>();
                    //导入的是目录的话直接添加
                    foreach (string dir in commonOpenFileDialog.FileNames)
                    {
                        lb_MediaFile.Items.Add(dir);
                        listIssue.Add(Utils.FindFileNameInPath(dir).Substring(0, 7));
                    }

                    cbx_IssueStart.Items.Clear();
                    cbx_IssueEnd.Items.Clear();
                    cbx_IssueStart.Items.AddRange(listIssue.ToArray());
                    cbx_IssueEnd.Items.AddRange(listIssue.ToArray());
                    cbx_IssueStart.SelectedIndex = 0;
                    cbx_IssueEnd.SelectedIndex = listIssue.Count - 1;
                }
                else
                {
                    //导入的是文件的话按文件名排序后添加
                    foreach (string file in commonOpenFileDialog.FileNames)
                    {
                        listFile.Add(new FileInfo(file));
                    }
                    listFile.Sort(new FileInfo_FileName_Sort());
                    foreach (FileInfo file in listFile)
                        lb_MediaFile.Items.Add(file.FullName);

                    cbx_IssueStart.Items.Clear();
                    cbx_IssueEnd.Items.Clear();
                    cbx_IssueStart.Items.Add(Utils.FindFileNameInPath(listFile[0].FullName).Substring(0, 7));
                    cbx_IssueEnd.Items.Add(Utils.FindFileNameInPath(listFile[0].FullName).Substring(0, 7));
                    cbx_IssueStart.SelectedIndex = 0;
                    cbx_IssueEnd.SelectedIndex = 0;
                }
            }
        }

        private void Btn_ImportTemplate_Click(object sender, EventArgs e)
        {
            commonOpenFileDialog.Title = "请选择需要导入的过滤文件";
            commonOpenFileDialog.IsFolderPicker = false;
            commonOpenFileDialog.Multiselect = true;
            commonOpenFileDialog.InitialDirectory = Application.StartupPath + "\\HisTempaltes";

            if (commonOpenFileDialog.ShowDialog() == Microsoft.WindowsAPICodePack.Dialogs.CommonFileDialogResult.Ok)
            {
                if (!btn_ImportMedia.Enabled) btn_ImportMedia.Enabled = true;
                lb_Template.Items.Clear();
                foreach (string file in commonOpenFileDialog.FileNames.ToList())
                {
                    lb_Template.Items.Add(file);
                }
            }
        }
        #endregion

        #region 设置区
        #endregion

        #region 导出区

        private void RdBtn_ExportDirectory_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as RadioButton).Checked) exportDir = true;
            else exportDir = false;
        }

        private void Btn_Export_Click(object sender, EventArgs e)
        {
            try
            {
                if (lb_MediaFile.Items.Count == 0 || lb_Template.Items.Count == 0) return;
                if (cbx_IssueEnd.Text.CompareTo(cbx_IssueStart.Text) < 0) { MessageBox.Show("期号范围选择错误"); return; }

                commonOpenFileDialog.Title = "请选择过滤文件保存位置";
                commonOpenFileDialog.IsFolderPicker = true;
                commonOpenFileDialog.Multiselect = false;
                commonOpenFileDialog.InitialDirectory = Properties.Settings.Default.ExportFilterLocation;

                if (commonOpenFileDialog.ShowDialog() == Microsoft.WindowsAPICodePack.Dialogs.CommonFileDialogResult.Ok)
                {
                    Properties.Settings.Default.ExportFilterLocation = commonOpenFileDialog.FileName;
                    Properties.Settings.Default.Save();

                    string saveDir;
                    if (exportDir)
                    {
                        frmInputDirName.initialDirName = saveDirName;
                        frmInputDirName.ShowDialog();

                        saveDir = commonOpenFileDialog.FileName + "\\" + saveDirName;

                        if (string.IsNullOrEmpty(saveDirName)) return;
                        if (Directory.Exists(saveDir) && MessageBox.Show("文件夹已存在，是否覆盖", "提示", MessageBoxButtons.YesNo) == DialogResult.No) return;

                        Directory.CreateDirectory(saveDir);
                    }
                    else
                    {
                        saveDir = commonOpenFileDialog.FileName;
                    }

                    List<string> list = new List<string>();
                    foreach (var item in lb_MediaFile.Items) list.Add(item.ToString());

                    if (isFileImport)
                    {
                        list.Sort(new String_FileName_Sort());

                        if (exportMode == 1)
                        {
                            list = CheckColumnMode(list);
                            if (list.Count == 0) return;
                        }

                        if (nud_PluginCount.Value == 1) CreateFilterFileOnePlugin(saveDir, list);
                        else CreateFilterFileMultiPlugin(saveDir, list);
                    }
                    else
                    {
                        foreach (string fullPath in list)
                        {
                            if (Utils.FindFileNameInPath(fullPath).Substring(0, 7).CompareTo(cbx_IssueStart.Text) >= 0 && Utils.FindFileNameInPath(fullPath).Substring(0, 7).CompareTo(cbx_IssueEnd.Text) <= 0)
                            {
                                List<string> files = Directory.GetFiles(fullPath, "*.lsm").ToList();
                                files.Sort(new String_FileName_Sort());

                                if (exportMode == 1)
                                {
                                    files = CheckColumnMode(files);
                                    if (files.Count == 0) return;
                                }

                                if (nud_PluginCount.Value == 1) CreateFilterFileOnePlugin(saveDir, files);
                                else CreateFilterFileMultiPlugin(saveDir, files);
                            }
                        }

                        MessageBox.Show("导出成功");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("导出失败，" + ex.Message);
            }
        }

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

        private void CreateFilterFileOnePlugin(string saveDir, List<string> listFile)
        {
            int n = 0;//升数
            string name = ""; //用于计算n
            int pluginCount;//插件个数
            int fileCount = 0;//生成文件个数
            bool cover = false;//是否覆盖同名文件

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

                    if (!cover && File.Exists(saveName) && MessageBox.Show("文件已存在，是否覆盖？", "提示", MessageBoxButtons.YesNo) == DialogResult.No) return;
                    else cover = true;

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

        private void CreateFilterFileMultiPlugin(string saveDir, List<string> listFile)
        {
            int m;//每个插件要过滤的升数
            int pluginCount = 0;//插件个数
            bool cover = false;//是否覆盖同名文件

            m = listFile.Count / Convert.ToInt32(nud_PluginCount.Value);

            string saveName = saveDir + "\\" + Utils.FindFileNameInPath(listFile[0]).Split('_')[0] + $"过滤条件{nud_PluginCount.Value}插件.flt";

            if (!cover && File.Exists(saveName) && MessageBox.Show("文件已存在，是否覆盖？", "提示", MessageBoxButtons.YesNo) == DialogResult.No) return;
            else cover = true;

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
    }
}
