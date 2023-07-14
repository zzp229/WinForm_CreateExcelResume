namespace WinForm_CreateExcelResume
{
    partial class CreateExcelResume
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_selectImage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_Gender = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Class = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Tel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Add = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Other = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_MakeIt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(23, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_selectImage
            // 
            this.btn_selectImage.Location = new System.Drawing.Point(23, 95);
            this.btn_selectImage.Name = "btn_selectImage";
            this.btn_selectImage.Size = new System.Drawing.Size(67, 23);
            this.btn_selectImage.TabIndex = 1;
            this.btn_selectImage.Text = "选择图片";
            this.btn_selectImage.UseVisualStyleBackColor = true;
            this.btn_selectImage.Click += new System.EventHandler(this.btn_selectImage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "学号：";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(158, 10);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 21);
            this.txtId.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(276, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "姓名：";
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(314, 10);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(100, 21);
            this.txt_Name.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(437, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "性别：";
            // 
            // cmb_Gender
            // 
            this.cmb_Gender.FormattingEnabled = true;
            this.cmb_Gender.Items.AddRange(new object[] {
            "无",
            "男",
            "女"});
            this.cmb_Gender.Location = new System.Drawing.Point(472, 10);
            this.cmb_Gender.Name = "cmb_Gender";
            this.cmb_Gender.Size = new System.Drawing.Size(49, 20);
            this.cmb_Gender.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(120, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "班级：";
            // 
            // txt_Class
            // 
            this.txt_Class.Location = new System.Drawing.Point(158, 55);
            this.txt_Class.Name = "txt_Class";
            this.txt_Class.Size = new System.Drawing.Size(100, 21);
            this.txt_Class.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(276, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "电话：";
            // 
            // txt_Tel
            // 
            this.txt_Tel.Location = new System.Drawing.Point(314, 55);
            this.txt_Tel.Name = "txt_Tel";
            this.txt_Tel.Size = new System.Drawing.Size(100, 21);
            this.txt_Tel.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(120, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 2;
            this.label6.Text = "地址：";
            // 
            // txt_Add
            // 
            this.txt_Add.Location = new System.Drawing.Point(158, 96);
            this.txt_Add.Name = "txt_Add";
            this.txt_Add.Size = new System.Drawing.Size(373, 21);
            this.txt_Add.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 5;
            this.label7.Text = "备注信息：";
            // 
            // txt_Other
            // 
            this.txt_Other.Location = new System.Drawing.Point(23, 177);
            this.txt_Other.Multiline = true;
            this.txt_Other.Name = "txt_Other";
            this.txt_Other.Size = new System.Drawing.Size(508, 99);
            this.txt_Other.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Location = new System.Drawing.Point(23, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(508, 1);
            this.label8.TabIndex = 7;
            // 
            // btn_MakeIt
            // 
            this.btn_MakeIt.Location = new System.Drawing.Point(216, 296);
            this.btn_MakeIt.Name = "btn_MakeIt";
            this.btn_MakeIt.Size = new System.Drawing.Size(75, 23);
            this.btn_MakeIt.TabIndex = 8;
            this.btn_MakeIt.Text = "生成";
            this.btn_MakeIt.UseVisualStyleBackColor = true;
            this.btn_MakeIt.Click += new System.EventHandler(this.btn_MakeIt_Click);
            // 
            // CreateExcelResume
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(561, 331);
            this.Controls.Add(this.btn_MakeIt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_Other);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmb_Gender);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Tel);
            this.Controls.Add(this.txt_Add);
            this.Controls.Add(this.txt_Class);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_selectImage);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CreateExcelResume";
            this.Text = "简历生成器";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_selectImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_Gender;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Class;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Tel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Add;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Other;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_MakeIt;
    }
}

