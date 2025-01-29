
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
			this.statusLabelDebugMouse = new System.Windows.Forms.ToolStripStatusLabel();
			this.statusLabelDebugScroll = new System.Windows.Forms.ToolStripStatusLabel();
			this.panel = new System.Windows.Forms.Panel();
			this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.panelMain = new System.Windows.Forms.Panel();
			this.toolStrip = new System.Windows.Forms.ToolStrip();
			this.节点插入位置DropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
			this.后方ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.前方ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.线性移动DropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
			this.前移ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.后移ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.文件MenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.新建MenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.打开MenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.另存为MenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.保存MenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.退出MenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.编辑MenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.插入节点MenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.子树操作MenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.剪切ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.复制ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.粘贴ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.查看MenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.布局MenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.横向MenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.纵向MenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.帮助MenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripContainer.BottomToolStripPanel.SuspendLayout();
			this.toolStripContainer.ContentPanel.SuspendLayout();
			this.toolStripContainer.TopToolStripPanel.SuspendLayout();
			this.toolStripContainer.SuspendLayout();
			this.statusStrip.SuspendLayout();
			this.panel.SuspendLayout();
			this.flowLayoutPanel.SuspendLayout();
			this.toolStrip.SuspendLayout();
			this.menuStrip.SuspendLayout();
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
            this.statusLabelDebugMouse,
            this.statusLabelDebugScroll});
			this.statusStrip.Location = new System.Drawing.Point(0, 0);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.Size = new System.Drawing.Size(800, 22);
			this.statusStrip.TabIndex = 0;
			// 
			// statusLabelDebugMouse
			// 
			this.statusLabelDebugMouse.Name = "statusLabelDebugMouse";
			this.statusLabelDebugMouse.Size = new System.Drawing.Size(47, 17);
			this.statusLabelDebugMouse.Text = "mouse";
			this.statusLabelDebugMouse.Visible = false;
			// 
			// statusLabelDebugScroll
			// 
			this.statusLabelDebugScroll.Name = "statusLabelDebugScroll";
			this.statusLabelDebugScroll.Size = new System.Drawing.Size(39, 17);
			this.statusLabelDebugScroll.Text = "scroll";
			this.statusLabelDebugScroll.Visible = false;
			// 
			// panel
			// 
			this.panel.AutoScroll = true;
			this.panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel.Controls.Add(this.flowLayoutPanel);
			this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel.Location = new System.Drawing.Point(0, 25);
			this.panel.Name = "panel";
			this.panel.Size = new System.Drawing.Size(800, 378);
			this.panel.TabIndex = 1;
			this.panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_MouseDown);
			this.panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_MouseMove);
			// 
			// flowLayoutPanel
			// 
			this.flowLayoutPanel.AutoSize = true;
			this.flowLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.flowLayoutPanel.Controls.Add(this.panelMain);
			this.flowLayoutPanel.Location = new System.Drawing.Point(0, 0);
			this.flowLayoutPanel.Name = "flowLayoutPanel";
			this.flowLayoutPanel.Padding = new System.Windows.Forms.Padding(30);
			this.flowLayoutPanel.Size = new System.Drawing.Size(807, 521);
			this.flowLayoutPanel.TabIndex = 0;
			this.flowLayoutPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pass_on_mouse_down);
			this.flowLayoutPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pass_on_mouse_move);
			// 
			// panelMain
			// 
			this.panelMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.panelMain.Location = new System.Drawing.Point(33, 33);
			this.panelMain.Name = "panelMain";
			this.panelMain.Size = new System.Drawing.Size(741, 455);
			this.panelMain.TabIndex = 2;
			this.panelMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pass_on_mouse_down);
			this.panelMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pass_on_mouse_move);
			// 
			// toolStrip
			// 
			this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.节点插入位置DropDownButton,
            this.toolStripSeparator1,
            this.线性移动DropDownButton});
			this.toolStrip.Location = new System.Drawing.Point(0, 0);
			this.toolStrip.Name = "toolStrip";
			this.toolStrip.Size = new System.Drawing.Size(800, 25);
			this.toolStrip.TabIndex = 0;
			this.toolStrip.Text = "toolStrip";
			// 
			// 节点插入位置DropDownButton
			// 
			this.节点插入位置DropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.节点插入位置DropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.后方ToolStripMenuItem,
            this.前方ToolStripMenuItem});
			this.节点插入位置DropDownButton.Name = "节点插入位置DropDownButton";
			this.节点插入位置DropDownButton.Size = new System.Drawing.Size(93, 22);
			this.节点插入位置DropDownButton.Text = "节点插入位置";
			this.节点插入位置DropDownButton.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.radio_button_style_click);
			// 
			// 后方ToolStripMenuItem
			// 
			this.后方ToolStripMenuItem.Checked = true;
			this.后方ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
			this.后方ToolStripMenuItem.Name = "后方ToolStripMenuItem";
			this.后方ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
			this.后方ToolStripMenuItem.Text = "后方";
			// 
			// 前方ToolStripMenuItem
			// 
			this.前方ToolStripMenuItem.Name = "前方ToolStripMenuItem";
			this.前方ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
			this.前方ToolStripMenuItem.Text = "前方";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// 线性移动DropDownButton
			// 
			this.线性移动DropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.线性移动DropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.前移ToolStripMenuItem,
            this.后移ToolStripMenuItem});
			this.线性移动DropDownButton.Image = ((System.Drawing.Image)(resources.GetObject("线性移动DropDownButton.Image")));
			this.线性移动DropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.线性移动DropDownButton.Name = "线性移动DropDownButton";
			this.线性移动DropDownButton.Size = new System.Drawing.Size(74, 22);
			this.线性移动DropDownButton.Text = "线性移动*";
			// 
			// 前移ToolStripMenuItem
			// 
			this.前移ToolStripMenuItem.Name = "前移ToolStripMenuItem";
			this.前移ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
			this.前移ToolStripMenuItem.Text = "前移";
			// 
			// 后移ToolStripMenuItem
			// 
			this.后移ToolStripMenuItem.Name = "后移ToolStripMenuItem";
			this.后移ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
			this.后移ToolStripMenuItem.Text = "后移";
			// 
			// menuStrip
			// 
			this.menuStrip.Dock = System.Windows.Forms.DockStyle.None;
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件MenuItem,
            this.编辑MenuItem,
            this.查看MenuItem,
            this.帮助MenuItem});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new System.Drawing.Size(800, 25);
			this.menuStrip.TabIndex = 0;
			this.menuStrip.Text = "menuStrip";
			// 
			// 文件MenuItem
			// 
			this.文件MenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建MenuItem,
            this.打开MenuItem,
            this.另存为MenuItem,
            this.保存MenuItem,
            this.退出MenuItem});
			this.文件MenuItem.Name = "文件MenuItem";
			this.文件MenuItem.Size = new System.Drawing.Size(44, 21);
			this.文件MenuItem.Text = "文件";
			// 
			// 新建MenuItem
			// 
			this.新建MenuItem.Name = "新建MenuItem";
			this.新建MenuItem.Size = new System.Drawing.Size(180, 22);
			this.新建MenuItem.Text = "新建";
			// 
			// 打开MenuItem
			// 
			this.打开MenuItem.Name = "打开MenuItem";
			this.打开MenuItem.Size = new System.Drawing.Size(180, 22);
			this.打开MenuItem.Text = "打开……";
			// 
			// 另存为MenuItem
			// 
			this.另存为MenuItem.Name = "另存为MenuItem";
			this.另存为MenuItem.Size = new System.Drawing.Size(180, 22);
			this.另存为MenuItem.Text = "另存为……";
			// 
			// 保存MenuItem
			// 
			this.保存MenuItem.Name = "保存MenuItem";
			this.保存MenuItem.Size = new System.Drawing.Size(180, 22);
			this.保存MenuItem.Text = "保存";
			// 
			// 退出MenuItem
			// 
			this.退出MenuItem.Name = "退出MenuItem";
			this.退出MenuItem.Size = new System.Drawing.Size(180, 22);
			this.退出MenuItem.Text = "退出";
			// 
			// 编辑MenuItem
			// 
			this.编辑MenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.插入节点MenuItem,
            this.子树操作MenuItem});
			this.编辑MenuItem.Name = "编辑MenuItem";
			this.编辑MenuItem.Size = new System.Drawing.Size(49, 21);
			this.编辑MenuItem.Text = "编辑*";
			// 
			// 插入节点MenuItem
			// 
			this.插入节点MenuItem.Name = "插入节点MenuItem";
			this.插入节点MenuItem.Size = new System.Drawing.Size(180, 22);
			this.插入节点MenuItem.Text = "插入节点";
			this.插入节点MenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.插入节点MenuItem_DropDownItemClicked);
			// 
			// 子树操作MenuItem
			// 
			this.子树操作MenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.剪切ToolStripMenuItem,
            this.复制ToolStripMenuItem,
            this.粘贴ToolStripMenuItem,
            this.删除ToolStripMenuItem});
			this.子树操作MenuItem.Name = "子树操作MenuItem";
			this.子树操作MenuItem.Size = new System.Drawing.Size(180, 22);
			this.子树操作MenuItem.Text = "子树操作";
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
			// 查看MenuItem
			// 
			this.查看MenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.布局MenuItem});
			this.查看MenuItem.Name = "查看MenuItem";
			this.查看MenuItem.Size = new System.Drawing.Size(44, 21);
			this.查看MenuItem.Text = "查看";
			// 
			// 布局MenuItem
			// 
			this.布局MenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.横向MenuItem,
            this.纵向MenuItem});
			this.布局MenuItem.Name = "布局MenuItem";
			this.布局MenuItem.Size = new System.Drawing.Size(180, 22);
			this.布局MenuItem.Text = "布局";
			this.布局MenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.radio_button_style_click);
			// 
			// 横向MenuItem
			// 
			this.横向MenuItem.Name = "横向MenuItem";
			this.横向MenuItem.Size = new System.Drawing.Size(100, 22);
			this.横向MenuItem.Text = "横向";
			// 
			// 纵向MenuItem
			// 
			this.纵向MenuItem.Checked = true;
			this.纵向MenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
			this.纵向MenuItem.Name = "纵向MenuItem";
			this.纵向MenuItem.Size = new System.Drawing.Size(100, 22);
			this.纵向MenuItem.Text = "纵向";
			// 
			// 帮助MenuItem
			// 
			this.帮助MenuItem.Name = "帮助MenuItem";
			this.帮助MenuItem.Size = new System.Drawing.Size(44, 21);
			this.帮助MenuItem.Text = "帮助";
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
			this.panel.ResumeLayout(false);
			this.panel.PerformLayout();
			this.flowLayoutPanel.ResumeLayout(false);
			this.toolStrip.ResumeLayout(false);
			this.toolStrip.PerformLayout();
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ToolStripContainer toolStripContainer;
		private System.Windows.Forms.StatusStrip statusStrip;
		private System.Windows.Forms.ToolStripStatusLabel statusLabelDebugMouse;
		private System.Windows.Forms.ToolStrip toolStrip;
		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.Panel panel;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem 文件MenuItem;
		private System.Windows.Forms.ToolStripMenuItem 编辑MenuItem;
		private System.Windows.Forms.ToolStripMenuItem 查看MenuItem;
		private System.Windows.Forms.ToolStripDropDownButton 线性移动DropDownButton;
		private System.Windows.Forms.ToolStripMenuItem 前移ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 后移ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 新建MenuItem;
		private System.Windows.Forms.ToolStripMenuItem 打开MenuItem;
		private System.Windows.Forms.ToolStripMenuItem 保存MenuItem;
		private System.Windows.Forms.ToolStripMenuItem 退出MenuItem;
		private System.Windows.Forms.ToolStripMenuItem 插入节点MenuItem;
		private System.Windows.Forms.ToolStripMenuItem 子树操作MenuItem;
		private System.Windows.Forms.ToolStripMenuItem 布局MenuItem;
		private System.Windows.Forms.ToolStripMenuItem 横向MenuItem;
		private System.Windows.Forms.ToolStripMenuItem 纵向MenuItem;
		private System.Windows.Forms.ToolStripMenuItem 剪切ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 复制ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 粘贴ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
		private System.Windows.Forms.ToolStripDropDownButton 节点插入位置DropDownButton;
		private System.Windows.Forms.ToolStripMenuItem 后方ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 前方ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 另存为MenuItem;
		private System.Windows.Forms.ToolStripStatusLabel statusLabelDebugScroll;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
		private System.Windows.Forms.Panel panelMain;
		private System.Windows.Forms.ToolStripMenuItem 帮助MenuItem;
	}
}

