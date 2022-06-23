using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MediaFilter
{
    partial class MainForm
    {
        #region 导入区

        private void Btn_ImportFile_Click(object sender, EventArgs e)
        {
            commonOpenFileDialog.Title = "请选择需要导入的媒体文件夹";
            commonOpenFileDialog.IsFolderPicker = true;
            if(commonOpenFileDialog.ShowDialog() == Microsoft.WindowsAPICodePack.Dialogs.CommonFileDialogResult.Ok)
            {
                lbl_Tip.Visible = false;
                flp_Files.Visible = true;

                foreach(string dir in commonOpenFileDialog.FileNames.ToList())
                {
                    Label label = new Label();
                    label.Text = dir;
                    label.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
                    label.Size = new System.Drawing.Size(122, 122);
                    label.BorderStyle = BorderStyle.FixedSingle;
                    label.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
                    if (Directory.GetFiles(dir).Length > 0)
                        label.Image = Properties.Resources.IconFileYes;
                    else
                        label.Image = Properties.Resources.IconFileNone;
                    flp_Files.Controls.Add(label);
                }
            }
        }
        #endregion

        #region 设置区

        private void Txt_CountPlugin_Leave(object sender, EventArgs e)
        {
            if (!Regex.IsMatch((sender as TextBox).Text, "^[0-9]+$"))
            {
                MessageBox.Show("插件个数需要是正整数");
                txt_CountPlugin.Focus();
            }
            else
            {
                Properties.Settings.Default.CountPlugin = Convert.ToInt32((sender as TextBox).Text);
                Properties.Settings.Default.Save();
            }
        }

        private void Txt_CountBet_Leave(object sender, EventArgs e)
        {
            if (!Regex.IsMatch((sender as TextBox).Text, "^[0-9]+$"))
            {
                MessageBox.Show("注数需要是正整数");
                txt_CountPlugin.Focus();
            }
            else
            {
                Properties.Settings.Default.CountBet = Convert.ToInt32((sender as TextBox).Text);
                Properties.Settings.Default.Save();
            }
        }
        #endregion
    }
}
