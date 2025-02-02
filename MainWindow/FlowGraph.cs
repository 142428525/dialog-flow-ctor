using MainWindow.FlowGraph.Nodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainWindow
{
	namespace FlowGraph
	{
		internal class SceneGraph
		{
			internal AdjacencyList<NodeID, NodeInfoBase> Graph { get; private set; } =
				new AdjacencyList<NodeID, NodeInfoBase>((NodeID.New(), new NodeInfoStart()));

			public int NodeCount => Graph.Count;

			internal HashSet<NodeID> ActiveNodes { get; private set; } = new HashSet<NodeID>();

			public SceneGraph()
			{
				//
				ActiveNodes.Add(Graph.SingularityKey);
				//
			}

			// TODO: API

			public void Activate(NodeID node, bool recursive = false)
			{
				if (!recursive)
				{
					ActiveNodes = new HashSet<NodeID>() { node };
				}
				else
				{
					ActiveNodes = Graph.GetSubtree(node);
				}
			}

			public void InsertNode(Type t, InsertPos pos)
			{
				if (!NodeReflHelper.Exists(t))
				{
					throw new ArgumentOutOfRangeException($"Type '{t}' is not a valid node type.");
				}

				if (ActiveNodes.Count > 1)
				{
					throw new InvalidOperationException("Unable to insert when a subtree is selected.");
				}

				Graph.Insert((NodeID.New(), Activator.CreateInstance(t) as NodeInfoBase),
					ActiveNodes.Single(), pos);
			}

			public void ForEach(Action<Node> lambda)
			{
				foreach (var (k, v) in Graph)
				{
					lambda(new Node(k, v));
				}
			}

			public void ForEach(Action<int, Node> lambda)
			{
				var idx = 0;
				foreach (var (k, v) in Graph)
				{
					lambda(idx, new Node(k, v));
					idx++;
				}
			}
		}
	}
}
