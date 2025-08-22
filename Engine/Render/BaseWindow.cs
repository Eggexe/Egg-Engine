using System; 
using System.Drawing;
using System.Windows.Forms;

namespace Engine.Render
{
    public class GameWindow : Form
    {
        public GameWindow()
        {
            this.Text = "Game Window";
            this.ClientSize = new Size(800, 600);
            this.DoubleBuffered = true; // Enable double buffering to reduce flickering
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            // Custom rendering logic can be added here
            e.Graphics.Clear(Color.Black); // Clear the window with a black color
        }
    }
}