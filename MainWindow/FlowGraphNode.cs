using MainWindow.FlowGraph.Nodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainWindow
{
	namespace FlowGraph
	{
		namespace Nodes
		{
			internal class NodeID
			{
				public long Value { get; } = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();

				private NodeID() { }

				public static NodeID New() => new NodeID();
			}

			internal abstract class NodeInfoBase
			{
				protected dynamic storage;

				public abstract string Name { get; }

				public abstract void SetData(object value);

				public abstract Control Visualize();
			}

			internal abstract class NodeInfoBaseGeneric<T> : NodeInfoBase
			{
				protected abstract Control visualize_impl(T _);

				public sealed override void SetData(object value)
				{
					if (!(value is T))
					{
						throw new InvalidCastException($"The argument type '{value.GetType()}' " +
							$"doesn't match the storage type '{typeof(T)}'.");
					}

					storage = value;
				}

				public sealed override Control Visualize() => visualize_impl(storage);
			}

			internal abstract class NodeInfoBaseVoid : NodeInfoBase
			{
				public sealed override void SetData(object _)
				{
					throw new NotSupportedException("This type of node doesn't store data.");
				}

				public sealed override Control Visualize() => null;
			}

			internal class NodeInfoStart : NodeInfoBaseVoid
			{
				public override string Name => "起点";
			}

			internal class NodeInfoEnd : NodeInfoBaseGeneric<string>
			{
				public override string Name => "终点";

				protected override Control visualize_impl(string _)
				{
					return new Label() { Text = _ };
				}
			}

			internal class NodeInfoLinear : NodeInfoBaseGeneric<string>
			{
				public override string Name => "线性对话";

				protected override Control visualize_impl(string _)
				{
					throw new NotImplementedException();
				}
			}

			internal class NodeInfoSwitch : NodeInfoBaseGeneric<List<string>>
			{
				public override string Name => "选择支";

				protected override Control visualize_impl(List<string> _)
				{
					throw new NotImplementedException();
				}
			}

			internal class NodeInfoSwitchHidden : NodeInfoBaseGeneric<System.Collections.ArrayList>
			{
				public override string Name => "条件支";

				protected override Control visualize_impl(System.Collections.ArrayList _)
				{
					throw new NotImplementedException();
				}
			}
		}

		internal static class NodeReflHelper
		{
			private static readonly Dictionary<Type, NodeInfoBase> refl =
				(from T in typeof(NodeInfoBase).Assembly.GetTypes()
				 where !T.IsAbstract && T.IsSubclassOf(typeof(NodeInfoBase))
				 select (Activator.CreateInstance(T) as NodeInfoBase))
				.ToDictionary(item => item.GetType());

			public static string[] GetNodeTypeNames() => (from item in refl.Values
														  select item.Name).ToArray();

			public static Type ParseName(string name) => (from item in refl.Values
														  where item.Name == name
														  select item.GetType()).Single();

			public static bool Exists(Type t) => refl.ContainsKey(t);
		}

		internal struct Node
		{
			public NodeID ID { get; }
			public NodeInfoBase Info { get; }

			public Node(NodeID nodeID, NodeInfoBase nodeInfo) : this()
			{
				ID = nodeID;
				Info = nodeInfo;
			}

			//public Node((NodeID key, NodeInfoBase val) tup) : this()
			//{
			//	ID = tup.key;
			//	Info = tup.val;
			//}

			public void Deconstruct(out NodeID key, out NodeInfoBase val)
			{
				key = ID;
				val = Info;
			}

			public (NodeID key, NodeInfoBase val) GetTuple() => (ID, Info);

			public override string ToString()
			{
				return $"{Info.Name}#{ID.Value}";
			}
		}
	}
}
