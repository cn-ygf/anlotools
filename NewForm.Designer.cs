namespace AnloTools
{
    partial class NewForm
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
            this.groupBox_Main = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Code = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.button_Ok = new System.Windows.Forms.Button();
            this.groupBox_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_Main
            // 
            this.groupBox_Main.Controls.Add(this.textBox_Name);
            this.groupBox_Main.Controls.Add(this.label2);
            this.groupBox_Main.Controls.Add(this.textBox_Code);
            this.groupBox_Main.Controls.Add(this.label1);
            this.groupBox_Main.Location = new System.Drawing.Point(13, 12);
            this.groupBox_Main.Name = "groupBox_Main";
            this.groupBox_Main.Size = new System.Drawing.Size(360, 90);
            this.groupBox_Main.TabIndex = 0;
            this.groupBox_Main.TabStop = false;
            this.groupBox_Main.Text = "选项";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "案件编号：";
            // 
            // textBox_Code
            // 
            this.textBox_Code.Location = new System.Drawing.Point(78, 24);
            this.textBox_Code.Name = "textBox_Code";
            this.textBox_Code.Size = new System.Drawing.Size(276, 21);
            this.textBox_Code.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "案件名称：";
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(78, 53);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(276, 21);
            this.textBox_Name.TabIndex = 3;
            // 
            // button_Ok
            // 
            this.button_Ok.Location = new System.Drawing.Point(292, 108);
            this.button_Ok.Name = "button_Ok";
            this.button_Ok.Size = new System.Drawing.Size(75, 23);
            this.button_Ok.TabIndex = 1;
            this.button_Ok.Text = "确定(&O)";
            this.button_Ok.UseVisualStyleBackColor = true;
            this.button_Ok.Click += new System.EventHandler(this.Button_Ok_Click);
            // 
            // NewFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 144);
            this.Controls.Add(this.button_Ok);
            this.Controls.Add(this.groupBox_Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "NewFrom";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "新建项目";
            this.Load += new System.EventHandler(this.NewFrom_Load);
            this.groupBox_Main.ResumeLayout(false);
            this.groupBox_Main.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Main;
        private System.Windows.Forms.TextBox textBox_Code;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Ok;
    }
}