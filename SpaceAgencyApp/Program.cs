using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceAgencyApp
{
	internal static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.SetCompatibleTextRenderingDefault(false);

			LoginForm loginForm = new LoginForm(); // Միայն սահմանում ենք

			if (loginForm.ShowDialog() == DialogResult.OK) // Այստեղ ենք ցույց տալիս
			{
				Application.Run(new Form1());
			}
			// ԱՅՍՏԵՂ ԱՎԱՐՏՎՈՒՄ Է
		}
	}
}
