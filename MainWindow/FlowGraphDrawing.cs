using MainWindow.FlowGraph.Drawing;
using MainWindow.FlowGraph.Extender;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainWindow
{
	namespace FlowGraph
	{
		namespace Drawing
		{
			internal class DrawnNode
			{
				public struct DrawParam
				{
					public Brush Brush { get; }
					public Font Font { get; }

					public DrawParam(Brush brush, Font font) : this()
					{
						Brush = brush;
						Font = font;
					}
				}

				private readonly Graphics canvas = null;
				private readonly DrawParam param;

				public Node LogicNode { get; }
				public SizeF Size { get; }

				private DrawnNode() { }

				public DrawnNode(Graphics g, Node logic_node, DrawParam draw_param)
				{
					canvas = g;
					LogicNode = logic_node;
					param = draw_param;

					SizeF size = canvas.MeasureString(LogicNode.Info.Name, param.Font);
					size.Width *= 1.92F;
					size.Height *= 1.29F;
					Size = size;
				}

				public void Draw(float x, float y)
				{
					RectangleF rect = new RectangleF(x, y, Size.Width, Size.Height);
					canvas.FillRectangle(Brushes.Black, rect);
					canvas.DrawString(LogicNode.Info.Name, param.Font, param.Brush, rect,
						new StringFormat()
						{
							Alignment = StringAlignment.Center,
							LineAlignment = StringAlignment.Center
						});
				}

				public Size GetSizeCeiled() => new Size((int)Math.Ceiling(Size.Width),
						(int)Math.Ceiling(Size.Height));
			}
		}

		internal static class FontFileHelper
		{
			public static Font Load(string filePath, int font_size)
			{
				PrivateFontCollection pfc = new PrivateFontCollection();
				pfc.AddFontFile(filePath);
				return new Font(pfc.Families[0], font_size, FontStyle.Regular, GraphicsUnit.Point, 0);
			}
		}

		internal class DrawnSceneGraph
		{
			public SceneGraph LogicGraph { get; } = null;
			public ClickInputTracer Tracer { get; } = null;

			private DrawnSceneGraph() { }

			public DrawnSceneGraph(Graphics g)
			{
				Tracer = new ClickInputTracer(g);
			}
		}

		internal class ClickInputTracer
		{
			private readonly Graphics canvas = null;
			private readonly Dictionary<DrawnNode, PointF> on_canvas = new Dictionary<DrawnNode, PointF>();

			public ClickInputTracer(Graphics g)
			{
				canvas = g;
			}

			public void AddTrace(DrawnNode dnode, float x, float y)
			{
				on_canvas.Add(dnode, new PointF(x, y));
			}

			public void OnClick(MouseEventArgs e)
			{
				var tmp = from kv in on_canvas
						  let rect = new RectangleF(kv.Value, kv.Key.Size)
						  where rect.Contains(e.Location)
						  select kv.Key;

				if (tmp.Count() == 0)
				{
					return;
				}

				DrawnNode dnode = tmp.Single();

				//
				//MessageBox.Show($"{dnode.LogicNode.ID.Value}");
				//

				Control c = dnode.LogicNode.Info.Visualize();
				if (c != null)
				{
					new FormVisualizer(c, dnode.LogicNode.ToString()).ShowDialog();
				}
			}
		}

		internal class DrawingHelper
		{
			private readonly Control control = null;
			private readonly Graphics canvas = null;

			public DrawingHelper(Control c, PaintEventArgs e)
			{
				control = c;
				canvas = e.Graphics;
			}

			//public void Test()
			//{
			//	canvas.FillRectangle(Brushes.Red, new Rectangle(0, 0, 100, 100));
			//}

			public DrawnSceneGraph Draw(SceneGraph g)
			{
				//

				// it's a meaningless value now...           vvv
				//canvas.FillRectangle(Brushes.Blue, canvas.ClipBounds);
				var dg = g.RenderCast(canvas);

				g.ForEach((i, node) =>
				{
					Brush brush = g.ActiveNodes.Contains(node.ID) ? Brushes.Cyan : Brushes.Red;
					DrawnNode dnode = new DrawnNode(canvas, node,
						new DrawnNode.DrawParam(brush, new Font("Consolas", 32)));
					auto_size_draw(dnode, 0, i * dnode.Size.Height);

					void auto_size_draw(DrawnNode renderee, float x, float y)
					{
						renderee.Draw(x, y);
						dg.Tracer.AddTrace(dnode, x, y);

						float width = x + renderee.Size.Width;
						if (control.Width < width)
						{
							control.Width = ceil(width);
						}

						float height = y + renderee.Size.Height;
						if (control.Height < height)
						{
							control.Height = ceil(height);
						}

						int ceil(double d) => (int)Math.Ceiling(d);
					}
				});

				return dg;

				//
			}
		}
	}
}
