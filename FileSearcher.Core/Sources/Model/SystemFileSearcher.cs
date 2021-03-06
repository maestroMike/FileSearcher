﻿using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.IO;

using FileSearcher.Common;
using FileSearcher.Common.Model;
using FileSearcher.Core.Model.FileWrapper;

namespace FileSearcher.Core.Model
{
	public class SystemFileSearcher : IFileSearcher
	{
		public IEnumerable<IFileInfo> GetFiles( FileSearchSettings settings )
		{
			Contract.Requires<ArgumentException>( Directory.Exists( settings.Path ), "Directory not exist." );

			var directoryInfo = new DirectoryInfo( settings.Path );
			foreach( var fileInfo in directoryInfo.EnumerateFiles( GetSearchPattern( settings ), GetSearchOption( settings ) ) ) {
				yield return new FileInfoWrapper( fileInfo );
			}
		}

		private static SearchOption GetSearchOption( FileSearchSettings settings )
		{
			return settings.IncludeSubDirectories
				? SearchOption.AllDirectories
				: SearchOption.TopDirectoryOnly;
		}

		private static string GetSearchPattern( FileSearchSettings settings )
		{
			return "*." + settings.FileExtension.ToLower();
		}
	}
}