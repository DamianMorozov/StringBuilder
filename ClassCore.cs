using System;
using System.IO;
using System.Windows.Forms;

namespace StringBuilder
{
	public class ClassCore<T>
	{
		private enum EnumType { unknown, str, strBuilder, strCollection }
		private RichTextBox _richTextBoxOut;

		private void Init(ref RichTextBox richTextBoxOut)
		{
			Utils.CountFiles = 0;
			Utils.CountDirs = 0;
			Utils.CountFilesFind = 0;
			Utils.DtStart = DateTime.Now;
			Utils.Str = string.Empty;
			Utils.StringBuilder = new System.Text.StringBuilder();
			Utils.ColString = new System.Collections.ObjectModel.Collection<string>();

			_richTextBoxOut = richTextBoxOut;
		}

		private EnumType GetSelfType()
		{
			var result = EnumType.unknown;
			if (typeof(T) == typeof(string))
				result = EnumType.str;
			if (typeof(T) == typeof(System.Text.StringBuilder))
				result = EnumType.strBuilder;
			if (typeof(T) == typeof(System.Collections.ObjectModel.Collection<string>))
				result = EnumType.strCollection;
			return result;
		}

		public ClassCore(ref RichTextBox richTextBoxOut, bool isIncludeDir, bool isCountNames, string fileMask)
		{
			Init(ref richTextBoxOut);

			var clType = GetSelfType();
			SearchFilesInDir(ref isIncludeDir, ref clType, ref isCountNames, ref fileMask, Utils.Dir);
		}

		private void SearchFilesInDir(ref bool isIncludeDir, ref EnumType clType, ref bool isCountNames, ref string fileMask,
			string dir)
		{
			try
			{
				foreach (string dirName in Directory.GetDirectories(dir))
				{
					foreach (string fileName in Directory.GetFiles(dir))
					{
						if (clType == EnumType.str)
							Utils.Str += fileName + Environment.NewLine;
						if (clType == EnumType.strBuilder)
							Utils.StringBuilder.Append(fileName + Environment.NewLine);
						if (clType == EnumType.strCollection)
							Utils.ColString.Add(fileName);

						Utils.CountFiles++;
						if (isCountNames && fileName.Contains(fileMask))
							Utils.CountFilesFind++;
					}

					if (isIncludeDir)
					{
						Utils.CountDirs++;
						SearchFilesInDir(ref isIncludeDir, ref clType, ref isCountNames, ref fileMask, dirName);
					}
					else
						break;
				}
			}
			catch (Exception exception)
			{
				_richTextBoxOut.AppendText(exception.Message + Environment.NewLine);
			}
		}

		private void SearchFilesInDirRecurse(string dir, ref EnumType clType, ref bool isCountNames, ref string fileMask)
		{
			try
			{
				foreach (string dirName in Directory.GetDirectories(dir))
				{
					foreach (string fileName in Directory.GetFiles(dirName))
					{
						if (clType == EnumType.str)
							Utils.Str += fileName + Environment.NewLine;
						if (clType == EnumType.strBuilder)
							Utils.StringBuilder.Append(fileName + Environment.NewLine);
						if (clType == EnumType.strCollection)
							Utils.ColString.Add(fileName);

						Utils.CountFiles++;
						if (isCountNames && fileName.Contains(fileMask))
							Utils.CountFilesFind++;
					}
					SearchFilesInDirRecurse(dirName, ref clType, ref isCountNames, ref fileMask);
				}
			}
			catch (Exception exception)
			{
				_richTextBoxOut.AppendText(exception.Message + Environment.NewLine);
			}
		}
	}
}
