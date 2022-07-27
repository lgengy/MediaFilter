using System;
using System.Windows.Forms;

namespace MediaFilter.SupplementWindow
{
    public partial class FrmInputDirName : Form
    {
        public string initialDirName = "";

        public delegate void SaveDirName_Delegate(string dirName);
        public event SaveDirName_Delegate SaveDirName_Event;

        public FrmInputDirName()
        {
            InitializeComponent();
        }

        private void FrmInputDirName_Load(object sender, EventArgs e)
        {
            txt_SaveDirName.Text = initialDirName;
        }

        private void Btn_DirNameSave_Click(object sender, EventArgs e)
        {
            SaveDirName_Event(txt_SaveDirName.Text.Trim());
        }

        protected override void WndProc(ref Message msg)
        {
            const int wm_syscommand = 0x0112;
            const int sc_close = 0xf060;
            // 点击winform右上关闭按钮 
            if (msg.Msg == wm_syscommand && ((int)msg.WParam == sc_close))
            {
                SaveDirName_Event("");
                return;
            }
            base.WndProc(ref msg);
        }
    }
}
