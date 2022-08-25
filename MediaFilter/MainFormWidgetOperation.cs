using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections;
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
        #region 类型选择
        /// <summary>
        /// 过滤类型选择
        /// </summary>
        private void Cbx_SoccerType_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox cbx = sender as ComboBox;
            switch (cbx.Text)
            {
                case "排三":
                    pnl_Pai3.Visible = true;
                    pnl_MediaDivide_Pai3.Visible = false;
                    cbx_SoccerType.Text = "排三";
                    rdb_ImportDirectory.Checked = true;
                    break;
                case "媒体分割":
                    pnl_Pai3.Visible = false;
                    pnl_MediaDivide_Pai3.Visible = true;
                    cbx_SoccerType_MediaDivide_Pai3.Text = "媒体分割";
                    if (rdb_ImportFile_MediaDivide.Checked) importDir = false;

                    rdb_ImportFile_MediaDivide.Enabled = rdb_ExportZCB.Checked;
                    rdb_ImportDir_MediaDivide.Enabled = !rdb_ExportZCB.Checked;
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// 切割类型选择
        /// </summary>
        private void Rdb_DivideType_CheckedChanged(object sender, EventArgs e)
        {
            switch ((sender as RadioButton).Name)
            {
                case "rdb_DivideType_PaiSan":
                    rdb_ExportZBB.Enabled = true;
                    break;
                case "rdb_DivideType_ZuCai":
                    rdb_ExportZCB.Checked = true;
                    rdb_ExportZBB.Enabled = false;
                    break;
                case "rdb_DivideType_JinQiu":
                    rdb_ExportZCB.Checked = true;
                    rdb_ExportZBB.Enabled = false;
                    break;
            }
        }
        #endregion

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

            //选择文件且过滤器为空，才添加，否则会报错
            if (!commonOpenFileDialog.IsFolderPicker && commonOpenFileDialog.Filters.Count == 0)
            {
                commonOpenFileDialog.Filters.Add(new CommonFileDialogFilter("全部", "*"));
                commonOpenFileDialog.Filters.Add(new CommonFileDialogFilter("媒体", "lsm"));
                commonOpenFileDialog.Filters.Add(new CommonFileDialogFilter("模板", "flt"));
            }

            isFileImport = !importDir;

            if (commonOpenFileDialog.ShowDialog() == CommonFileDialogResult.Ok)
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
                        listIssue.Add(Utils.FindFileNameInPath(dir));
                    }
                    listIssue.Sort(new String_FileName_Sort());

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

            //选择文件且过滤器为空，才添加，否则会报错
            if (commonOpenFileDialog.Filters.Count == 0)
            {
                commonOpenFileDialog.Filters.Add(new CommonFileDialogFilter("全部", "*"));
                commonOpenFileDialog.Filters.Add(new CommonFileDialogFilter("媒体", "lsm"));
                commonOpenFileDialog.Filters.Add(new CommonFileDialogFilter("模板", "flt"));
            }

            if (commonOpenFileDialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                lb_Template.Items.Clear();
                foreach (string file in commonOpenFileDialog.FileNames.ToList())
                {
                    lb_Template.Items.Add(file);
                }
            }
        }

        private void Btn_Import_MediaDivide_Click(object sender, EventArgs e)
        {
            commonOpenFileDialog.Title = "请导入需要分割的文件";
            commonOpenFileDialog.IsFolderPicker = true;
            if (importDir) commonOpenFileDialog.Multiselect = true;
            else commonOpenFileDialog.Multiselect = false;
            commonOpenFileDialog.InitialDirectory = Properties.Settings.Default.ImportDivideLocation;

            //选择文件且过滤器为空，才添加，否则会报错
            if (!commonOpenFileDialog.IsFolderPicker && commonOpenFileDialog.Filters.Count == 0)
            {
                commonOpenFileDialog.Filters.Add(new CommonFileDialogFilter("全部", "*"));
                commonOpenFileDialog.Filters.Add(new CommonFileDialogFilter("媒体", "lsm"));
                commonOpenFileDialog.Filters.Add(new CommonFileDialogFilter("模板", "flt"));
            }

            isFileImport = !importDir;

            if (commonOpenFileDialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                lb_MediaDivide.Items.Clear();
                List<FileInfo> listFile = new List<FileInfo>();

                Properties.Settings.Default.ImportDivideLocation = commonOpenFileDialog.FileNames.First();
                //if (importDir) Properties.Settings.Default.ImportDivideLocation = commonOpenFileDialog.FileNames.First();
                //else Properties.Settings.Default.ImportDivideLocation = Utils.GetDirectoryFromPath(commonOpenFileDialog.FileNames.First());
                Properties.Settings.Default.Save();

                if (importDir)
                    foreach (string file in commonOpenFileDialog.FileNames)
                    {
                        listFile.Add(new FileInfo(file));
                    }
                else
                    foreach (string file in Directory.GetFiles(commonOpenFileDialog.FileName).ToList())
                    {
                        listFile.Add(new FileInfo(file));
                    }

                listFile.Sort(new FileInfo_FileName_Sort());
                foreach (FileInfo file in listFile)
                    lb_MediaDivide.Items.Add(file.FullName);

                cbx_IssueStart_MediaDivide.Items.Clear();
                cbx_IssueEnd_MediaDivide.Items.Clear();
                //if (importDir)
                //{
                    cbx_IssueStart_MediaDivide.Items.AddRange(listFile.Select(file => Utils.FindFileNameInPath(file.FullName)).ToArray());
                    cbx_IssueEnd_MediaDivide.Items.AddRange(listFile.Select(file => Utils.FindFileNameInPath(file.FullName)).ToArray());
                //}
                //else
                //{
                //    cbx_IssueStart_MediaDivide.Items.AddRange(listFile.Select(file => Utils.FindFileNameInPath(file.FullName).Substring(0, 7)).ToArray());
                //    cbx_IssueEnd_MediaDivide.Items.AddRange(listFile.Select(file => Utils.FindFileNameInPath(file.FullName).Substring(0, 7)).ToArray());
                //}
                cbx_IssueStart_MediaDivide.SelectedIndex = 0;
                cbx_IssueEnd_MediaDivide.SelectedIndex = listFile.Count - 1;
            }
        }
        #endregion

        #region 导出区
        #region 排三
        /// <summary>
        /// 排三媒体过滤插件个数设置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Nud_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.GetType().GetProperty((sender as NumericUpDown).Name.Replace("nud_", "")).SetValue(Properties.Settings.Default, Convert.ToInt32((sender as NumericUpDown).Value), null);
            Properties.Settings.Default.Save();
        }

        /// <summary>
        /// 排三媒体过滤模式选择
        /// </summary>
        private void Cbx_ExportMode_SelectedValueChanged(object sender, EventArgs e)
        {
            if ((sender as ComboBox).SelectedItem != null)
                exportMode = Convert.ToInt32(((DictionaryEntry)(sender as ComboBox).SelectedItem).Key);
        }

        /// <summary>
        /// 排三媒体过滤导出
        /// </summary>
        private void Btn_Export_Click(object sender, EventArgs e)
        {
            try
            {
                bool cover = false;//是否覆盖同名文件，避免重复提示

                if (lb_MediaFile.Items.Count == 0 || lb_Template.Items.Count == 0) return;
                if (cbx_IssueEnd.Text.CompareTo(cbx_IssueStart.Text) < 0) { MessageBox.Show("期号范围选择错误"); return; }

                commonOpenFileDialog.Title = "请选择过滤文件保存位置";
                commonOpenFileDialog.IsFolderPicker = true;
                commonOpenFileDialog.Multiselect = false;
                commonOpenFileDialog.InitialDirectory = Properties.Settings.Default.ExportFilterLocation;

                if (commonOpenFileDialog.ShowDialog() == CommonFileDialogResult.Ok)
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

                        if (nud_PluginCount.Value == 1) CreateFilterFileOnePlugin(saveDir, list, ref cover);
                        else CreateFilterFileMultiPlugin(saveDir, list, ref cover);
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

                                if (nud_PluginCount.Value == 1) CreateFilterFileOnePlugin(saveDir, files, ref cover);
                                else CreateFilterFileMultiPlugin(saveDir, files, ref cover);
                            }
                        }
                    }

                    MessageBox.Show("导出成功");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("导出失败，" + ex.Message);
            }
        }
        #endregion

        #region 媒体过滤
        private void Rdb_ExportZBB_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as RadioButton).Checked)
            {
                if (rdb_ImportFile_MediaDivide.Checked && lb_MediaDivide.Items.Count > 0)
                {
                    MessageBox.Show("批量批量导出时，只能导入目录，请重新导入");
                    lb_MediaDivide.Items.Clear();
                }
                rdb_ImportFile_MediaDivide.Enabled = false;
                rdb_ImportDir_MediaDivide.Enabled = true;
                rdb_ImportDir_MediaDivide.Checked = true;
            }
        }

        private void Rdb_ExportZCB_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as RadioButton).Checked)
            {
                if (rdb_ImportDir_MediaDivide.Checked && lb_MediaDivide.Items.Count > 0)
                {
                    MessageBox.Show("批量导出时，只能导入文件，请重新导入");
                    lb_MediaDivide.Items.Clear();
                }
                rdb_ImportDir_MediaDivide.Enabled = false;
                rdb_ImportFile_MediaDivide.Enabled = true;
                rdb_ImportFile_MediaDivide.Checked = true;
            }
        }

        /// <summary>
        /// 媒体切割导出
        /// </summary>
        private void Btn_Export_MediaDivide_Click(object sender, EventArgs e)
        {
            try
            {
                bool cover = false;

                if (lb_MediaDivide.Items.Count == 0) return;
                if (cbx_IssueEnd_MediaDivide.Text.CompareTo(cbx_IssueStart_MediaDivide.Text) < 0) { MessageBox.Show("期号范围选择错误"); return; }

                commonOpenFileDialog.Title = "请选择导出文件保存位置";
                commonOpenFileDialog.IsFolderPicker = true;
                commonOpenFileDialog.Multiselect = false;
                commonOpenFileDialog.InitialDirectory = Properties.Settings.Default.ExportDivideFileLocation;

                if (commonOpenFileDialog.ShowDialog() == CommonFileDialogResult.Ok)
                {
                    Properties.Settings.Default.ExportDivideFileLocation = commonOpenFileDialog.FileName;
                    Properties.Settings.Default.Save();

                    string saveDir;
                    if (exportDir)
                    {
                        frmInputDirName.initialDirName = saveDirName;
                        frmInputDirName.ShowDialog();

                        saveDir = commonOpenFileDialog.FileName + "\\" + saveDirName;

                        if (string.IsNullOrEmpty(saveDirName)) return;
                        if (Directory.Exists(saveDir))
                            if (MessageBox.Show("文件夹已存在，是否覆盖", "提示", MessageBoxButtons.YesNo) == DialogResult.No) return;
                            else cover = true;
                    }
                    else
                    {
                        saveDir = commonOpenFileDialog.FileName;
                    }

                    List<string> list = new List<string>();
                    for (int i = 0; i < lb_MediaDivide.Items.Count; i ++)
                    {
                        string fileName = Utils.FindFileNameInPath(lb_MediaDivide.Items[i].ToString());//.Length > 7 ? Utils.FindFileNameInPath(lb_MediaDivide.Items[i].ToString()).Substring(0, 7) : Utils.FindFileNameInPath(lb_MediaDivide.Items[i].ToString());
                        if (fileName.CompareTo(cbx_IssueStart_MediaDivide.Text) >= 0 && fileName.CompareTo(cbx_IssueEnd_MediaDivide.Text) <= 0)
                        {
                            if (rdb_ExportZCB.Checked)
                            {
                                for (int j = i; j >= 0; j--) list.Add(lb_MediaDivide.Items[j].ToString());
                                ExportDividedMedia(list, rdb_ExportZCB.Checked, exportDir ? saveDir + "\\" + fileName : saveDir, fileName, ref cover);
                            }
                            if (rdb_ExportZBB.Checked)
                            {
                                list.AddRange(Utils.GetFileFromPath(lb_MediaDivide.Items[i].ToString()));
                                ExportDividedMedia(list, rdb_ExportZCB.Checked, saveDir, fileName, ref cover);
                            }
                        }
                        list.Clear();
                    }

                    MessageBox.Show("结束导出");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("导出失败，" + ex.Message);
            }
        }
        #endregion
        #endregion

        #region 共用组件操作函数

        private void Btn_DataClear_Click(object sender, EventArgs e)
        {

            switch ((sender as Button).Name)
            {
                case "btn_MediaClear":
                    lb_MediaFile.Items.Clear();
                    break;
                case "btn_TemplateClear":
                    lb_Template.Items.Clear();
                    break;
                case "btn_Clear_MediaDivide":
                    lb_MediaDivide.Items.Clear();
                    cbx_IssueStart_MediaDivide.Items.Clear();
                    cbx_IssueEnd_MediaDivide.Items.Clear();
                    break;
                default:
                    MessageBox.Show("清空失败");
                    break;
            }
        }

        private void DeleteTip(object sender, EventArgs e)
        {
            ListBox lb = (sender as Button).Tag as ListBox;
            //bool? deleteLocalTemplate = null;
            if (lb.SelectedItems.Count > 0 && MessageBox.Show("确定删除选中项吗？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int count = lb.SelectedItems.Count;
                for (int i = 0; i < count;)
                {
                    //if (deleteLocalTemplate == null)
                    //{
                    //    if (lb.Name.Equals("lb_Template") && MessageBox.Show("是否删除已保存的历史模板？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes) deleteLocalTemplate = true;
                    //    else deleteLocalTemplate = false;
                    //}
                    //if (Convert.ToBoolean(deleteLocalTemplate)) File.Delete(lb.SelectedItems[i].ToString());
                    lb.Items.Remove(lb.SelectedItems[i]);
                    count = lb.SelectedItems.Count;
                    i = 0;
                }
            }
        }

        private void Cbx_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.GetType().GetProperty((sender as ComboBox).Name.Replace("cbx_", "")).SetValue(Properties.Settings.Default, Convert.ToInt32((sender as ComboBox).Text), null);
            Properties.Settings.Default.Save();

            if ((sender as ComboBox).Name.Equals("cbx_FileGap_MediaDivide"))
                fileGap = Convert.ToInt32((sender as ComboBox).Text);
        }

        private void RdBtn_ExportDirectory_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as RadioButton).Checked) exportDir = true;
            else exportDir = false;
        }
        #endregion
    }
}
