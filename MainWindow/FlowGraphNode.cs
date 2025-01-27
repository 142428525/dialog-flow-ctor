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

				private NodeID()
				{
				}

				public static NodeID GetID() => new NodeID();
			}

			interface INodeInfo
			{
				string Name { get; }

				Control Visualize();

				void SetData(dynamic _);
			}

			class NodeInfoStart : INodeInfo
			{
				public string Name => "start point";

				public Control Visualize()
				{
					throw new NotImplementedException();
				}

				public void SetData(dynamic _) => throw new NotImplementedException();
			}

			class NodeInfoEnd : INodeInfo
			{
				public string Name => "end point";

				public Control Visualize()
				{
					throw new NotImplementedException();
				}

				public void SetData(dynamic _) => throw new NotImplementedException();
			}

			class NodeInfoLinear : INodeInfo
			{
				private string dialogs = "";

				public string Name => "linear";

				public Control Visualize()
				{
					throw new NotImplementedException();
				}

				public void SetData(dynamic data)
				{
					if (!(data is string))
					{
						throw new InvalidCastException($"{nameof(data)} must be a {typeof(string)}");
					}

					dialogs = data;
				}
			}

			class NodeInfoSwitch : INodeInfo
			{
				private List<string> options = new List<string>();

				public string Name => "switch";

				public Control Visualize()
				{
					throw new NotImplementedException();
				}

				public void SetData(dynamic data)
				{
					if (!(data is List<string>))
					{
						throw new InvalidCastException($"{nameof(data)} must be a {typeof(List<string>)}");
					}

					options = data;
				}
			}
		}
	}
}
