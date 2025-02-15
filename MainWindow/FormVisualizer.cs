using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainWindow
{
	public partial class FormVisualizer : Form
	{
		private static class TitleHelper
		{
			public static string Generate(string name)
			{
				return $"节点内容（{name}）";
			}
		}

		private FormVisualizer()
		{
			InitializeComponent();

			// NOTE: 窗体标题会动态变化
		}

		public FormVisualizer(Control c, string name) : this()
		{
			// assert that c != null
			propertyGrid.SelectedObject = c;

			Text = TitleHelper.Generate(name);
		}
	}
}
