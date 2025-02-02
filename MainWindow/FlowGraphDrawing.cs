using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainWindow
{
	namespace FlowGraph
	{
		internal class DrawingHelper
		{
			private readonly Graphics canvas = null;

			public DrawingHelper(PaintEventArgs e)
			{
				canvas = e.Graphics;
			}

			//public void Test()
			//{
			//	canvas.FillRectangle(Brushes.Red, new Rectangle(0, 0, 100, 100));
			//}

			public void Draw(SceneGraph g)
			{
				//
				canvas.FillRectangle(Brushes.Blue, canvas.ClipBounds);

				g.ForEach((i, node) =>
				{
					Brush brush = g.ActiveNodes.Contains(node.ID) ? Brushes.Cyan : Brushes.Red;
					canvas.DrawString(node.Info.Name, new Font("Consolas", 16), brush, 0,
						i * canvas.MeasureString(node.Info.Name, new Font("Consolas", 16)).Height);
				});
				//
			}
		}
	}
}
