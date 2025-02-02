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
		FlowGraph.SceneGraph g = new FlowGraph.SceneGraph();

		public FormMain()
		{
			InitializeComponent();

			// NOTE: 编辑-插入节点、节点插入位置 的子菜单列表为动态生成
			// NOTE: 主窗体标题会动态变化？
			// NOTE: 底栏文本框均会动态变化？








			foreach (var item in FlowGraph.NodeReflHelper.GetNodeTypeNames())
			{
				插入节点MenuItem.DropDownItems.Add(item);
			}

			foreach (var item in FlowGraph.InsPosReflHelper.GetDescriptions())
			{
				var tsi = 节点插入位置DropDownButton.DropDownItems.Add(item);

				if (FlowGraph.InsPosReflHelper.ParseDescription(item) == FlowGraph.InsertPos.Afterward)
				{
					(tsi as ToolStripMenuItem).Checked = true;
				}
			}
		}

		private void panel_MouseDown(object sender, MouseEventArgs e)
		{
			//
			//statusLabelDebugMouse.Text = $"Mouse Down: {e.Location}";
			//

			if (e.Button == MouseButtons.Left)
			{
				DragScrollHelper.OnMouseDown(e);
				DragScrollHelper.ScrollPos = panel.AutoScrollPosition;
			}
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

				//Refresh();

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
			Type t = FlowGraph.NodeReflHelper.ParseName(e.ClickedItem.Text);
			FlowGraph.InsertPos pos = FlowGraph.InsPosReflHelper.ParseDescription(
				(from ToolStripMenuItem item in 节点插入位置DropDownButton.DropDownItems
				 where item.Checked
				 select item.Text).Single());

			g.InsertNode(t, pos);

			panelMain.Refresh();
		}

		private void panelMain_Paint(object sender, PaintEventArgs e)
		{
			FlowGraph.DrawingHelper drawer = new FlowGraph.DrawingHelper(e);
			drawer.Draw(g);

			//drawer.Test();
		}
	}
}
