
namespace MediaFilter.SupplementWindow
{
    partial class FrmInputDirName
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txt_SaveDirName = new System.Windows.Forms.TextBox();
            this.btn_DirNameSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "目录名称：";
            // 
            // txt_SaveDirName
            // 
            this.txt_SaveDirName.Location = new System.Drawing.Point(94, 22);
            this.txt_SaveDirName.Name = "txt_SaveDirName";
            this.txt_SaveDirName.Size = new System.Drawing.Size(222, 26);
            this.txt_SaveDirName.TabIndex = 1;
            // 
            // btn_DirNameSave
            // 
            this.btn_DirNameSave.Location = new System.Drawing.Point(331, 22);
            this.btn_DirNameSave.Name = "btn_DirNameSave";
            this.btn_DirNameSave.Size = new System.Drawing.Size(75, 26);
            this.btn_DirNameSave.TabIndex = 2;
            this.btn_DirNameSave.Text = "确定";
            this.btn_DirNameSave.UseVisualStyleBackColor = true;
            this.btn_DirNameSave.Click += new System.EventHandler(this.Btn_DirNameSave_Click);
            // 
            // FrmInputDirName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 72);
            this.Controls.Add(this.btn_DirNameSave);
            this.Controls.Add(this.txt_SaveDirName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmInputDirName";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmInputDirName_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_SaveDirName;
        private System.Windows.Forms.Button btn_DirNameSave;
    }
}