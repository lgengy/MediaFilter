using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MediaFilter
{
    public partial class MainForm : Form
    {
        private bool importDir = false;
        /// <summary>
        /// 以目录的形式导出
        /// </summary>
        private bool exportDir = true;
        private bool isFileImport = true;//媒体导入的时候是以文件的形式导入的
        private List<string> listFile = new List<string>();
        private CommonOpenFileDialog commonOpenFileDialog = new CommonOpenFileDialog();

        public MainForm()
        {
            InitializeComponent();
            InitializeUI();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            commonOpenFileDialog.Filters.Add(new CommonFileDialogFilter("全部","*"));
            commonOpenFileDialog.Filters.Add(new CommonFileDialogFilter("媒体", "lsm"));
            commonOpenFileDialog.Filters.Add(new CommonFileDialogFilter("模板", "flt"));
        }

        private void InitializeUI()
        {
            cbx_SoccerType.SelectedIndex = 0;
            cbx_ExportMode.SelectedIndex = 0;

            txt_CountPlugin.Text = Properties.Settings.Default.CountPlugin.ToString();

            lb_Template.Items.Clear();
            lb_MediaFile.Items.Clear();

            btn_DeleteMedia.Tag = lb_MediaFile;
            btn_DeleteTemplate.Tag = lb_Template;

            if ((DateTime.Now - DateTime.Parse("2022-07-10")).TotalDays > 14)
            {
                btn_ImportFile.Enabled = false;
                btn_ImportTemplate.Enabled = false;
                cbx_SoccerType.Enabled = false;
            }
            else
            {
                btn_ImportFile.Enabled = true;
                btn_ImportTemplate.Enabled = true;
                cbx_SoccerType.Enabled = true;
            }
        }

        /// <summary>
        /// 设置groupbox边框的颜色
        /// </summary>
        private void SetGroupBoxBorder(object sender, PaintEventArgs e)
        {
            GroupBox gbx = (GroupBox)sender;
            e.Graphics.DrawLine(Pens.DeepSkyBlue, 1, 7, 8, 7);
            e.Graphics.DrawLine(Pens.DeepSkyBlue, e.Graphics.MeasureString(gbx.Text, gbx.Font).Width + 8, 7, gbx.Width - 2, 7);
            e.Graphics.DrawLine(Pens.DeepSkyBlue, 1, 7, 1, gbx.Height - 2);
            e.Graphics.DrawLine(Pens.DeepSkyBlue, 1, gbx.Height - 2, gbx.Width - 2, gbx.Height - 2);
            e.Graphics.DrawLine(Pens.DeepSkyBlue, gbx.Width - 2, 7, gbx.Width - 2, gbx.Height - 2);
        }

        private void DeleteTip(object sender, EventArgs e)
        {
            ListBox lb = (sender as Button).Tag as ListBox;
            bool? deleteLocalTemplate = null;
            if(lb.SelectedItems.Count > 0 && MessageBox.Show("确定删除选中项吗？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int count = lb.SelectedItems.Count;
                for (int i = 0; i < count; )
                {
                    if (deleteLocalTemplate == null)
                    {
                        if (lb.Name.Equals("lb_Template") && MessageBox.Show("是否删除已保存的历史模板？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes) deleteLocalTemplate = true;
                        else deleteLocalTemplate = false;
                    }
                    if (Convert.ToBoolean(deleteLocalTemplate)) File.Delete(lb.SelectedItems[i].ToString());
                    lb.Items.Remove(lb.SelectedItems[i]);
                    count = lb.SelectedItems.Count;
                    i = 0;
                }
            }
        }

        private void Btn_SaveTemplate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Directory.Exists(Application.StartupPath + "\\HisTempaltes")) Directory.CreateDirectory(Application.StartupPath + "\\HisTempaltes");

                if (lb_Template.Items.Count > 0)
                {
                    foreach (var item in lb_Template.Items)
                        File.Copy(item.ToString(), Application.StartupPath + "\\HisTempaltes\\" + item.ToString().Substring(item.ToString().LastIndexOf(@"\") + 1, item.ToString().Length - item.ToString().LastIndexOf(@"\") - 1), true);
                    MessageBox.Show("保存成功！");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("保存失败，" + ex.Message);
            }
        }
    }
}
