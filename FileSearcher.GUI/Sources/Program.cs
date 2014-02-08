﻿// Mike Bardynin [mikebardynin@gmail.com]

using System;
using System.Windows.Forms;

using FileSearcher.GUI.View;

namespace FileSearcher.GUI
{
	internal static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[ STAThread ]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault( false );
			Application.Run( new MainView() );
		}
	}
}