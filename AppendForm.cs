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
    public partial class AppendForm : Form
    {
        /// <summary>
        /// 主窗口对象
        /// </summary>
        private MainForm mainForm;
        private Sample e_sample = null;
        private int e_index = -1;
        public AppendForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.comboBox_Type.SelectedIndex = 0;
            this.comboBox_Sael.SelectedIndex = 0;
            this.button1.Click += Button_Append_Click;
            this.button2.Click += Button_Append_Click;
            this.button3.Click += Button_Append_Click;
            this.button4.Click += Button_Append_Click;
            this.button5.Click += Button_Append_Click;
            this.button6.Click += Button_Append_Click;
            Gender();
        }

        public AppendForm(MainForm mainForm,Sample sample,int index)
        {
            e_index = index;
            this.e_sample = sample;
            InitializeComponent();
            this.mainForm = mainForm;
            this.comboBox_Type.SelectedIndex = 0;
            this.comboBox_Sael.SelectedIndex = 0;
            this.button1.Click += Button_Append_Click;
            this.button2.Click += Button_Append_Click;
            this.button3.Click += Button_Append_Click;
            this.button4.Click += Button_Append_Click;
            this.button5.Click += Button_Append_Click;
            this.button6.Click += Button_Append_Click;

            this.Text = "修改检材";
            this.button_SaveAndNext.Visible = false;

            this.textBox_Code.Text = sample.Code;
            this.comboBox_Type.Text = sample.Type;
            this.comboBox_Sael.Text = sample.Seal;
            this.textBox_Info.Text = sample.Info;
            
        }

        private void AppendForm_Load(object sender, EventArgs e)
        {
            
        }

        private void Gender()
        {
            string code = this.mainForm.GetProjectCode();
            code = code.Replace("第", "-").Replace("号","");
            int count = this.mainForm.GetSampleCount();
            // 生成检材编号
            this.textBox_Code.Text = string.Format("JC-{0}-{1}",code, GenderId(count + 1));
        }

        /// <summary>
        /// 不足3位补0
        /// </summary>
        /// <returns></returns>
        private string GenderId(int count)
        {
            string strCount = count.ToString();
            int strLen = strCount.Length;
            if(strLen < 3)
            {
                for (int i = 0; i < 3 - strLen; i++)
                {
                    strCount = strCount.Insert(0, "0");
                }
            }
            return strCount;
        }

        private void Button_SaveAndExit_Click(object sender, EventArgs e)
        {
            if (!InputCheck())
            {
                MessageBox.Show("请检查输入内容！");
                return;
            }
            if (this.e_sample != null)
            {
                this.e_sample.Type = this.comboBox_Type.Text.Trim();
                this.e_sample.Seal = this.comboBox_Sael.Text.Trim();
                this.e_sample.Info = this.textBox_Info.Text.Trim();
                this.mainForm.Set(e_index, this.e_sample);
                this.Close();
                return;
            }
            Sample sample = new Sample();
            sample.Code = this.textBox_Code.Text.Trim();
            sample.Type = this.comboBox_Type.Text.Trim();
            sample.Seal = this.comboBox_Sael.Text.Trim();
            sample.Info = this.textBox_Info.Text.Trim();
            this.mainForm.Append(sample);
            this.Close();
        }

        private void Button_SaveAndNext_Click(object sender, EventArgs e)
        {
            if(!InputCheck())
            {
                MessageBox.Show("请检查输入内容！");
                return;
            }
            Sample sample = new Sample();
            sample.Code = this.textBox_Code.Text.Trim();
            sample.Type = this.comboBox_Type.Text.Trim();
            sample.Seal = this.comboBox_Sael.Text.Trim();
            sample.Info = this.textBox_Info.Text.Trim();
            this.mainForm.Append(sample);
            Gender();
        }

        /// <summary>
        /// 输入检查
        /// </summary>
        /// <returns></returns>
        private bool InputCheck()
        {
            if (this.textBox_Code.Text.Trim().Length < 1 || this.comboBox_Type.Text.Trim().Length < 1 || this.comboBox_Sael.Text.Trim().Length < 1 || this.textBox_Info.Text.Trim().Length < 1)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// 描述信息快捷追加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Append_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            this.textBox_Info.AppendText(btn.Text);
        }

        private void Button_Clear_Click(object sender, EventArgs e)
        {
            this.textBox_Info.Text = "";
        }
    }
}
