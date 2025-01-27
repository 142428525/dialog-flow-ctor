using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MainWindow
{
	internal partial class FlowGraph
	{
		private partial class AdjacencyList
		{


			//struct NodeInfo
			//{
			//	// TODO

			//	public INodeType NodeType;
			//	public object Data;

			//	public enum NodeTypeEnum
			//	{
			//		Start,
			//		End,
			//		Linear,
			//		Switch
			//	}

			//	public Control Visualize()
			//	{
			//		return NodeType.Visualize();
			//	}

			//	//public static Dictionary<NodeTypeEnum, INodeType> NodeTypeRefl =
			//	//	new Dictionary<NodeTypeEnum, INodeType>
			//	//	{
			//	//		{ NodeTypeEnum.Start, typeof(NodeTypeStart)}
			//	//	};

			//	//public enum NodeAction
			//	//{
			//	//	Empty,

			//	//}
			//}

			//interface INodeType
			//{
			//	string Name { get; }
			//	//Type DataType { get; }

			//	Control Visualize();
			//}

			//class NodeTypeStart : INodeType
			//{
			//	public string Name => "start point";
			//	//public Type DataType => typeof(string);

			//	public Control Visualize()
			//	{
			//		throw new NotImplementedException();
			//	}
			//}

			//class NodeTypeLinear : INodeType
			//{
			//	public string Name => "linear";
			//	//public Type DataType => typeof(List<string>);

			//	public Control Visualize()
			//	{
			//		throw new NotImplementedException();
			//	}
			//}



			Dictionary<NodeID, List<NodeID>> edges = new Dictionary<NodeID, List<NodeID>>();
			Dictionary<NodeID, INodeInfo> nodes = new Dictionary<NodeID, INodeInfo>();

			//Type GetNodeDataType(NodeID id)
			//{
			//	return nodes[id].NodeType.DataType;
			//}


			public static string[] GetNodeTypeNames() => (from T in Assembly.GetExecutingAssembly().GetTypes()
														  where T.GetInterfaces().Contains(typeof(INodeInfo))
														  select (T as INodeInfo).Name).ToArray();
		}

		AdjacencyList graph = new AdjacencyList();

		public static string[] GetNodeTypeNames() => AdjacencyList.GetNodeTypeNames();  // 转发调用
	}
}
