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
                case "排三媒体分割":
                    pnl_Pai3.Visible = false;
                    pnl_MediaDivide_Pai3.Visible = true;
                    cbx_SoccerType_MediaDivide_Pai3.Text = "排三媒体分割";
                    break;
                default:
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
            if(!commonOpenFileDialog.IsFolderPicker && commonOpenFileDialog.Filters.Count == 0)
            {
                commonOpenFileDialog.Filters.Add(new CommonFileDialogFilter("全部", "*"));
                commonOpenFileDialog.Filters.Add(new CommonFileDialogFilter("媒体", "lsm"));
                commonOpenFileDialog.Filters.Add(new CommonFileDialogFilter("模板", "flt"));
            }

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

        private void Btn_Import_MediaDivide_Pai3_Click(object sender, EventArgs e)
        {
            commonOpenFileDialog.Title = "请导入需要分割的文件";
            commonOpenFileDialog.IsFolderPicker = importDir;
            commonOpenFileDialog.Multiselect = true;
            commonOpenFileDialog.InitialDirectory = Properties.Settings.Default.ImportDividePai3Location;

            //选择文件且过滤器为空，才添加，否则会报错
            if (!commonOpenFileDialog.IsFolderPicker && commonOpenFileDialog.Filters.Count == 0)
            {
                commonOpenFileDialog.Filters.Add(new CommonFileDialogFilter("全部", "*"));
                commonOpenFileDialog.Filters.Add(new CommonFileDialogFilter("媒体", "lsm"));
                commonOpenFileDialog.Filters.Add(new CommonFileDialogFilter("模板", "flt"));
            }

            isFileImport = !importDir;

            if (commonOpenFileDialog.ShowDialog() == Microsoft.WindowsAPICodePack.Dialogs.CommonFileDialogResult.Ok)
            {
                lb_MediaDivide.Items.Clear();
                List<FileInfo> listFile = new List<FileInfo>();

                if (importDir) Properties.Settings.Default.ImportDividePai3Location = commonOpenFileDialog.FileNames.First();
                else Properties.Settings.Default.ImportDividePai3Location = Utils.GetDirectoryFromPath(commonOpenFileDialog.FileNames.First());
                Properties.Settings.Default.Save();

                if (importDir)
                {
                    List<string> listIssue = new List<string>();
                    //导入的是目录的话直接添加
                    foreach (string dir in commonOpenFileDialog.FileNames)
                    {
                        lb_MediaDivide.Items.Add(dir);
                        listIssue.Add((Utils.FindFileNameInPath(dir).Length >= 7) ? Utils.FindFileNameInPath(dir).Substring(0, 7) : Utils.FindFileNameInPath(dir));
                    }

                    listIssue.Sort(new String_FileName_Sort());
                    cbx_IssueStart_MediaDivide_pai3.Items.Clear();
                    cbx_IssueEnd_MediaDivide_pai3.Items.Clear();
                    cbx_IssueStart_MediaDivide_pai3.Items.AddRange(listIssue.ToArray());
                    cbx_IssueEnd_MediaDivide_pai3.Items.AddRange(listIssue.ToArray());
                    cbx_IssueStart_MediaDivide_pai3.SelectedIndex = 0;
                    cbx_IssueEnd_MediaDivide_pai3.SelectedIndex = listIssue.Count - 1;
                }
                else
                {
                    //导入的是文件的话按文件名排序后添加
                    foreach (string file in commonOpenFileDialog.FileNames)
                    {
                        listFile.Add(new FileInfo(file));
                    }

                    listFile.Sort(new FileInfo_FileName_Sort());
                    listFile.Reverse();
                    foreach (FileInfo file in listFile)
                        lb_MediaDivide.Items.Add(file.FullName);

                    cbx_IssueStart_MediaDivide_pai3.Items.Clear();
                    cbx_IssueEnd_MediaDivide_pai3.Items.Clear();
                    cbx_IssueStart_MediaDivide_pai3.Items.AddRange(listFile.Select(file => Utils.FindFileNameInPath(file.FullName).Substring(0, 7)).ToArray());
                    cbx_IssueEnd_MediaDivide_pai3.Items.AddRange(listFile.Select(file => Utils.FindFileNameInPath(file.FullName).Substring(0, 7)).ToArray());
                    cbx_IssueStart_MediaDivide_pai3.SelectedIndex = listFile.Count - 1;
                    cbx_IssueEnd_MediaDivide_pai3.SelectedIndex = 0;
                }
            }
        }
        #endregion

        #region 导出区
        /// <summary>
        /// 排三媒体过滤模式选择
        /// </summary>
        private void Cbx_ExportMode_SelectedValueChanged(object sender, EventArgs e)
        {
            if ((sender as ComboBox).SelectedItem != null)
                exportMode = Convert.ToInt32(((DictionaryEntry)(sender as ComboBox).SelectedItem).Key);
        }

        /// <summary>
        /// 隔期设置
        /// </summary>
        private void Rdb_FileGap_CheckedChanged(object sender, EventArgs e)
        {
            fileGap = Convert.ToInt32((sender as RadioButton).Text);
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
                    }

                    MessageBox.Show("导出成功");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("导出失败，" + ex.Message);
            }
        }

        private void Btn_Export_MediaDivide_Pai3_Click(object sender, EventArgs e)
        {
            try
            {
                if (lb_MediaDivide.Items.Count == 0) return;
                if (cbx_IssueEnd_MediaDivide_pai3.Text.CompareTo(cbx_IssueStart_MediaDivide_pai3.Text) < 0) { MessageBox.Show("期号范围选择错误"); return; }

                commonOpenFileDialog.Title = "请选择导出文件保存位置";
                commonOpenFileDialog.IsFolderPicker = true;
                commonOpenFileDialog.Multiselect = false;
                commonOpenFileDialog.InitialDirectory = Properties.Settings.Default.ExportDivideFileLocation;

                if (commonOpenFileDialog.ShowDialog() == Microsoft.WindowsAPICodePack.Dialogs.CommonFileDialogResult.Ok)
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
                        if (Directory.Exists(saveDir) && MessageBox.Show("文件夹已存在，是否覆盖", "提示", MessageBoxButtons.YesNo) == DialogResult.No) return;

                        Directory.CreateDirectory(saveDir);
                    }
                    else
                    {
                        saveDir = commonOpenFileDialog.FileName;
                    }

                    List<string> list = new List<string>();
                    foreach (var item in lb_MediaDivide.Items)
                    {
                        string fileName = Utils.FindFileNameInPath(item.ToString()).Length > 7 ? Utils.FindFileNameInPath(item.ToString()).Substring(0, 7) : Utils.FindFileNameInPath(item.ToString());
                        if (fileName.CompareTo(cbx_IssueStart_MediaDivide_pai3.Text) >= 0 && fileName.CompareTo(cbx_IssueEnd_MediaDivide_pai3.Text) <= 0)
                            list.Add(item.ToString());
                    }

                    if (isFileImport)
                    {
                        list.Sort(new String_FileName_Sort());
                        list.Reverse();
                        ExportDividedMedia(list, rdb_ExportZCB.Checked, saveDir);
                    }
                    else
                    {
                        foreach (string fullPath in list)
                        {
                            List<string> files = Directory.GetFiles(fullPath, rdb_ExportZCB.Checked ? "*.flt" : "*.zcb").ToList();
                            files.Sort(new String_FileName_Sort());
                            files.Reverse();
                            ExportDividedMedia(files, rdb_ExportZCB.Checked, saveDir);
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
                case "btn_Clear_MediaDivide_Pai3":
                    lb_MediaDivide.Items.Clear();
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

        private void Nud_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.GetType().GetProperty((sender as NumericUpDown).Name.Replace("nud_", "")).SetValue(Properties.Settings.Default, Convert.ToInt32((sender as NumericUpDown).Value), null);
            Properties.Settings.Default.Save();
        }

        private void RdBtn_ExportDirectory_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as RadioButton).Checked) exportDir = true;
            else exportDir = false;
        }
        #endregion
    }
}
