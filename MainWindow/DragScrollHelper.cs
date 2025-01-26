using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainWindow
{
	static class DragScrollHelper
	{
		public static Point MouseDownPos { get; private set; }
		public static Point MouseDownAbsPos { get; private set; }
		public static Point ScrollPos { get; set; }

		public static void OnMouseDown(MouseEventArgs e)
		{
			MouseDownPos = e.Location;
			MouseDownAbsPos = Control.MousePosition;
		}

		/// <returns>鼠标位置增量</returns>
		public static Point OnMouseDrag(/*MouseEventArgs e*/)
		{
			//return new Point(e.Location.X - MouseDownPos.X, e.Location.Y - MouseDownPos.Y);
			return new Point(Control.MousePosition.X - MouseDownAbsPos.X,
				Control.MousePosition.Y - MouseDownAbsPos.Y);
		}
	}


	//private void panel_MouseDown(object sender, MouseEventArgs e)
	//{
	//	//
	//	statusLabelDebugMouse.Text = $"Mouse Down: {e.Location}";
	//	//

	//	DragScrollHelper.OnMouseDown(e);
	//	DragScrollHelper.ScrollPos = panel.AutoScrollPosition;
	//}

	//private void panel_MouseMove(object sender, MouseEventArgs e)
	//{
	//	if (e.Button == MouseButtons.Left)
	//	{
	//		Point mouse_delta = DragScrollHelper.OnMouseDrag(e);
	//		Point past = DragScrollHelper.ScrollPos;

	//		panel.AutoScrollPosition = new Point(-past.X - mouse_delta.X, -past.Y - mouse_delta.Y);

	//		//
	//		statusLabelDebugMouse.Text = $"Mouse DragL: {e.Location}, Mouse Delta: {mouse_delta}";
	//		statusLabelDebugScroll.Text = $"{past} {panel.AutoScrollPosition}";
	//		//

	//		DragScrollHelper.OnMouseDown(e);
	//		DragScrollHelper.ScrollPos = panel.AutoScrollPosition;

	//		Refresh();
	//	}
	//}
}
