using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIOClassLibrary
{
	public class DialogFile : IDisposable
	{
		private readonly StreamWriter fs = null;
		private bool disposed_value;    // has been disposed?

		public DialogFile(string path_p)
		{
			fs = new StreamWriter(path_p, true, Encoding.UTF8);
		}

		// TODO: Lib API

		protected virtual void Dispose(bool disposing)
		{
			if (disposed_value)
			{
				return;
			}

			if (disposing)
			{
				// TODO: 释放托管状态(托管对象)
			}

			// TODO: 释放未托管的资源(未托管的对象)并重写终结器
			// TODO: 将大型字段设置为 null
			disposed_value = true;
		}

		// // TODO: 仅当“Dispose(bool disposing)”拥有用于释放未托管资源的代码时才替代终结器
		// ~DialogFile()
		// {
		//     // 不要更改此代码。请将清理代码放入“Dispose(bool disposing)”方法中
		//     Dispose(disposing: false);
		// }

		public void Dispose()
		{
			// 不要更改此代码。请将清理代码放入“Dispose(bool disposing)”方法中
			Dispose(disposing: true);
			GC.SuppressFinalize(this);
		}
	}
}
