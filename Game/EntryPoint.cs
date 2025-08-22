using System;
using Engine.Render;
using System.Windows.Forms;

class Program
{
	[STAThread]
	static void Main()
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		
		// Create and run the game window
		GameWindow gameWindow = new GameWindow();
		Application.Run(gameWindow);
	}
}
