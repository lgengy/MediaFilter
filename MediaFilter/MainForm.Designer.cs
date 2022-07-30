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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdb_ImportDirectory = new System.Windows.Forms.RadioButton();
            this.rdb_ImportFile = new System.Windows.Forms.RadioButton();
            this.cbx_SoccerType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_ImportTemplate = new System.Windows.Forms.Button();
            this.btn_ImportMedia = new System.Windows.Forms.Button();
            this.btn_DeleteMedia = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nud_PluginCount = new System.Windows.Forms.NumericUpDown();
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
            this.lb_Template = new System.Windows.Forms.ListBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_DeleteTemplate = new System.Windows.Forms.Button();
            this.btn_SaveTemplate = new System.Windows.Forms.Button();
            this.btn_TemplateClear = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lb_MediaFile = new System.Windows.Forms.ListBox();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_MediaClear = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_PluginCount)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.pnl_Templates.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.rdb_ImportDirectory);
            this.groupBox1.Controls.Add(this.rdb_ImportFile);
            this.groupBox1.Controls.Add(this.cbx_SoccerType);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 83);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "导入区";
            this.groupBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.SetGroupBoxBorder);
            // 
            // rdb_ImportDirectory
            // 
            this.rdb_ImportDirectory.Checked = true;
            this.rdb_ImportDirectory.Location = new System.Drawing.Point(112, 54);
            this.rdb_ImportDirectory.Name = "rdb_ImportDirectory";
            this.rdb_ImportDirectory.Size = new System.Drawing.Size(100, 20);
            this.rdb_ImportDirectory.TabIndex = 46;
            this.rdb_ImportDirectory.TabStop = true;
            this.rdb_ImportDirectory.Text = "导入目录";
            this.rdb_ImportDirectory.UseVisualStyleBackColor = true;
            // 
            // rdb_ImportFile
            // 
            this.rdb_ImportFile.Location = new System.Drawing.Point(6, 54);
            this.rdb_ImportFile.Name = "rdb_ImportFile";
            this.rdb_ImportFile.Size = new System.Drawing.Size(100, 20);
            this.rdb_ImportFile.TabIndex = 45;
            this.rdb_ImportFile.Text = "导入文件";
            this.rdb_ImportFile.UseVisualStyleBackColor = true;
            this.rdb_ImportFile.CheckedChanged += new System.EventHandler(this.Rdb_ImportFile_CheckedChanged);
            // 
            // cbx_SoccerType
            // 
            this.cbx_SoccerType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_SoccerType.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbx_SoccerType.FormattingEnabled = true;
            this.cbx_SoccerType.Items.AddRange(new object[] {
            "排三"});
            this.cbx_SoccerType.Location = new System.Drawing.Point(98, 19);
            this.cbx_SoccerType.Name = "cbx_SoccerType";
            this.cbx_SoccerType.Size = new System.Drawing.Size(95, 24);
            this.cbx_SoccerType.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(3, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 23);
            this.label3.TabIndex = 40;
            this.label3.Text = "过滤类型：";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_ImportTemplate
            // 
            this.btn_ImportTemplate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_ImportTemplate.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_ImportTemplate.Location = new System.Drawing.Point(243, 4);
            this.btn_ImportTemplate.Name = "btn_ImportTemplate";
            this.btn_ImportTemplate.Size = new System.Drawing.Size(48, 27);
            this.btn_ImportTemplate.TabIndex = 50;
            this.btn_ImportTemplate.Text = "导入";
            this.btn_ImportTemplate.UseVisualStyleBackColor = true;
            this.btn_ImportTemplate.Click += new System.EventHandler(this.Btn_ImportTemplate_Click);
            // 
            // btn_ImportMedia
            // 
            this.btn_ImportMedia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_ImportMedia.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_ImportMedia.Location = new System.Drawing.Point(298, 4);
            this.btn_ImportMedia.Name = "btn_ImportMedia";
            this.btn_ImportMedia.Size = new System.Drawing.Size(49, 27);
            this.btn_ImportMedia.TabIndex = 5;
            this.btn_ImportMedia.Text = "导入";
            this.btn_ImportMedia.UseVisualStyleBackColor = true;
            this.btn_ImportMedia.Click += new System.EventHandler(this.Btn_ImportMedia_Click);
            // 
            // btn_DeleteMedia
            // 
            this.btn_DeleteMedia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_DeleteMedia.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_DeleteMedia.Location = new System.Drawing.Point(410, 4);
            this.btn_DeleteMedia.Name = "btn_DeleteMedia";
            this.btn_DeleteMedia.Size = new System.Drawing.Size(50, 27);
            this.btn_DeleteMedia.TabIndex = 47;
            this.btn_DeleteMedia.Text = "删除";
            this.btn_DeleteMedia.UseVisualStyleBackColor = true;
            this.btn_DeleteMedia.Click += new System.EventHandler(this.DeleteTip);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nud_PluginCount);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(276, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(192, 83);
            this.groupBox2.TabIndex = 46;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "设置区";
            this.groupBox2.Paint += new System.Windows.Forms.PaintEventHandler(this.SetGroupBoxBorder);
            // 
            // nud_PluginCount
            // 
            this.nud_PluginCount.Location = new System.Drawing.Point(93, 22);
            this.nud_PluginCount.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nud_PluginCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_PluginCount.Name = "nud_PluginCount";
            this.nud_PluginCount.Size = new System.Drawing.Size(49, 26);
            this.nud_PluginCount.TabIndex = 14;
            this.nud_PluginCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_PluginCount.ValueChanged += new System.EventHandler(this.Nud_PluginCount_ValueChanged);
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
            this.groupBox3.Location = new System.Drawing.Point(472, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(465, 83);
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
            this.cbx_ExportMode.Location = new System.Drawing.Point(282, 52);
            this.cbx_ExportMode.Name = "cbx_ExportMode";
            this.cbx_ExportMode.Size = new System.Drawing.Size(67, 24);
            this.cbx_ExportMode.TabIndex = 45;
            this.cbx_ExportMode.SelectedValueChanged += new System.EventHandler(this.Cbx_ExportMode_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(236, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 23);
            this.label2.TabIndex = 44;
            this.label2.Text = "模式：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rdBtn_ExportFile
            // 
            this.rdBtn_ExportFile.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdBtn_ExportFile.Location = new System.Drawing.Point(132, 55);
            this.rdBtn_ExportFile.Name = "rdBtn_ExportFile";
            this.rdBtn_ExportFile.Size = new System.Drawing.Size(96, 18);
            this.rdBtn_ExportFile.TabIndex = 6;
            this.rdBtn_ExportFile.Text = "导出文件";
            this.rdBtn_ExportFile.UseVisualStyleBackColor = true;
            // 
            // cbx_IssueStart
            // 
            this.cbx_IssueStart.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbx_IssueStart.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_IssueStart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_IssueStart.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbx_IssueStart.FormattingEnabled = true;
            this.cbx_IssueStart.Location = new System.Drawing.Point(58, 21);
            this.cbx_IssueStart.Name = "cbx_IssueStart";
            this.cbx_IssueStart.Size = new System.Drawing.Size(121, 24);
            this.cbx_IssueStart.TabIndex = 40;
            // 
            // btn_Export
            // 
            this.btn_Export.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Export.Location = new System.Drawing.Point(376, 20);
            this.btn_Export.Name = "btn_Export";
            this.btn_Export.Size = new System.Drawing.Size(82, 54);
            this.btn_Export.TabIndex = 7;
            this.btn_Export.Text = "导出";
            this.btn_Export.UseVisualStyleBackColor = true;
            this.btn_Export.Click += new System.EventHandler(this.Btn_Export_Click);
            // 
            // rdBtn_ExportDirectory
            // 
            this.rdBtn_ExportDirectory.Checked = true;
            this.rdBtn_ExportDirectory.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdBtn_ExportDirectory.Location = new System.Drawing.Point(11, 55);
            this.rdBtn_ExportDirectory.Name = "rdBtn_ExportDirectory";
            this.rdBtn_ExportDirectory.Size = new System.Drawing.Size(96, 18);
            this.rdBtn_ExportDirectory.TabIndex = 5;
            this.rdBtn_ExportDirectory.TabStop = true;
            this.rdBtn_ExportDirectory.Text = "导出目录";
            this.rdBtn_ExportDirectory.UseVisualStyleBackColor = true;
            this.rdBtn_ExportDirectory.CheckedChanged += new System.EventHandler(this.RdBtn_ExportDirectory_CheckedChanged);
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
            this.label4.Location = new System.Drawing.Point(191, 21);
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
            this.cbx_IssueEnd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_IssueEnd.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbx_IssueEnd.FormattingEnabled = true;
            this.cbx_IssueEnd.Location = new System.Drawing.Point(235, 21);
            this.cbx_IssueEnd.Name = "cbx_IssueEnd";
            this.cbx_IssueEnd.Size = new System.Drawing.Size(114, 24);
            this.cbx_IssueEnd.TabIndex = 42;
            // 
            // pnl_Templates
            // 
            this.pnl_Templates.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel1.SetColumnSpan(this.pnl_Templates, 5);
            this.pnl_Templates.Controls.Add(this.lb_Template);
            this.pnl_Templates.Controls.Add(this.splitter1);
            this.pnl_Templates.Location = new System.Drawing.Point(4, 38);
            this.pnl_Templates.Name = "pnl_Templates";
            this.pnl_Templates.Size = new System.Drawing.Size(456, 295);
            this.pnl_Templates.TabIndex = 48;
            // 
            // lb_Template
            // 
            this.lb_Template.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lb_Template.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Template.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Template.FormattingEnabled = true;
            this.lb_Template.HorizontalScrollbar = true;
            this.lb_Template.ItemHeight = 16;
            this.lb_Template.Items.AddRange(new object[] {
            "nihao",
            "wohao",
            "dajiahao",
            "zhende",
            "henhao",
            "bushima "});
            this.lb_Template.Location = new System.Drawing.Point(3, 0);
            this.lb_Template.Name = "lb_Template";
            this.lb_Template.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lb_Template.Size = new System.Drawing.Size(451, 293);
            this.lb_Template.TabIndex = 3;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 293);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel1.Controls.Add(this.pnl_Templates, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_ImportTemplate, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_DeleteTemplate, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_SaveTemplate, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_TemplateClear, 2, 0);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(472, 89);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(464, 337);
            this.tableLayoutPanel1.TabIndex = 50;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(232, 27);
            this.panel1.TabIndex = 49;
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(232, 27);
            this.label7.TabIndex = 0;
            this.label7.Text = "模板";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_DeleteTemplate
            // 
            this.btn_DeleteTemplate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_DeleteTemplate.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_DeleteTemplate.Location = new System.Drawing.Point(353, 4);
            this.btn_DeleteTemplate.Name = "btn_DeleteTemplate";
            this.btn_DeleteTemplate.Size = new System.Drawing.Size(48, 27);
            this.btn_DeleteTemplate.TabIndex = 50;
            this.btn_DeleteTemplate.Text = "删除";
            this.btn_DeleteTemplate.UseVisualStyleBackColor = true;
            this.btn_DeleteTemplate.Click += new System.EventHandler(this.DeleteTip);
            // 
            // btn_SaveTemplate
            // 
            this.btn_SaveTemplate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_SaveTemplate.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_SaveTemplate.Location = new System.Drawing.Point(408, 4);
            this.btn_SaveTemplate.Name = "btn_SaveTemplate";
            this.btn_SaveTemplate.Size = new System.Drawing.Size(52, 27);
            this.btn_SaveTemplate.TabIndex = 51;
            this.btn_SaveTemplate.Text = "保存";
            this.btn_SaveTemplate.UseVisualStyleBackColor = true;
            this.btn_SaveTemplate.Click += new System.EventHandler(this.Btn_SaveTemplate_Click);
            // 
            // btn_TemplateClear
            // 
            this.btn_TemplateClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_TemplateClear.Location = new System.Drawing.Point(298, 4);
            this.btn_TemplateClear.Name = "btn_TemplateClear";
            this.btn_TemplateClear.Size = new System.Drawing.Size(48, 27);
            this.btn_TemplateClear.TabIndex = 52;
            this.btn_TemplateClear.Text = "清空";
            this.btn_TemplateClear.UseVisualStyleBackColor = true;
            this.btn_TemplateClear.Click += new System.EventHandler(this.Btn_DataClear_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel2.Controls.Add(this.btn_DeleteMedia, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_MediaClear, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_ImportMedia, 1, 0);
            this.tableLayoutPanel2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 89);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(464, 337);
            this.tableLayoutPanel2.TabIndex = 51;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel2.SetColumnSpan(this.panel2, 4);
            this.panel2.Controls.Add(this.lb_MediaFile);
            this.panel2.Controls.Add(this.splitter2);
            this.panel2.Location = new System.Drawing.Point(4, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(456, 295);
            this.panel2.TabIndex = 48;
            // 
            // lb_MediaFile
            // 
            this.lb_MediaFile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lb_MediaFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_MediaFile.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_MediaFile.FormattingEnabled = true;
            this.lb_MediaFile.HorizontalScrollbar = true;
            this.lb_MediaFile.ItemHeight = 16;
            this.lb_MediaFile.Items.AddRange(new object[] {
            "nihao",
            "wohao",
            "dajiahao",
            "zhende",
            "henhao",
            "bushima "});
            this.lb_MediaFile.Location = new System.Drawing.Point(3, 0);
            this.lb_MediaFile.Name = "lb_MediaFile";
            this.lb_MediaFile.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lb_MediaFile.Size = new System.Drawing.Size(451, 293);
            this.lb_MediaFile.TabIndex = 3;
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(0, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(3, 293);
            this.splitter2.TabIndex = 2;
            this.splitter2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label8);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(287, 27);
            this.panel3.TabIndex = 49;
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(287, 27);
            this.label8.TabIndex = 0;
            this.label8.Text = "媒体";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_MediaClear
            // 
            this.btn_MediaClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_MediaClear.Location = new System.Drawing.Point(354, 4);
            this.btn_MediaClear.Name = "btn_MediaClear";
            this.btn_MediaClear.Size = new System.Drawing.Size(49, 27);
            this.btn_MediaClear.TabIndex = 50;
            this.btn_MediaClear.Text = "清空";
            this.btn_MediaClear.UseVisualStyleBackColor = true;
            this.btn_MediaClear.Click += new System.EventHandler(this.Btn_DataClear_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 430);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "媒体过滤工具";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nud_PluginCount)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.pnl_Templates.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbx_SoccerType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_ImportMedia;
        private System.Windows.Forms.GroupBox groupBox2;
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
        private System.Windows.Forms.RadioButton rdb_ImportDirectory;
        private System.Windows.Forms.RadioButton rdb_ImportFile;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button btn_ImportTemplate;
        private System.Windows.Forms.ListBox lb_Template;
        private System.Windows.Forms.Button btn_DeleteMedia;
        private System.Windows.Forms.Button btn_DeleteTemplate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox lb_MediaFile;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_SaveTemplate;
        private System.Windows.Forms.Button btn_TemplateClear;
        private System.Windows.Forms.Button btn_MediaClear;
        private System.Windows.Forms.NumericUpDown nud_PluginCount;
    }
}

