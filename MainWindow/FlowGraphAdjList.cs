using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MainWindow
{
	namespace FlowGraph
	{
		internal class AdjacencyList<K, V> : IEnumerable<(K key, V val)>
		{
			private readonly Dictionary<K, HashSet<K>> edges = new Dictionary<K, HashSet<K>>();
			private readonly Dictionary<K, V> nodes = new Dictionary<K, V>();

			public int Count => nodes.Count;
			public K SingularityKey { get; } = default; // 不可撼动的基节点

			private AdjacencyList() { }

			public AdjacencyList((K key, V val) singularity)
			{
				edges.Add(singularity.key, new HashSet<K>());
				nodes.Add(singularity.key, singularity.val);
				SingularityKey = singularity.key;
			}

			// TODO: API

			public void Insert((K key, V val) new_node, K reference, InsertPos pos)
			{
				edges.Add(new_node.key, new HashSet<K>());
				nodes.Add(new_node.key, new_node.val);

				switch (pos)
				{
					case InsertPos.Afterward:
						edges[reference].Add(new_node.key);
						break;

					case InsertPos.Forward:
						foreach (var node_vecs in edges.Values)
						{
							if (node_vecs.Remove(reference))
							{
								node_vecs.Add(new_node.key);
							}
						}

						edges[new_node.key].Add(reference);
						break;

					default:
						throw new InvalidEnumArgumentException();
				}
			}

			public HashSet<K> GetSubtree(K base_node)
			{
				var ret = new HashSet<K>() { base_node };
				DFS(base_node);
				return ret;

				void DFS(K node)
				{
					var children = edges[node];
					if (children.Count() == 0)
					{
						ret.Add(node);
					}
					else
					{
						foreach (var child in children)
						{
							DFS(child);
						}
					}
				}
			}

			public IEnumerator<(K key, V val)> GetEnumerator()
			{
				return new AdjacencyListEnumerator<K, V>(edges, nodes, SingularityKey);
			}

			IEnumerator IEnumerable.GetEnumerator()
			{
				return GetEnumerator();
			}
		}

		internal class AdjacencyListEnumerator<K, V> : IEnumerator<(K, V)>
		{
			private readonly Dictionary<K, HashSet<K>> edges;
			private readonly Dictionary<K, V> nodes;
			private readonly K singularity_key;

			private bool invalid_it = true;
			private K it = default;   // iterator (for private use)
			private Queue<K> will_visit = new Queue<K>();
			private HashSet<K> visited = new HashSet<K>();

			public (K, V) Current
			{
				get
				{
					if (invalid_it)
					{
						throw new InvalidOperationException("The iterator hasn't been initialized.");
					}

					try
					{
						return (it, nodes[it]);
					}
					catch (Exception)
					{
						throw new InvalidOperationException("Invalid iterator position.");
					}
				}
			}

			object IEnumerator.Current => Current;

			private AdjacencyListEnumerator() { }

			public AdjacencyListEnumerator(Dictionary<K, HashSet<K>> edges,
				Dictionary<K, V> nodes, K singularity_key)
			{
				this.edges = edges;
				this.nodes = nodes;
				this.singularity_key = singularity_key;
			}

			public void Dispose()
			{
				//throw new NotImplementedException();
				// do nothing
			}

			public bool MoveNext()
			{
				if (invalid_it)
				{
					it = singularity_key;
					invalid_it = false;
					return true;
				}

				visited.Add(it);

				foreach (var node_vec in edges[it])
				{
					will_visit.Enqueue(node_vec);
				}

				if (will_visit.Count == 0)
				{
					it = default;
					return false;
				}

				it = will_visit.Dequeue();
				return true;
			}

			public void Reset()
			{
				invalid_it = true;
				it = default;
			}
		}

		internal enum InsertPos
		{
			[Description("后方")]
			Afterward,
			[Description("前方")]
			Forward
		}

		internal static class InsPosReflHelper
		{
			private static readonly Dictionary<InsertPos, string> refl_name =
				(from name in Enum.GetNames(typeof(InsertPos)) select name)
				.ToDictionary(name => (InsertPos)Enum.Parse(typeof(InsertPos), name));

			private static readonly Dictionary<InsertPos, string> refl_desp =
				(from name in refl_name.Values
				 select (name, desp: GetDescription(name)))
				.ToDictionary(tup => (from kv in refl_name
									  where kv.Value == tup.name
									  select kv.Key).Single(),
					tup => tup.desp);

			public static string[] GetDescriptions() => refl_desp.Values.ToArray();

			public static string GetDescription(string name)
			{
				var field = typeof(InsertPos).GetField(name);
				var attr = Attribute.GetCustomAttribute(field,
					typeof(DescriptionAttribute)) as DescriptionAttribute;
				return attr.Description;
			}

			public static InsertPos ParseDescription(string description) => (from kv in refl_desp
																			 where kv.Value == description
																			 select kv.Key).Single();
		}
	}
}
