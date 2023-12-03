using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clipper
{
	internal static class Program
	{
		/// <summary>
		/// Ponto de entrada principal para o aplicativo.
		/// </summary>
		[STAThread]
		static void Main()
		{
            using (Mutex mutex = new Mutex(true, "{F19EF532-E6D4-4085-8E9A-57120A4B0EF1}"))
            {
                if (mutex.WaitOne(TimeSpan.Zero, true))
                {
					Application.EnableVisualStyles();
					Application.SetCompatibleTextRenderingDefault(false);
					Application.Run(new MenuMainForm());
                }
				/*
                else
                {
                    MessageBox.Show("Another instance of the application is already running.", "Application Running", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
				// */
            }
		}
	}
}
