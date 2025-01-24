using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainWindow
{
	class FlowGraph
	{
		class AdjacencyList
		{
			struct NodeData
			{
				// TODO
				//public List<string> Data;
				//public NodeType Type;

				public enum NodeType
				{
					Start,
					End,
					Linear,
					Switch
				}

				//public enum NodeAction
				//{
				//	Empty,

				//}
			}

			List<NodeData> nodes = new List<NodeData>();
		}

		AdjacencyList graph = new AdjacencyList();
	}
}
