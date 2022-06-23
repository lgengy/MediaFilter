namespace MediaFilter
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbx_SoccerType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_ImportTemplate = new System.Windows.Forms.Button();
            this.btn_ImportFile = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_CountBet = new System.Windows.Forms.TextBox();
            this.txt_CountPlugin = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbx_ExportMode = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rdBtn_ExportFile = new System.Windows.Forms.RadioButton();
            this.cbx_IssueStart = new System.Windows.Forms.ComboBox();
            this.btn_Export = new System.Windows.Forms.Button();
            this.rdBtn_ExportDirectory = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbx_IssueEnd = new System.Windows.Forms.ComboBox();
            this.pnl_Templates = new System.Windows.Forms.Panel();
            this.lb_Templates = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_Tip = new System.Windows.Forms.Label();
            this.flp_Files = new System.Windows.Forms.FlowLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.pnl_Templates.SuspendLayout();
            this.panel2.SuspendLayout();
            this.flp_Files.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.cbx_SoccerType);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btn_ImportTemplate);
            this.groupBox1.Controls.Add(this.btn_ImportFile);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(187, 83);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "导入区";
            this.groupBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.SetGroupBoxBorder);
            // 
            // cbx_SoccerType
            // 
            this.cbx_SoccerType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_SoccerType.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbx_SoccerType.FormattingEnabled = true;
            this.cbx_SoccerType.Items.AddRange(new object[] {
            "排三"});
            this.cbx_SoccerType.Location = new System.Drawing.Point(86, 19);
            this.cbx_SoccerType.Name = "cbx_SoccerType";
            this.cbx_SoccerType.Size = new System.Drawing.Size(95, 24);
            this.cbx_SoccerType.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(6, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 23);
            this.label3.TabIndex = 40;
            this.label3.Text = "过滤类型：";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_ImportTemplate
            // 
            this.btn_ImportTemplate.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_ImportTemplate.Location = new System.Drawing.Point(99, 47);
            this.btn_ImportTemplate.Name = "btn_ImportTemplate";
            this.btn_ImportTemplate.Size = new System.Drawing.Size(82, 27);
            this.btn_ImportTemplate.TabIndex = 12;
            this.btn_ImportTemplate.Text = "模板导入";
            this.btn_ImportTemplate.UseVisualStyleBackColor = true;
            // 
            // btn_ImportFile
            // 
            this.btn_ImportFile.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_ImportFile.Location = new System.Drawing.Point(9, 48);
            this.btn_ImportFile.Name = "btn_ImportFile";
            this.btn_ImportFile.Size = new System.Drawing.Size(82, 27);
            this.btn_ImportFile.TabIndex = 5;
            this.btn_ImportFile.Text = "文件导入";
            this.btn_ImportFile.UseVisualStyleBackColor = true;
            this.btn_ImportFile.Click += new System.EventHandler(this.Btn_ImportFile_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_CountBet);
            this.groupBox2.Controls.Add(this.txt_CountPlugin);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(193, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(248, 83);
            this.groupBox2.TabIndex = 46;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "设置区";
            this.groupBox2.Paint += new System.Windows.Forms.PaintEventHandler(this.SetGroupBoxBorder);
            // 
            // txt_CountBet
            // 
            this.txt_CountBet.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_CountBet.Location = new System.Drawing.Point(186, 25);
            this.txt_CountBet.Name = "txt_CountBet";
            this.txt_CountBet.Size = new System.Drawing.Size(30, 20);
            this.txt_CountBet.TabIndex = 38;
            this.txt_CountBet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_CountBet.Leave += new System.EventHandler(this.Txt_CountBet_Leave);
            // 
            // txt_CountPlugin
            // 
            this.txt_CountPlugin.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_CountPlugin.Location = new System.Drawing.Point(94, 25);
            this.txt_CountPlugin.Name = "txt_CountPlugin";
            this.txt_CountPlugin.Size = new System.Drawing.Size(30, 20);
            this.txt_CountPlugin.TabIndex = 13;
            this.txt_CountPlugin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_CountPlugin.Leave += new System.EventHandler(this.Txt_CountPlugin_Leave);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(134, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "注数：";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(3, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "插件个数：";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbx_ExportMode);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.rdBtn_ExportFile);
            this.groupBox3.Controls.Add(this.cbx_IssueStart);
            this.groupBox3.Controls.Add(this.btn_Export);
            this.groupBox3.Controls.Add(this.rdBtn_ExportDirectory);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.cbx_IssueEnd);
            this.groupBox3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox3.Location = new System.Drawing.Point(445, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(492, 83);
            this.groupBox3.TabIndex = 47;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "导出区";
            this.groupBox3.Paint += new System.Windows.Forms.PaintEventHandler(this.SetGroupBoxBorder);
            // 
            // cbx_ExportMode
            // 
            this.cbx_ExportMode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbx_ExportMode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_ExportMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_ExportMode.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbx_ExportMode.FormattingEnabled = true;
            this.cbx_ExportMode.Items.AddRange(new object[] {
            "横向",
            "纵向"});
            this.cbx_ExportMode.Location = new System.Drawing.Point(244, 52);
            this.cbx_ExportMode.Name = "cbx_ExportMode";
            this.cbx_ExportMode.Size = new System.Drawing.Size(67, 24);
            this.cbx_ExportMode.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(198, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 23);
            this.label2.TabIndex = 44;
            this.label2.Text = "模式：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rdBtn_ExportFile
            // 
            this.rdBtn_ExportFile.AutoSize = true;
            this.rdBtn_ExportFile.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdBtn_ExportFile.Location = new System.Drawing.Point(110, 55);
            this.rdBtn_ExportFile.Name = "rdBtn_ExportFile";
            this.rdBtn_ExportFile.Size = new System.Drawing.Size(81, 18);
            this.rdBtn_ExportFile.TabIndex = 6;
            this.rdBtn_ExportFile.Text = "导出文件";
            this.rdBtn_ExportFile.UseVisualStyleBackColor = true;
            // 
            // cbx_IssueStart
            // 
            this.cbx_IssueStart.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbx_IssueStart.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_IssueStart.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbx_IssueStart.FormattingEnabled = true;
            this.cbx_IssueStart.Location = new System.Drawing.Point(56, 21);
            this.cbx_IssueStart.Name = "cbx_IssueStart";
            this.cbx_IssueStart.Size = new System.Drawing.Size(114, 24);
            this.cbx_IssueStart.TabIndex = 40;
            // 
            // btn_Export
            // 
            this.btn_Export.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Export.Location = new System.Drawing.Point(346, 22);
            this.btn_Export.Name = "btn_Export";
            this.btn_Export.Size = new System.Drawing.Size(82, 54);
            this.btn_Export.TabIndex = 7;
            this.btn_Export.Text = "导出";
            this.btn_Export.UseVisualStyleBackColor = true;
            // 
            // rdBtn_ExportDirectory
            // 
            this.rdBtn_ExportDirectory.AutoSize = true;
            this.rdBtn_ExportDirectory.Checked = true;
            this.rdBtn_ExportDirectory.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdBtn_ExportDirectory.Location = new System.Drawing.Point(11, 55);
            this.rdBtn_ExportDirectory.Name = "rdBtn_ExportDirectory";
            this.rdBtn_ExportDirectory.Size = new System.Drawing.Size(95, 18);
            this.rdBtn_ExportDirectory.TabIndex = 5;
            this.rdBtn_ExportDirectory.TabStop = true;
            this.rdBtn_ExportDirectory.Text = "导出文件夹";
            this.rdBtn_ExportDirectory.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(7, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 23);
            this.label1.TabIndex = 39;
            this.label1.Text = "期号：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(169, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 23);
            this.label4.TabIndex = 41;
            this.label4.Text = "至";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbx_IssueEnd
            // 
            this.cbx_IssueEnd.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbx_IssueEnd.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_IssueEnd.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbx_IssueEnd.FormattingEnabled = true;
            this.cbx_IssueEnd.Location = new System.Drawing.Point(197, 21);
            this.cbx_IssueEnd.Name = "cbx_IssueEnd";
            this.cbx_IssueEnd.Size = new System.Drawing.Size(114, 24);
            this.cbx_IssueEnd.TabIndex = 42;
            // 
            // pnl_Templates
            // 
            this.pnl_Templates.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Templates.Controls.Add(this.lb_Templates);
            this.pnl_Templates.Controls.Add(this.label7);
            this.pnl_Templates.Location = new System.Drawing.Point(2, 87);
            this.pnl_Templates.Name = "pnl_Templates";
            this.pnl_Templates.Size = new System.Drawing.Size(937, 88);
            this.pnl_Templates.TabIndex = 48;
            // 
            // lb_Templates
            // 
            this.lb_Templates.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Templates.FormattingEnabled = true;
            this.lb_Templates.ItemHeight = 16;
            this.lb_Templates.Items.AddRange(new object[] {
            "nihao",
            "wohao",
            "dajiahao",
            "zhende",
            "henhao",
            "bushima "});
            this.lb_Templates.Location = new System.Drawing.Point(32, 1);
            this.lb_Templates.Name = "lb_Templates";
            this.lb_Templates.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lb_Templates.Size = new System.Drawing.Size(902, 84);
            this.lb_Templates.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(6, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 48);
            this.label7.TabIndex = 0;
            this.label7.Text = "模  板";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbl_Tip);
            this.panel2.Controls.Add(this.flp_Files);
            this.panel2.Location = new System.Drawing.Point(2, 179);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(937, 247);
            this.panel2.TabIndex = 49;
            // 
            // lbl_Tip
            // 
            this.lbl_Tip.Font = new System.Drawing.Font("宋体", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Tip.ForeColor = System.Drawing.Color.Red;
            this.lbl_Tip.Location = new System.Drawing.Point(132, 11);
            this.lbl_Tip.Name = "lbl_Tip";
            this.lbl_Tip.Size = new System.Drawing.Size(629, 50);
            this.lbl_Tip.TabIndex = 1;
            this.lbl_Tip.Text = "欢迎使用";
            this.lbl_Tip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flp_Files
            // 
            this.flp_Files.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flp_Files.Controls.Add(this.label8);
            this.flp_Files.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flp_Files.Location = new System.Drawing.Point(0, 0);
            this.flp_Files.Name = "flp_Files";
            this.flp_Files.Size = new System.Drawing.Size(937, 247);
            this.flp_Files.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 121);
            this.label8.TabIndex = 0;
            this.label8.Text = "label8";
            this.label8.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 430);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnl_Templates);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "媒体过滤工具";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.pnl_Templates.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.flp_Files.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbx_SoccerType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_ImportTemplate;
        private System.Windows.Forms.Button btn_ImportFile;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_CountBet;
        private System.Windows.Forms.TextBox txt_CountPlugin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdBtn_ExportFile;
        private System.Windows.Forms.ComboBox cbx_IssueStart;
        private System.Windows.Forms.Button btn_Export;
        private System.Windows.Forms.RadioButton rdBtn_ExportDirectory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbx_IssueEnd;
        private System.Windows.Forms.ComboBox cbx_ExportMode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnl_Templates;
        private System.Windows.Forms.ListBox lb_Templates;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_Tip;
        private System.Windows.Forms.FlowLayoutPanel flp_Files;
        private System.Windows.Forms.Label label8;
    }
}

