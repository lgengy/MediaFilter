using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MediaFilter
{
    public partial class MainForm : Form
    {
        private CommonOpenFileDialog commonOpenFileDialog = new CommonOpenFileDialog();

        public MainForm()
        {
            InitializeComponent();
            InitializeUI();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            commonOpenFileDialog.DefaultDirectory = Properties.Settings.Default.ImportFileLocation;
            commonOpenFileDialog.Multiselect = true;
        }

        private void InitializeUI()
        {
            cbx_SoccerType.SelectedIndex = 0;
            cbx_ExportMode.SelectedIndex = 0;

            txt_CountBet.Text = Properties.Settings.Default.CountBet.ToString();
            txt_CountPlugin.Text = Properties.Settings.Default.CountPlugin.ToString();

            lb_Templates.Items.Clear();
            flp_Files.Visible = false;
            pnl_Templates.Visible = false;

            if ((DateTime.Now - DateTime.Parse("2022-06-19")).TotalDays > 14)
            {
                lbl_Tip.Text = "试用期已过，请购买正版软件";
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
    }
}
