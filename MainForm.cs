using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;
using Newtonsoft.Json;

namespace AnloTools
{
    
    public partial class MainForm : Form
    {
        /// <summary>
        /// 保存检材列表
        /// </summary>
        List<Sample> sampleList = new List<Sample>();
        /// <summary>
        /// 案件编号
        /// </summary>
        string code = "";
        /// <summary>
        /// 案情简要
        /// </summary>
        string info = "";
        /// <summary>
        /// 案件时间
        /// </summary>
        DateTime time = DateTime.Now;
        /// <summary>
        /// 项目路径
        /// </summary>
        string projectPath = "";
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 窗口关闭事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainFrom_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("是否真的退出？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(r == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }
        }

        /// <summary>
        /// 菜单栏退出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 退出EToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 菜单栏新建
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 新建案件NToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.code = "";
            this.info = "";
            this.sampleList.RemoveRange(0, this.sampleList.Count);
            this.listView_Main.Items.Clear();
            NewForm from = new NewForm();
            DialogResult r = from.ShowDialog();
            if(r == DialogResult.OK)
            {
                this.code = from.Code;
                this.info = from.Name;
                this.Text += " - " + this.code;
                this.Text += " *";
                AppendForm appendForm = new AppendForm(this);
                appendForm.Show();
            }
        }

        /// <summary>
        /// 获取已添加检材总数
        /// </summary>
        /// <returns></returns>
        public int GetSampleCount()
        {
            return this.sampleList.Count;
        }

        /// <summary>
        /// 获取项目编号
        /// </summary>
        /// <returns></returns>
        public string GetProjectCode()
        {
            return this.code;
        }

        /// <summary>
        /// 添加检材
        /// </summary>
        /// <param name="sample"></param>
        /// <returns></returns>
        public int Append(Sample sample)
        {
            sample.Id = this.sampleList.Count + 1;
            this.sampleList.Add(sample);
            //string tempFileName = System.Windows.Forms.Application.StartupPath + "\\project\\" + this.code + ".json";
            //SaveJson(tempFileName);
            ListViewItem lvi = new ListViewItem(sample.Id.ToString());
            lvi.SubItems.Add(sample.Code);
            lvi.SubItems.Add(sample.Type);
            lvi.SubItems.Add(sample.Seal);
            lvi.SubItems.Add(sample.Info);
            this.listView_Main.Items.Add(lvi);
            if (this.Text.IndexOf(" *") < 0)
            {
                this.Text += " *";
            }
            return sample.Id;
        }

        private void 添加检材AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(this.code.Length < 1)
            {
                return;
            }
            AppendForm appendForm = new AppendForm(this);
            appendForm.Show();
        }

        private void 生成清单BToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.code.Length < 1)
            {
                return;
            }
            // 选择输出的目录
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();
            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
            {
                toolStripStatusLabel_Status.Text = "正在生成...";
                // 备份检材清单
                List<Sample> buildSampleList = new List<Sample>();
                buildSampleList.AddRange(this.sampleList);
                int count = 1;
                while(true)
                {
                    string fileName = string.Format("{0}\\{1}-{2}.docx",fbd.SelectedPath,this.code, count);
                    BuildList(ref buildSampleList,fileName);
                    if(buildSampleList.Count < 1)
                    {
                        break;
                    }
                    count++;
                }
                toolStripStatusLabel_Status.Text = "就绪";
            }
        }

        /// <summary>
        /// 生成清单
        /// </summary>
        /// <param name="list">15个检材</param>
        /// <param name="outFileName">输出文件名</param>
        private void BuildList(ref List<Sample> list, string outFileName)
        {
            object temple = System.Windows.Forms.Application.StartupPath + "\\Template.odt";
            object oMissing = System.Reflection.Missing.Value;
            Microsoft.Office.Interop.Word.Application wordApp = null;
            Microsoft.Office.Interop.Word.Document wordDoc = null;
            try
            {
                wordApp = new Microsoft.Office.Interop.Word.Application();
                wordDoc = wordApp.Documents.Add(ref temple, ref oMissing, ref oMissing, ref oMissing);
                // 书签替换
                object[] oBookMark = new object[2];
                oBookMark[0] = "ProjectCode";
                oBookMark[1] = "ProjectName";
                wordDoc.Bookmarks.get_Item(ref oBookMark[0]).Range.Text = this.code;
                wordDoc.Bookmarks.get_Item(ref oBookMark[1]).Range.Text = this.info;
                // 获取主表格
                Microsoft.Office.Interop.Word.Table nowTable = wordDoc.Tables[1];
                int count = 0;
                if (list.Count > 15)
                {
                    count = 15;
                }
                else
                {
                    count = list.Count;
                }
                for (int i = 0; i < count; i++)
                {
                    Sample sample = list[i];
                    nowTable.Cell(3 + i, 1).Range.Text = sample.Code;
                    nowTable.Cell(3 + i, 2).Range.Text = sample.Type;
                    nowTable.Cell(3 + i, 3).Range.Text = sample.Seal;
                    nowTable.Cell(3 + i, 4).Range.Text = sample.Info;
                }
                list.RemoveRange(0, count);
                object fileName = outFileName;
                wordDoc.SaveAs(ref fileName, ref oMissing, ref oMissing, ref oMissing);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (wordDoc != null)
                {
                    wordDoc.Close();
                }
                if (wordApp != null)
                {
                    wordApp.Quit();
                }
                wordApp = null;
            }

        }

        private void 关于AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox about = new AboutBox();
            about.ShowDialog();
        }

        private void 编辑EToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (this.listView_Main.SelectedItems.Count < 1)
            {
                return;
            }
            int id = int.Parse(this.listView_Main.SelectedItems[0].Text) - 1;
            AppendForm edit = new AppendForm(this, this.sampleList[id],id);
            edit.ShowDialog();
        }

        public void Set(int index,Sample sample)
        {
            this.sampleList[index] = sample;
            if (this.listView_Main.SelectedItems.Count < 1)
            {
                return;
            }
            this.listView_Main.SelectedItems[0].SubItems[2].Text = sample.Type;
            this.listView_Main.SelectedItems[0].SubItems[3].Text = sample.Seal;
            this.listView_Main.SelectedItems[0].SubItems[4].Text = sample.Info;
        }

        private void ListView_Main_DoubleClick(object sender, EventArgs e)
        {
            编辑EToolStripMenuItem1_Click(sender, e);
        }

        /// <summary>
        /// 把内存中的检材保存为json
        /// </summary>
        private void SaveJson(string fileName)
        {
            
            try
            {
                Project project = new Project();
                project.Code = this.code;
                project.Name = this.info;
                project.List = this.sampleList;
                string jsonData = JsonConvert.SerializeObject(project);
                StreamWriter sw = new StreamWriter(fileName, false);
                sw.Write(jsonData);
                sw.Close();
            }
            catch (Exception)
            {
            }
        }

        private bool ReadJson(string fileName)
        {
            try
            {
                StreamReader sr = new StreamReader(fileName, Encoding.UTF8);
                string jsonStr = sr.ReadToEnd();
                Project p = JsonConvert.DeserializeObject<Project>(jsonStr);
                sr.Close();
                this.code = p.Code;
                this.info = p.Name;
                this.sampleList = p.List;
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("打开案件失败！");
                return false;
            }
        }

        private void 打开案件OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.InitialDirectory = System.Windows.Forms.Application.StartupPath + "\\project\\";
            fd.Filter = "案件项目|*.json|所有文件|*.*";
            fd.RestoreDirectory = false;
            if(fd.ShowDialog() == DialogResult.OK)
            {
                if(ReadJson(System.IO.Path.GetFullPath(fd.FileName)))
                {
                    this.listView_Main.Items.Clear();
                    for (int i = 0; i < this.sampleList.Count; i++)
                    {
                        Sample sample = this.sampleList[i];
                        ListViewItem lvi = new ListViewItem(sample.Id.ToString());
                        lvi.SubItems.Add(sample.Code);
                        lvi.SubItems.Add(sample.Type);
                        lvi.SubItems.Add(sample.Seal);
                        lvi.SubItems.Add(sample.Info);
                        this.listView_Main.Items.Add(lvi);
                    }
                    this.projectPath = System.IO.Path.GetFullPath(fd.FileName);
                    this.Text += " - " + this.code;
                }
            }
        }

        private void 保存案件SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.code.Length < 1)
            {
                return;
            }
            if (this.projectPath.Length < 1)
            {
                SaveFileDialog fd = new SaveFileDialog();
                fd.InitialDirectory = System.Windows.Forms.Application.StartupPath + "\\project\\";
                fd.Filter = "案件项目|*.json|所有文件|*.*";
                fd.RestoreDirectory = false;
                fd.FileName = this.code;
                if (fd.ShowDialog() == DialogResult.OK)
                {
                    this.projectPath = System.IO.Path.GetFullPath(fd.FileName);
                }
            }
            SaveJson(this.projectPath);
            this.Text = this.Text.Replace(" *","");
            //string tempFileName = System.Windows.Forms.Application.StartupPath + "\\project\\" + this.code + ".json";
            //SaveJson(tempFileName);
        }
    }

    public class Project
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public List<Sample> List { get; set; }
    }
}
