using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainWindow
{
	internal partial class FlowGraph
	{
		private partial class AdjacencyList
		{
			public class NodeID
			{
				public long Value { get; } = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();

				private NodeID() { }

				public static NodeID GetID() => new NodeID();
			}

			private abstract class NodeInfoBase
			{
				public abstract string Name { get; }

				public abstract Control Visualize();

				public abstract void SetData(dynamic _);
			}

			class NodeInfoStart : NodeInfoBase
			{
				public override string Name => "起点";

				public override Control Visualize()
				{
					throw new NotImplementedException();
				}

				[Obsolete("This type of node doesn't store data.")]
#pragma warning disable CS0809 // 过时成员重写未过时成员
				public override void SetData(dynamic _) => throw new NotImplementedException();
#pragma warning restore CS0809 // 过时成员重写未过时成员
			}

			class NodeInfoEnd : NodeInfoBase
			{
				public override string Name => "终点";
				//?

				public override Control Visualize()
				{
					throw new NotImplementedException();
				}

				public override void SetData(dynamic reserved) => throw new NotImplementedException();
			}

			class NodeInfoLinear : NodeInfoBase
			{
				private string dialogs = "";

				public override string Name => "线性";

				public override Control Visualize()
				{
					throw new NotImplementedException();
				}

				public override void SetData(dynamic data)
				{
					if (!(data is string))
					{
						throw new InvalidCastException($"{nameof(data)} must be a {typeof(string)}");
					}

					dialogs = data;
				}
			}

			class NodeInfoSwitch : NodeInfoBase
			{
				private List<string> options = new List<string>();

				public override string Name => "选择支";

				public override Control Visualize()
				{
					throw new NotImplementedException();
				}

				public override void SetData(dynamic data)
				{
					if (!(data is List<string>))
					{
						throw new InvalidCastException($"{nameof(data)} must be a {typeof(List<string>)}");
					}

					options = data;
				}
			}

			private static readonly Dictionary<Type, NodeInfoBase> refl =
				(from T in typeof(NodeInfoBase).Assembly.GetTypes()
				 where T.IsSubclassOf(typeof(NodeInfoBase))
				 select Activator.CreateInstance(T) as NodeInfoBase)
				.ToDictionary(item => item.GetType());

			public static string[] GetNodeTypeNames() => (from item in refl.Values
														  select item.Name).ToArray();

			public static Type GetNodeType(string name) => (from item in refl.Values
															where item.Name == name
															select item.GetType()).Single();
		}

		public static string[] GetNodeTypeNames() => AdjacencyList.GetNodeTypeNames();  // 转发调用

		public static Type GetNodeType(string name) => AdjacencyList.GetNodeType(name); // 转发调用
	}
}
