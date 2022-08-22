using MediaFilter.SupplementWindow;
using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MediaFilter
{
    public partial class MainForm : Form
    {
        private bool importDir = true;
        /// <summary>
        /// 以目录的形式导出
        /// </summary>
        private bool exportDir = true;
        private bool isFileImport = true;//媒体导入的时候是以文件的形式导入的
        /// <summary>
        /// 以目录形式导出时要保存的目录名字
        /// </summary>
        private string saveDirName = "";
        /// <summary>
        /// 导出模式:0-横模式 1-纵模式
        /// </summary>
        private int exportMode = 0;
        /// <summary>
        /// 排三媒体分割的隔期
        /// </summary>
        private int fileGap = 0;
        private CommonOpenFileDialog commonOpenFileDialog = new CommonOpenFileDialog() { AllowNonFileSystemItems = true };
        private FrmInputDirName frmInputDirName = new FrmInputDirName();

        public MainForm()
        {
            InitializeComponent();
            InitializeUI();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            frmInputDirName.SaveDirName_Event += FrmInputDirName_SaveDirName_Event;
        }

        private void FrmInputDirName_SaveDirName_Event(string dirName)
        {
            saveDirName = dirName;
            frmInputDirName.Close();
        }

        private void InitializeUI()
        {
            SetCBXSoccerType(cbx_SoccerType);
            SetCBXSoccerType(cbx_SoccerType_MediaDivide_Pai3);

            cbx_SoccerType.SelectedIndex = 0;
            cbx_ExportMode.Items.Add(new DictionaryEntry(0, "横向"));
            cbx_ExportMode.Items.Add(new DictionaryEntry(1, "纵向"));
            cbx_ExportMode.DisplayMember = "value";
            cbx_ExportMode.ValueMember = "key";
            cbx_ExportMode.SelectedIndex = 0;

            nud_PluginCount.Value = Properties.Settings.Default.PluginCount;
            cbx_FileCount_MediaDivide.Text = Properties.Settings.Default.FileCount_MediaDivide.ToString();
            cbx_IssueCount_MediaDivide.Text = Properties.Settings.Default.IssueCount_MediaDivide.ToString();
            cbx_ToleranceStart_MediaDivide.Text = Properties.Settings.Default.ToleranceStart_MediaDivide.ToString();
            cbx_ToleranceEnd_MediaDivide.Text = Properties.Settings.Default.ToleranceEnd_MediaDivide.ToString();
            cbx_FileGap_MediaDivide.Text = Properties.Settings.Default.FileGap_MediaDivide.ToString();

            lb_Template.Items.Clear();
            lb_MediaFile.Items.Clear();

            btn_DeleteMedia.Tag = lb_MediaFile;
            btn_DeleteTemplate.Tag = lb_Template;
            btn_Delete_MediaDivide.Tag = lb_MediaDivide;

            btn_ImportMedia.Enabled = true;
            btn_ImportTemplate.Enabled = true;
            btn_Export.Enabled = true;

            if ((DateTime.Parse("2022-09-15") - DateTime.Now).TotalDays <= 0)
            {
                cbx_SoccerType.Enabled = false;
            }
            else
            {
                cbx_SoccerType.Enabled = true;
            }
        }

        /// <summary>
        /// 设置当前要处理的过滤类型
        /// </summary>
        /// <param name="cbx"></param>
        private void SetCBXSoccerType(ComboBox cbx)
        {
            cbx.Items.Add("排三");
            cbx.Items.Add("媒体分割");
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

        private void Btn_SaveTemplate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Directory.Exists(Application.StartupPath + "\\HisTempaltes")) Directory.CreateDirectory(Application.StartupPath + "\\HisTempaltes");

                if (lb_Template.SelectedItems.Count > 0)
                {
                    foreach (var item in lb_Template.SelectedItems)
                        File.Copy(item.ToString(), Application.StartupPath + "\\HisTempaltes\\" + item.ToString().Substring(item.ToString().LastIndexOf(@"\") + 1, item.ToString().Length - item.ToString().LastIndexOf(@"\") - 1), true);
                    MessageBox.Show("保存成功！");
                }
                else
                    MessageBox.Show("请选择要保存的模板！");
            }
            catch (Exception ex)
            {
                MessageBox.Show("保存失败，" + ex.Message);
            }
        }
    }
}
