using Microsoft.VisualBasic.Logging;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileSplitter
{
	/// <summary>
	/// Class that splist text files respecting the endline character
	/// </summary>
	public class TextFileSplitter
	{
		long targetSize = 0;
		string filePath = "";
		StringBuilder content = new();
		Logger log;

		public TextFileSplitter(Logger log)
		{
			this.log = log;
		}

		/// <summary>
		///  Split file
		/// </summary>
		/// 
		/// <param name="filePath">Absolute path to the file</param>
		/// 
		/// <param name="partsOrTargetSize">
		///		<para>if <paramref name="isParts"/> is false contains the target size of files in Bytes</para>
		///		<para>else contains number of parts the target file is supposed to be split into</para>
		/// </param>
		/// 
		/// <param name="isParts">
		///		<para>if <paramref name="isParts"/> is false the file will be split into fixed size chunks (respecting  the endline character)</para>
		///		<para>else the file will be split into the given number of  almost equal size files (respecting  the endline character)</para>
		/// </param></param>
		public void Split(string filePath, long partsOrTargetSize = 1, bool isParts = false)
		{
			this.filePath = filePath;

			log.Clear();
			if (isParts)
				SplitIntoParts((int)partsOrTargetSize);
			else
			{
				targetSize = partsOrTargetSize;
				SplitFixedSize();
			}
		}

		private void SplitIntoParts(int numberOfParts)
		{
			using (StreamReader streamReader = new(filePath))
			{
				// Get the total size of the file
				streamReader.BaseStream.Seek(0, SeekOrigin.End);
				var end = streamReader.BaseStream.Position;
				streamReader.BaseStream.Seek(0, SeekOrigin.Begin);

				// Get how large a part is supposed to be
				var sizeofParts = (long)Math.Ceiling(end / (float)numberOfParts);

				StreamWriter streamWriter;

				log.Log($"Creating {numberOfParts} files");

				string extension = Path.GetExtension(filePath);
				string strippedfilePath = filePath.Split(extension)[0];

				// Split the file into the provided number of parts
				for (int i = 1; i <= numberOfParts; i++)
				{
					var fileName = strippedfilePath + "_" + i + extension;

					var fileSize = 0;

					streamWriter = new(fileName);

					// Read until we reach the target size of a part and save the result into a separate file
					for (int j = 0; streamReader.BaseStream.Position <= i * sizeofParts; j++)
					{
						var a = streamReader.ReadLine();
						if (a is null) break;
						fileSize += a.Length * sizeof(char);
						content.AppendLine(a);
					}
					streamWriter.Write(content);

					content.Clear();

					streamWriter.Close();
					log.UpdateLogWithCreatedFile(fileName, fileSize);
				}



			}
		}

		private void SplitFixedSize()
		{
			long memoryusage = 0;
			using (StreamReader streamReader = new(filePath))
			{

				StreamWriter streamWriter;

				var extension = Path.GetExtension(filePath);
				string strippedfilePath = filePath.Split(extension)[0];

				// Split the file into fixed size files, the size depending on the "targetSize" variable
				for (int i = 1; !streamReader.EndOfStream && i < 1000; i++)
				{
					
					var fileName = strippedfilePath +"_" + i + extension;

					var fileSize = 0;

					streamWriter = new(fileName);

					// Read until we've reached or surpased the target size and put the result into a separate file
					for (int j = 0; memoryusage <= targetSize * 2 && !streamReader.EndOfStream; j++)
					{
						var a = streamReader.ReadLine();
						if (a is null) break;
						fileSize += a.Length * sizeof(char);
						memoryusage += a.Length * sizeof(char);
						content.AppendLine(a);

					}
					streamWriter.Write(content);

					content.Clear();

					memoryusage = 0;
					streamWriter.Close();

					log.UpdateLogWithCreatedFile(fileName, fileSize);
				}

			}
		}
	}
		
}
