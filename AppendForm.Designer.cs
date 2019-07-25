namespace AnloTools
{
    partial class AppendForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_Info = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_Sael = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_Type = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Code = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_SaveAndNext = new System.Windows.Forms.Button();
            this.button_SaveAndExit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button_Clear = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_Clear);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox_Info);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBox_Sael);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBox_Type);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox_Code);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(422, 303);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "选项";
            // 
            // textBox_Info
            // 
            this.textBox_Info.Location = new System.Drawing.Point(66, 108);
            this.textBox_Info.Multiline = true;
            this.textBox_Info.Name = "textBox_Info";
            this.textBox_Info.Size = new System.Drawing.Size(350, 130);
            this.textBox_Info.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "描述信息：";
            // 
            // comboBox_Sael
            // 
            this.comboBox_Sael.FormattingEnabled = true;
            this.comboBox_Sael.Items.AddRange(new object[] {
            "封存",
            "已封存",
            "其他"});
            this.comboBox_Sael.Location = new System.Drawing.Point(66, 78);
            this.comboBox_Sael.Name = "comboBox_Sael";
            this.comboBox_Sael.Size = new System.Drawing.Size(350, 20);
            this.comboBox_Sael.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "封存信息：";
            // 
            // comboBox_Type
            // 
            this.comboBox_Type.FormattingEnabled = true;
            this.comboBox_Type.Items.AddRange(new object[] {
            "手机",
            "台式电脑",
            "笔记本电脑",
            "硬盘",
            "移动硬盘",
            "平板电脑",
            "U盘",
            "SD卡"});
            this.comboBox_Type.Location = new System.Drawing.Point(66, 48);
            this.comboBox_Type.Name = "comboBox_Type";
            this.comboBox_Type.Size = new System.Drawing.Size(350, 20);
            this.comboBox_Type.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "检材类型：";
            // 
            // textBox_Code
            // 
            this.textBox_Code.Location = new System.Drawing.Point(66, 16);
            this.textBox_Code.Name = "textBox_Code";
            this.textBox_Code.ReadOnly = true;
            this.textBox_Code.Size = new System.Drawing.Size(350, 21);
            this.textBox_Code.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "检材编号：";
            // 
            // button_SaveAndNext
            // 
            this.button_SaveAndNext.Location = new System.Drawing.Point(342, 321);
            this.button_SaveAndNext.Name = "button_SaveAndNext";
            this.button_SaveAndNext.Size = new System.Drawing.Size(92, 23);
            this.button_SaveAndNext.TabIndex = 1;
            this.button_SaveAndNext.Text = "保存&&下一个";
            this.button_SaveAndNext.UseVisualStyleBackColor = true;
            this.button_SaveAndNext.Click += new System.EventHandler(this.Button_SaveAndNext_Click);
            // 
            // button_SaveAndExit
            // 
            this.button_SaveAndExit.Location = new System.Drawing.Point(261, 321);
            this.button_SaveAndExit.Name = "button_SaveAndExit";
            this.button_SaveAndExit.Size = new System.Drawing.Size(75, 23);
            this.button_SaveAndExit.TabIndex = 2;
            this.button_SaveAndExit.Text = "保存&&退出";
            this.button_SaveAndExit.UseVisualStyleBackColor = true;
            this.button_SaveAndExit.Click += new System.EventHandler(this.Button_SaveAndExit_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(66, 242);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "S/N:";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(147, 242);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "序列号：";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(228, 242);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "屏幕碎裂";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(309, 242);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 11;
            this.button4.Text = "无法开机";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(66, 271);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 12;
            this.button5.Text = "外观完好";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(147, 271);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 13;
            this.button6.Text = "编码：";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button_Clear
            // 
            this.button_Clear.Location = new System.Drawing.Point(228, 271);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(75, 23);
            this.button_Clear.TabIndex = 14;
            this.button_Clear.Text = "清空";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.Button_Clear_Click);
            // 
            // AppendForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 351);
            this.Controls.Add(this.button_SaveAndExit);
            this.Controls.Add(this.button_SaveAndNext);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AppendForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加检材";
            this.Load += new System.EventHandler(this.AppendForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_SaveAndNext;
        private System.Windows.Forms.Button button_SaveAndExit;
        private System.Windows.Forms.TextBox textBox_Code;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_Type;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_Sael;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Info;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button_Clear;
    }
}