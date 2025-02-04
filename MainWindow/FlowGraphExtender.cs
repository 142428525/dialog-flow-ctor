using MainWindow.FlowGraph.Drawing;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainWindow
{
	namespace FlowGraph
	{
		namespace Extender
		{
			internal static class SceneGraphExtender
			{
				public static DrawnSceneGraph RenderCast(this SceneGraph g, Graphics canvas)
				{
					return new DrawnSceneGraph(canvas);
				}
			}
		}
	}
}
