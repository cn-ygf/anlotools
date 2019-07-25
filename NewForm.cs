using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AnloTools
{
    public partial class NewForm : Form
    {
        public NewForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 案件编号
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// 案件名称
        /// </summary>
        public string Name { get; set; }

        private void NewFrom_Load(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            string code = string.Format("CNNS-{0}第{1}号", time.ToString("yyyy"),"xxx");
            this.textBox_Code.Text = code;
            this.textBox_Code.Select(code.IndexOf("xxx"), 3);
        }

        private void Button_Ok_Click(object sender, EventArgs e)
        {
            if(this.textBox_Code.TextLength < 1)
            {
                MessageBox.Show("请输入案件编号！");
                return;
            }
            this.Code = this.textBox_Code.Text.Trim();
            this.Name = this.textBox_Name.Text.Trim();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
