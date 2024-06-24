using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSplitter
{
	/// <summary>
	///  Provides basic logging functionality using a Winforms TextBox
	/// </summary>
	public class Logger
	{
		private TextBox logTextBox;

		public Logger(TextBox log)
		{
			logTextBox = log;
		}

		public void Clear()
		{
			logTextBox.Clear();
		}
		/// <summary>
		/// Logs a line of text
		/// </summary>
		/// <param name="message">text to be logged</param>
		public void Log(string message)
		{
			logTextBox.Text += message + "\r\n";
		}
	}
}
