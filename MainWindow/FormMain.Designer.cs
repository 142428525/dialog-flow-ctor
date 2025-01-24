
namespace MainWindow
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
		/// 设计器支持所需的方法 - 不要修改
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
			this.toolStripContainer = new System.Windows.Forms.ToolStripContainer();
			this.statusStrip = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStrip = new System.Windows.Forms.ToolStrip();
			this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.panel = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.编辑ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.查看ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
			this.前移ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.后移ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.新建ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.打开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.插入节点ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.子树ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.布局ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.横向ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.纵向ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.剪切ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.复制ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.粘贴ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.线性ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.选择支ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripContainer.BottomToolStripPanel.SuspendLayout();
			this.toolStripContainer.ContentPanel.SuspendLayout();
			this.toolStripContainer.TopToolStripPanel.SuspendLayout();
			this.toolStripContainer.SuspendLayout();
			this.statusStrip.SuspendLayout();
			this.toolStrip.SuspendLayout();
			this.menuStrip.SuspendLayout();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStripContainer
			// 
			// 
			// toolStripContainer.BottomToolStripPanel
			// 
			this.toolStripContainer.BottomToolStripPanel.Controls.Add(this.statusStrip);
			// 
			// toolStripContainer.ContentPanel
			// 
			this.toolStripContainer.ContentPanel.Controls.Add(this.panel);
			this.toolStripContainer.ContentPanel.Controls.Add(this.toolStrip);
			this.toolStripContainer.ContentPanel.Size = new System.Drawing.Size(800, 403);
			this.toolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.toolStripContainer.Location = new System.Drawing.Point(0, 0);
			this.toolStripContainer.Name = "toolStripContainer";
			this.toolStripContainer.Size = new System.Drawing.Size(800, 450);
			this.toolStripContainer.TabIndex = 0;
			this.toolStripContainer.Text = "toolStripContainer";
			// 
			// toolStripContainer.TopToolStripPanel
			// 
			this.toolStripContainer.TopToolStripPanel.Controls.Add(this.menuStrip);
			// 
			// statusStrip
			// 
			this.statusStrip.Dock = System.Windows.Forms.DockStyle.None;
			this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
			this.statusStrip.Location = new System.Drawing.Point(0, 0);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.Size = new System.Drawing.Size(800, 22);
			this.statusStrip.TabIndex = 0;
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(131, 17);
			this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
			// 
			// toolStrip
			// 
			this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripComboBox1,
            this.toolStripSeparator1,
            this.toolStripDropDownButton1});
			this.toolStrip.Location = new System.Drawing.Point(0, 0);
			this.toolStrip.Name = "toolStrip";
			this.toolStrip.Size = new System.Drawing.Size(800, 25);
			this.toolStrip.TabIndex = 0;
			this.toolStrip.Text = "toolStrip";
			// 
			// toolStripLabel1
			// 
			this.toolStripLabel1.Name = "toolStripLabel1";
			this.toolStripLabel1.Size = new System.Drawing.Size(80, 22);
			this.toolStripLabel1.Text = "节点插入位置";
			// 
			// menuStrip
			// 
			this.menuStrip.Dock = System.Windows.Forms.DockStyle.None;
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.编辑ToolStripMenuItem,
            this.查看ToolStripMenuItem});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new System.Drawing.Size(800, 25);
			this.menuStrip.TabIndex = 0;
			this.menuStrip.Text = "menuStrip";
			// 
			// panel
			// 
			this.panel.AutoScroll = true;
			this.panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel.Controls.Add(this.label1);
			this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel.Location = new System.Drawing.Point(0, 25);
			this.panel.Name = "panel";
			this.panel.Size = new System.Drawing.Size(800, 378);
			this.panel.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(229, 303);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(683, 108);
			this.label1.TabIndex = 0;
			this.label1.Text = "label1111111111111111111111111111111111111111111111111111111111111111100000000000" +
    "00000000000000000000000011111111\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n44444testtext";
			// 
			// 文件ToolStripMenuItem
			// 
			this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建ToolStripMenuItem,
            this.打开ToolStripMenuItem,
            this.保存ToolStripMenuItem,
            this.退出ToolStripMenuItem});
			this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
			this.文件ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
			this.文件ToolStripMenuItem.Text = "文件";
			// 
			// 编辑ToolStripMenuItem
			// 
			this.编辑ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.插入节点ToolStripMenuItem,
            this.子树ToolStripMenuItem});
			this.编辑ToolStripMenuItem.Name = "编辑ToolStripMenuItem";
			this.编辑ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
			this.编辑ToolStripMenuItem.Text = "编辑";
			// 
			// 查看ToolStripMenuItem
			// 
			this.查看ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.布局ToolStripMenuItem});
			this.查看ToolStripMenuItem.Name = "查看ToolStripMenuItem";
			this.查看ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
			this.查看ToolStripMenuItem.Text = "查看";
			// 
			// toolStripComboBox1
			// 
			this.toolStripComboBox1.Items.AddRange(new object[] {
            "后方",
            "前方"});
			this.toolStripComboBox1.Name = "toolStripComboBox1";
			this.toolStripComboBox1.Size = new System.Drawing.Size(121, 25);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripDropDownButton1
			// 
			this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.前移ToolStripMenuItem,
            this.后移ToolStripMenuItem});
			this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
			this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
			this.toolStripDropDownButton1.Size = new System.Drawing.Size(69, 22);
			this.toolStripDropDownButton1.Text = "线性移动";
			// 
			// 前移ToolStripMenuItem
			// 
			this.前移ToolStripMenuItem.Name = "前移ToolStripMenuItem";
			this.前移ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.前移ToolStripMenuItem.Text = "前移";
			// 
			// 后移ToolStripMenuItem
			// 
			this.后移ToolStripMenuItem.Name = "后移ToolStripMenuItem";
			this.后移ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.后移ToolStripMenuItem.Text = "后移";
			// 
			// 新建ToolStripMenuItem
			// 
			this.新建ToolStripMenuItem.Name = "新建ToolStripMenuItem";
			this.新建ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.新建ToolStripMenuItem.Text = "新建";
			// 
			// 打开ToolStripMenuItem
			// 
			this.打开ToolStripMenuItem.Name = "打开ToolStripMenuItem";
			this.打开ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.打开ToolStripMenuItem.Text = "打开";
			// 
			// 保存ToolStripMenuItem
			// 
			this.保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
			this.保存ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.保存ToolStripMenuItem.Text = "保存";
			// 
			// 退出ToolStripMenuItem
			// 
			this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
			this.退出ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.退出ToolStripMenuItem.Text = "退出";
			// 
			// 插入节点ToolStripMenuItem
			// 
			this.插入节点ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.线性ToolStripMenuItem,
            this.选择支ToolStripMenuItem});
			this.插入节点ToolStripMenuItem.Name = "插入节点ToolStripMenuItem";
			this.插入节点ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.插入节点ToolStripMenuItem.Text = "插入节点";
			// 
			// 子树ToolStripMenuItem
			// 
			this.子树ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.剪切ToolStripMenuItem,
            this.复制ToolStripMenuItem,
            this.粘贴ToolStripMenuItem,
            this.删除ToolStripMenuItem});
			this.子树ToolStripMenuItem.Name = "子树ToolStripMenuItem";
			this.子树ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.子树ToolStripMenuItem.Text = "子树";
			// 
			// 布局ToolStripMenuItem
			// 
			this.布局ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.横向ToolStripMenuItem,
            this.纵向ToolStripMenuItem});
			this.布局ToolStripMenuItem.Name = "布局ToolStripMenuItem";
			this.布局ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.布局ToolStripMenuItem.Text = "布局";
			// 
			// 横向ToolStripMenuItem
			// 
			this.横向ToolStripMenuItem.Name = "横向ToolStripMenuItem";
			this.横向ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.横向ToolStripMenuItem.Text = "横向";
			// 
			// 纵向ToolStripMenuItem
			// 
			this.纵向ToolStripMenuItem.Name = "纵向ToolStripMenuItem";
			this.纵向ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.纵向ToolStripMenuItem.Text = "纵向";
			// 
			// 剪切ToolStripMenuItem
			// 
			this.剪切ToolStripMenuItem.Name = "剪切ToolStripMenuItem";
			this.剪切ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.剪切ToolStripMenuItem.Text = "剪切";
			// 
			// 复制ToolStripMenuItem
			// 
			this.复制ToolStripMenuItem.Name = "复制ToolStripMenuItem";
			this.复制ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.复制ToolStripMenuItem.Text = "复制";
			// 
			// 粘贴ToolStripMenuItem
			// 
			this.粘贴ToolStripMenuItem.Name = "粘贴ToolStripMenuItem";
			this.粘贴ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.粘贴ToolStripMenuItem.Text = "粘贴";
			// 
			// 删除ToolStripMenuItem
			// 
			this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
			this.删除ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.删除ToolStripMenuItem.Text = "删除";
			// 
			// 线性ToolStripMenuItem
			// 
			this.线性ToolStripMenuItem.Name = "线性ToolStripMenuItem";
			this.线性ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.线性ToolStripMenuItem.Text = "线性";
			// 
			// 选择支ToolStripMenuItem
			// 
			this.选择支ToolStripMenuItem.Name = "选择支ToolStripMenuItem";
			this.选择支ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.选择支ToolStripMenuItem.Text = "选择支";
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.toolStripContainer);
			this.MainMenuStrip = this.menuStrip;
			this.Name = "FormMain";
			this.Text = "对话流制作工具";
			this.toolStripContainer.BottomToolStripPanel.ResumeLayout(false);
			this.toolStripContainer.BottomToolStripPanel.PerformLayout();
			this.toolStripContainer.ContentPanel.ResumeLayout(false);
			this.toolStripContainer.ContentPanel.PerformLayout();
			this.toolStripContainer.TopToolStripPanel.ResumeLayout(false);
			this.toolStripContainer.TopToolStripPanel.PerformLayout();
			this.toolStripContainer.ResumeLayout(false);
			this.toolStripContainer.PerformLayout();
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			this.toolStrip.ResumeLayout(false);
			this.toolStrip.PerformLayout();
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.panel.ResumeLayout(false);
			this.panel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ToolStripContainer toolStripContainer;
		private System.Windows.Forms.StatusStrip statusStrip;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.ToolStrip toolStrip;
		private System.Windows.Forms.ToolStripLabel toolStripLabel1;
		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.Panel panel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 编辑ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 查看ToolStripMenuItem;
		private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
		private System.Windows.Forms.ToolStripMenuItem 前移ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 后移ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 新建ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 打开ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 保存ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 插入节点ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 子树ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 布局ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 横向ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 纵向ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 剪切ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 复制ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 粘贴ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 线性ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 选择支ToolStripMenuItem;
	}
}

