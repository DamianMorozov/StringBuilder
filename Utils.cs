using System;
using System.IO;

namespace StringBuilder
{
	public static class Utils
	{
		public static DateTime DtStart { get; set; } = DateTime.Now;
		public static string Dir { get; set; } = string.Empty;
		public static DirectoryInfo DirInfo { get; set; } = null;
		public static long CountFiles { get; set; } = 0;
		public static long CountDirs { get; set; } = 0;
		public static long CountFilesFind { get; set; } = 0;

		public static string Str { get; set; }
		public static System.Text.StringBuilder StringBuilder { get; set; }
		public static System.Collections.ObjectModel.Collection<string> ColString { get; set; }

	}
}
