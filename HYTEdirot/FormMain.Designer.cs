namespace HYTEdirot
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.TreeViewDiv = new System.Windows.Forms.TreeView();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItemCode = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuStripTreeView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItemAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.GeckoWebBrowserBody = new Gecko.GeckoWebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.ContextMenuStripTreeView.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.TreeViewDiv);
            this.splitContainer.Panel1.Controls.Add(this.menuStrip);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.GeckoWebBrowserBody);
            this.splitContainer.Size = new System.Drawing.Size(984, 562);
            this.splitContainer.SplitterDistance = 213;
            this.splitContainer.TabIndex = 0;
            // 
            // TreeViewDiv
            // 
            this.TreeViewDiv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TreeViewDiv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TreeViewDiv.Location = new System.Drawing.Point(0, 25);
            this.TreeViewDiv.Name = "TreeViewDiv";
            this.TreeViewDiv.Size = new System.Drawing.Size(211, 535);
            this.TreeViewDiv.TabIndex = 1;
            this.TreeViewDiv.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TreeViewDiv_MouseClick);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemCode,
            this.ToolStripMenuItemAbout});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(211, 25);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // ToolStripMenuItemCode
            // 
            this.ToolStripMenuItemCode.Name = "ToolStripMenuItemCode";
            this.ToolStripMenuItemCode.Size = new System.Drawing.Size(68, 21);
            this.ToolStripMenuItemCode.Text = "查看源码";
            // 
            // ToolStripMenuItemAbout
            // 
            this.ToolStripMenuItemAbout.Name = "ToolStripMenuItemAbout";
            this.ToolStripMenuItemAbout.Size = new System.Drawing.Size(68, 21);
            this.ToolStripMenuItemAbout.Text = "关于我们";
            // 
            // ContextMenuStripTreeView
            // 
            this.ContextMenuStripTreeView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemAdd,
            this.ToolStripMenuItemEdit,
            this.ToolStripMenuItemDelete});
            this.ContextMenuStripTreeView.Name = "contextMenuStrip";
            this.ContextMenuStripTreeView.Size = new System.Drawing.Size(101, 70);
            // 
            // ToolStripMenuItemAdd
            // 
            this.ToolStripMenuItemAdd.Name = "ToolStripMenuItemAdd";
            this.ToolStripMenuItemAdd.Size = new System.Drawing.Size(100, 22);
            this.ToolStripMenuItemAdd.Text = "新增";
            this.ToolStripMenuItemAdd.Click += new System.EventHandler(this.ToolStripMenuItemAdd_Click);
            // 
            // ToolStripMenuItemEdit
            // 
            this.ToolStripMenuItemEdit.Name = "ToolStripMenuItemEdit";
            this.ToolStripMenuItemEdit.Size = new System.Drawing.Size(100, 22);
            this.ToolStripMenuItemEdit.Text = "修改";
            // 
            // ToolStripMenuItemDelete
            // 
            this.ToolStripMenuItemDelete.Name = "ToolStripMenuItemDelete";
            this.ToolStripMenuItemDelete.Size = new System.Drawing.Size(100, 22);
            this.ToolStripMenuItemDelete.Text = "删除";
            // 
            // GeckoWebBrowserBody
            // 
            this.GeckoWebBrowserBody.DisableWmImeSetContext = false;
            this.GeckoWebBrowserBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GeckoWebBrowserBody.Location = new System.Drawing.Point(0, 0);
            this.GeckoWebBrowserBody.Name = "GeckoWebBrowserBody";
            this.GeckoWebBrowserBody.Size = new System.Drawing.Size(765, 560);
            this.GeckoWebBrowserBody.TabIndex = 0;
            this.GeckoWebBrowserBody.UseHttpActivityObserver = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 562);
            this.Controls.Add(this.splitContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "惠源提产品编辑";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ContextMenuStripTreeView.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ContextMenuStrip ContextMenuStripTreeView;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemAdd;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemEdit;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemDelete;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemCode;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemAbout;
        private System.Windows.Forms.TreeView TreeViewDiv;
        private Gecko.GeckoWebBrowser GeckoWebBrowserBody;
    }
}

