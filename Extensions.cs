using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSplitter
{
	public static class Extensions
	{
		/// <summary>
		///		<para>Logger extension</para>
		///		<para>	Logs the following string "Created \t <paramref name="filePath"/>  added \t Size: " <paramref name="fileSize"/> B"</para>
		/// </summary>
		/// 
		/// <param name="filePath">Absolute path to the file</param>
		/// <param name="fileSize">Size of the file in Bytes</param>
		public static void UpdateLogWithCreatedFile(this Logger l, string filePath, int fileSize)
		{
			l.Log("Created \t" + filePath + " added \t Size: " + fileSize/2 + " B");
		}
		
	}
}
