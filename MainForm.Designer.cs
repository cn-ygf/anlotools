namespace AnloTools
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip_Main = new System.Windows.Forms.MenuStrip();
            this.文件FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新建案件NToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开案件OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存案件SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.生成清单BToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.退出EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加检材AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listView_Main = new System.Windows.Forms.ListView();
            this.columnHeader_Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Code = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Seal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Info = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip_Main = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.编辑EToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip_Main = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_Status = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip_Main.SuspendLayout();
            this.contextMenuStrip_Main.SuspendLayout();
            this.statusStrip_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip_Main
            // 
            this.menuStrip_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件FToolStripMenuItem,
            this.编辑EToolStripMenuItem,
            this.帮助HToolStripMenuItem});
            this.menuStrip_Main.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_Main.Name = "menuStrip_Main";
            this.menuStrip_Main.Size = new System.Drawing.Size(884, 25);
            this.menuStrip_Main.TabIndex = 0;
            this.menuStrip_Main.Text = "menuStrip1";
            // 
            // 文件FToolStripMenuItem
            // 
            this.文件FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建案件NToolStripMenuItem,
            this.打开案件OToolStripMenuItem,
            this.保存案件SToolStripMenuItem,
            this.生成清单BToolStripMenuItem,
            this.toolStripSeparator1,
            this.退出EToolStripMenuItem});
            this.文件FToolStripMenuItem.Name = "文件FToolStripMenuItem";
            this.文件FToolStripMenuItem.Size = new System.Drawing.Size(58, 21);
            this.文件FToolStripMenuItem.Text = "文件(&F)";
            // 
            // 新建案件NToolStripMenuItem
            // 
            this.新建案件NToolStripMenuItem.Name = "新建案件NToolStripMenuItem";
            this.新建案件NToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.新建案件NToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.新建案件NToolStripMenuItem.Text = "新建案件";
            this.新建案件NToolStripMenuItem.Click += new System.EventHandler(this.新建案件NToolStripMenuItem_Click);
            // 
            // 打开案件OToolStripMenuItem
            // 
            this.打开案件OToolStripMenuItem.Name = "打开案件OToolStripMenuItem";
            this.打开案件OToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.打开案件OToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.打开案件OToolStripMenuItem.Text = "打开案件";
            this.打开案件OToolStripMenuItem.Click += new System.EventHandler(this.打开案件OToolStripMenuItem_Click);
            // 
            // 保存案件SToolStripMenuItem
            // 
            this.保存案件SToolStripMenuItem.Name = "保存案件SToolStripMenuItem";
            this.保存案件SToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.保存案件SToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.保存案件SToolStripMenuItem.Text = "保存案件";
            this.保存案件SToolStripMenuItem.Click += new System.EventHandler(this.保存案件SToolStripMenuItem_Click);
            // 
            // 生成清单BToolStripMenuItem
            // 
            this.生成清单BToolStripMenuItem.Name = "生成清单BToolStripMenuItem";
            this.生成清单BToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.生成清单BToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.生成清单BToolStripMenuItem.Text = "生成清单";
            this.生成清单BToolStripMenuItem.Click += new System.EventHandler(this.生成清单BToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(168, 6);
            // 
            // 退出EToolStripMenuItem
            // 
            this.退出EToolStripMenuItem.Name = "退出EToolStripMenuItem";
            this.退出EToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.退出EToolStripMenuItem.Text = "退出";
            this.退出EToolStripMenuItem.Click += new System.EventHandler(this.退出EToolStripMenuItem_Click);
            // 
            // 编辑EToolStripMenuItem
            // 
            this.编辑EToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加检材AToolStripMenuItem});
            this.编辑EToolStripMenuItem.Name = "编辑EToolStripMenuItem";
            this.编辑EToolStripMenuItem.Size = new System.Drawing.Size(59, 21);
            this.编辑EToolStripMenuItem.Text = "编辑(&E)";
            // 
            // 添加检材AToolStripMenuItem
            // 
            this.添加检材AToolStripMenuItem.Name = "添加检材AToolStripMenuItem";
            this.添加检材AToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.添加检材AToolStripMenuItem.Text = "添加检材(&A)";
            this.添加检材AToolStripMenuItem.Click += new System.EventHandler(this.添加检材AToolStripMenuItem_Click);
            // 
            // 帮助HToolStripMenuItem
            // 
            this.帮助HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于AToolStripMenuItem});
            this.帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem";
            this.帮助HToolStripMenuItem.Size = new System.Drawing.Size(61, 21);
            this.帮助HToolStripMenuItem.Text = "帮助(&H)";
            // 
            // 关于AToolStripMenuItem
            // 
            this.关于AToolStripMenuItem.Name = "关于AToolStripMenuItem";
            this.关于AToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.关于AToolStripMenuItem.Text = "关于(&A)";
            this.关于AToolStripMenuItem.Click += new System.EventHandler(this.关于AToolStripMenuItem_Click);
            // 
            // listView_Main
            // 
            this.listView_Main.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_Id,
            this.columnHeader_Code,
            this.columnHeader_Type,
            this.columnHeader_Seal,
            this.columnHeader_Info});
            this.listView_Main.ContextMenuStrip = this.contextMenuStrip_Main;
            this.listView_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView_Main.FullRowSelect = true;
            this.listView_Main.GridLines = true;
            this.listView_Main.HideSelection = false;
            this.listView_Main.Location = new System.Drawing.Point(0, 25);
            this.listView_Main.Name = "listView_Main";
            this.listView_Main.Size = new System.Drawing.Size(884, 536);
            this.listView_Main.TabIndex = 1;
            this.listView_Main.UseCompatibleStateImageBehavior = false;
            this.listView_Main.View = System.Windows.Forms.View.Details;
            this.listView_Main.DoubleClick += new System.EventHandler(this.ListView_Main_DoubleClick);
            // 
            // columnHeader_Id
            // 
            this.columnHeader_Id.Text = "序号";
            // 
            // columnHeader_Code
            // 
            this.columnHeader_Code.Text = "检材编号";
            this.columnHeader_Code.Width = 179;
            // 
            // columnHeader_Type
            // 
            this.columnHeader_Type.Text = "检材类型";
            this.columnHeader_Type.Width = 78;
            // 
            // columnHeader_Seal
            // 
            this.columnHeader_Seal.Text = "封存";
            this.columnHeader_Seal.Width = 91;
            // 
            // columnHeader_Info
            // 
            this.columnHeader_Info.Text = "描述信息";
            this.columnHeader_Info.Width = 360;
            // 
            // contextMenuStrip_Main
            // 
            this.contextMenuStrip_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.编辑EToolStripMenuItem1});
            this.contextMenuStrip_Main.Name = "contextMenuStrip_Main";
            this.contextMenuStrip_Main.Size = new System.Drawing.Size(116, 26);
            // 
            // 编辑EToolStripMenuItem1
            // 
            this.编辑EToolStripMenuItem1.Name = "编辑EToolStripMenuItem1";
            this.编辑EToolStripMenuItem1.Size = new System.Drawing.Size(115, 22);
            this.编辑EToolStripMenuItem1.Text = "修改(&S)";
            this.编辑EToolStripMenuItem1.Click += new System.EventHandler(this.编辑EToolStripMenuItem1_Click);
            // 
            // statusStrip_Main
            // 
            this.statusStrip_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_Status});
            this.statusStrip_Main.Location = new System.Drawing.Point(0, 539);
            this.statusStrip_Main.Name = "statusStrip_Main";
            this.statusStrip_Main.Size = new System.Drawing.Size(884, 22);
            this.statusStrip_Main.TabIndex = 2;
            this.statusStrip_Main.Text = "statusStrip1";
            // 
            // toolStripStatusLabel_Status
            // 
            this.toolStripStatusLabel_Status.Name = "toolStripStatusLabel_Status";
            this.toolStripStatusLabel_Status.Size = new System.Drawing.Size(32, 17);
            this.toolStripStatusLabel_Status.Text = "就绪";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.statusStrip_Main);
            this.Controls.Add(this.listView_Main);
            this.Controls.Add(this.menuStrip_Main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip_Main;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "检材登记工具 V1.0.3 Code by YGF";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFrom_FormClosing);
            this.menuStrip_Main.ResumeLayout(false);
            this.menuStrip_Main.PerformLayout();
            this.contextMenuStrip_Main.ResumeLayout(false);
            this.statusStrip_Main.ResumeLayout(false);
            this.statusStrip_Main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip_Main;
        private System.Windows.Forms.ToolStripMenuItem 文件FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新建案件NToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 生成清单BToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 退出EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 编辑EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于AToolStripMenuItem;
        private System.Windows.Forms.ListView listView_Main;
        private System.Windows.Forms.StatusStrip statusStrip_Main;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_Status;
        private System.Windows.Forms.ColumnHeader columnHeader_Id;
        private System.Windows.Forms.ColumnHeader columnHeader_Code;
        private System.Windows.Forms.ColumnHeader columnHeader_Type;
        private System.Windows.Forms.ColumnHeader columnHeader_Seal;
        private System.Windows.Forms.ColumnHeader columnHeader_Info;
        private System.Windows.Forms.ToolStripMenuItem 添加检材AToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_Main;
        private System.Windows.Forms.ToolStripMenuItem 编辑EToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 打开案件OToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存案件SToolStripMenuItem;
    }
}

