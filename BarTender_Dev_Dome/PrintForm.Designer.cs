namespace BarTender_Dev_Dome
{
    partial class PrintForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintForm));
            this.config_gBox = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.num_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.id_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.age_textBox = new System.Windows.Forms.TextBox();
            this.printer_comboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openFilebtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.fileNametBox = new System.Windows.Forms.TextBox();
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.print_btn = new System.Windows.Forms.Button();
            this.preview_btn = new System.Windows.Forms.Button();
            this.config_gBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // config_gBox
            // 
            this.config_gBox.Controls.Add(this.label5);
            this.config_gBox.Controls.Add(this.num_textBox);
            this.config_gBox.Controls.Add(this.label4);
            this.config_gBox.Controls.Add(this.id_textBox);
            this.config_gBox.Controls.Add(this.label3);
            this.config_gBox.Controls.Add(this.age_textBox);
            this.config_gBox.Controls.Add(this.printer_comboBox);
            this.config_gBox.Controls.Add(this.label1);
            this.config_gBox.Controls.Add(this.openFilebtn);
            this.config_gBox.Controls.Add(this.label2);
            this.config_gBox.Controls.Add(this.fileNametBox);
            this.config_gBox.Controls.Add(this.name_textBox);
            this.config_gBox.Location = new System.Drawing.Point(17, 14);
            this.config_gBox.Name = "config_gBox";
            this.config_gBox.Size = new System.Drawing.Size(331, 470);
            this.config_gBox.TabIndex = 125;
            this.config_gBox.TabStop = false;
            this.config_gBox.Text = "参数配置";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 16F);
            this.label5.Location = new System.Drawing.Point(14, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 22);
            this.label5.TabIndex = 134;
            this.label5.Text = "序号:";
            // 
            // num_textBox
            // 
            this.num_textBox.Font = new System.Drawing.Font("宋体", 16F);
            this.num_textBox.Location = new System.Drawing.Point(85, 311);
            this.num_textBox.Name = "num_textBox";
            this.num_textBox.Size = new System.Drawing.Size(229, 32);
            this.num_textBox.TabIndex = 133;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 16F);
            this.label4.Location = new System.Drawing.Point(15, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 22);
            this.label4.TabIndex = 132;
            this.label4.Text = "ID:";
            // 
            // id_textBox
            // 
            this.id_textBox.Font = new System.Drawing.Font("宋体", 16F);
            this.id_textBox.Location = new System.Drawing.Point(85, 257);
            this.id_textBox.Name = "id_textBox";
            this.id_textBox.Size = new System.Drawing.Size(230, 32);
            this.id_textBox.TabIndex = 131;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 16F);
            this.label3.Location = new System.Drawing.Point(14, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 22);
            this.label3.TabIndex = 130;
            this.label3.Text = "年龄:";
            // 
            // age_textBox
            // 
            this.age_textBox.Font = new System.Drawing.Font("宋体", 16F);
            this.age_textBox.Location = new System.Drawing.Point(85, 197);
            this.age_textBox.Name = "age_textBox";
            this.age_textBox.Size = new System.Drawing.Size(229, 32);
            this.age_textBox.TabIndex = 129;
            // 
            // printer_comboBox
            // 
            this.printer_comboBox.Font = new System.Drawing.Font("宋体", 16F);
            this.printer_comboBox.FormattingEnabled = true;
            this.printer_comboBox.Location = new System.Drawing.Point(12, 411);
            this.printer_comboBox.Name = "printer_comboBox";
            this.printer_comboBox.Size = new System.Drawing.Size(302, 29);
            this.printer_comboBox.TabIndex = 127;
            this.printer_comboBox.Text = "请选择打印机";
            this.printer_comboBox.SelectedIndexChanged += new System.EventHandler(this.printer_comboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 32;
            this.label1.Text = "选择模板文件：";
            // 
            // openFilebtn
            // 
            this.openFilebtn.Font = new System.Drawing.Font("黑体", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.openFilebtn.Location = new System.Drawing.Point(282, 53);
            this.openFilebtn.Name = "openFilebtn";
            this.openFilebtn.Size = new System.Drawing.Size(32, 21);
            this.openFilebtn.TabIndex = 1;
            this.openFilebtn.Text = "...";
            this.openFilebtn.UseVisualStyleBackColor = true;
            this.openFilebtn.Click += new System.EventHandler(this.openFilebtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 16F);
            this.label2.Location = new System.Drawing.Point(14, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 22);
            this.label2.TabIndex = 128;
            this.label2.Text = "姓名:";
            // 
            // fileNametBox
            // 
            this.fileNametBox.Location = new System.Drawing.Point(12, 53);
            this.fileNametBox.Name = "fileNametBox";
            this.fileNametBox.Size = new System.Drawing.Size(264, 21);
            this.fileNametBox.TabIndex = 0;
            // 
            // name_textBox
            // 
            this.name_textBox.Font = new System.Drawing.Font("宋体", 16F);
            this.name_textBox.Location = new System.Drawing.Point(85, 136);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(229, 32);
            this.name_textBox.TabIndex = 127;
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox.Location = new System.Drawing.Point(368, 46);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(420, 420);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox.TabIndex = 126;
            this.pictureBox.TabStop = false;
            // 
            // print_btn
            // 
            this.print_btn.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.print_btn.Location = new System.Drawing.Point(431, 500);
            this.print_btn.Name = "print_btn";
            this.print_btn.Size = new System.Drawing.Size(351, 55);
            this.print_btn.TabIndex = 131;
            this.print_btn.Text = "打印";
            this.print_btn.UseVisualStyleBackColor = true;
            this.print_btn.Click += new System.EventHandler(this.print_btn_Click);
            // 
            // preview_btn
            // 
            this.preview_btn.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.preview_btn.Location = new System.Drawing.Point(47, 500);
            this.preview_btn.Name = "preview_btn";
            this.preview_btn.Size = new System.Drawing.Size(351, 55);
            this.preview_btn.TabIndex = 131;
            this.preview_btn.Text = "预览";
            this.preview_btn.UseVisualStyleBackColor = true;
            this.preview_btn.Click += new System.EventHandler(this.preview_btn_Click);
            // 
            // PrintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 590);
            this.Controls.Add(this.preview_btn);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.print_btn);
            this.Controls.Add(this.config_gBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PrintForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BarTender_Dev_Demo";
            this.Load += new System.EventHandler(this.PrintForm_Load);
            this.config_gBox.ResumeLayout(false);
            this.config_gBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox config_gBox;
        private System.Windows.Forms.Button print_btn;
        private System.Windows.Forms.ComboBox printer_comboBox;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button openFilebtn;
        private System.Windows.Forms.TextBox fileNametBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox name_textBox;
        private System.Windows.Forms.Button preview_btn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox num_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox id_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox age_textBox;
    }
}