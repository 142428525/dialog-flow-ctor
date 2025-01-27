using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainWindow
{
	internal partial class FlowGraph
	{
		private partial class AdjacencyList
		{
			Dictionary<NodeID, List<NodeID>> edges = new Dictionary<NodeID, List<NodeID>>();
			Dictionary<NodeID, NodeInfoBase> nodes = new Dictionary<NodeID, NodeInfoBase>();

			// TODO: API

			public void Insert()
			{
				//
			}
		}

		private AdjacencyList graph = new AdjacencyList();
		private AdjacencyList.NodeID active_node = null;
		private List<AdjacencyList.NodeID> active_subtree = new List<AdjacencyList.NodeID>();

		public void InsertNode()
		{
			//
		}

		// TODO: API
	}
}
