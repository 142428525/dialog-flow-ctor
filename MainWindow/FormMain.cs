using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainWindow
{
	public partial class FormMain : Form
	{
		public FormMain()
		{
			InitializeComponent();

			foreach (var item in FlowGraph.GetNodeTypeNames())
			{
				插入节点MenuItem.DropDownItems.Add(item);
				// TODO: 考虑tag？
			}
		}

		private void panel_MouseDown(object sender, MouseEventArgs e)
		{
			//
			//statusLabelDebugMouse.Text = $"Mouse Down: {e.Location}";
			//

			DragScrollHelper.OnMouseDown(e);
			DragScrollHelper.ScrollPos = panel.AutoScrollPosition;
		}

		private void panel_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				Point mouse_delta = DragScrollHelper.OnMouseDrag(/*e*/);
				Point past = DragScrollHelper.ScrollPos;
				Point tmp = panel.AutoScrollPosition;

				panel.AutoScrollPosition = new Point(-past.X - mouse_delta.X, -past.Y - mouse_delta.Y);

				//
				//statusLabelDebugMouse.Text = $"Mouse DragL: {e.Location}, Mouse Delta: {mouse_delta}";
				//statusLabelDebugScroll.Text = $"{past}, {panel.AutoScrollPosition}";
				//

				Refresh();

				if (panel.AutoScrollPosition == tmp)
				{
					DragScrollHelper.OnMouseDown(e);
					DragScrollHelper.ScrollPos = panel.AutoScrollPosition;
				}
			}
		}

		private void pass_on_mouse_down(object sender, MouseEventArgs e)
		{
			panel_MouseDown(sender, e);
		}

		private void pass_on_mouse_move(object sender, MouseEventArgs e)
		{
			panel_MouseMove(sender, e);
		}

		private void radio_button_style_click(object sender, ToolStripItemClickedEventArgs e)
		{
			foreach (ToolStripMenuItem item in (sender as ToolStripDropDownItem).DropDownItems)
			{
				item.Checked = false;
			}

			(e.ClickedItem as ToolStripMenuItem).Checked = true;
		}

		private void 插入节点MenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
			_ = FlowGraph.GetNodeType(e.ClickedItem.Text);
			// TODO: Insert
		}
	}
}
