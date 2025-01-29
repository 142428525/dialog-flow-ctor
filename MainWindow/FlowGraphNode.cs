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
				protected dynamic storage;

				public abstract string Name { get; }

				public abstract void SetData(object value);

				public abstract Control Visualize();
			}

			private abstract class NodeInfoBaseGeneric<T> : NodeInfoBase
			{
				private readonly Type t = typeof(T);

				public override void SetData(object value)
				{
					if (value.GetType() != t)
					{
						throw new InvalidCastException($"The type of {nameof(value)} '{value.GetType()}' " +
							$"doesn't match the storage type '{t}'.");
					}

					storage = value;
				}
			}

			private abstract class NodeInfoBaseVoid : NodeInfoBase
			{
				sealed public override Control Visualize() => new Label() { Text = "(empty)" };

				sealed public override void SetData(object _)
				{
					throw new NotSupportedException("This type of node doesn't store data.");
				}
			}

			private class NodeInfoStart : NodeInfoBaseVoid
			{
				public override string Name => "起点";
			}

			private class NodeInfoEnd : NodeInfoBaseGeneric<string>
			{
				public override string Name => "终点";

				public override Control Visualize()
				{
					throw new NotImplementedException();
				}
			}

			private class NodeInfoLinear : NodeInfoBaseGeneric<string>
			{
				public override string Name => "线性对话";

				public override Control Visualize()
				{
					throw new NotImplementedException();
				}
			}

			private class NodeInfoSwitch : NodeInfoBaseGeneric<List<string>>
			{
				public override string Name => "选择支";

				public override Control Visualize()
				{
					throw new NotImplementedException();
				}
			}

			private class NodeInfoSwitchHidden : NodeInfoBaseGeneric<System.Collections.ArrayList>
			{
				public override string Name => "隐藏线";

				public override Control Visualize()
				{
					throw new NotImplementedException();
				}
			}

			private static readonly Dictionary<Type, NodeInfoBase> refl =
				(from T in typeof(NodeInfoBase).Assembly.GetTypes()
				 where !T.IsAbstract && T.IsSubclassOf(typeof(NodeInfoBase))
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
