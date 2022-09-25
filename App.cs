using SFML.Graphics;
using SFML.Window;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matuatl
{
    internal class App
    {
        public void Run()
        {
            var window = new RenderWindow(VideoMode.FullscreenModes[0], "Matuatl");

            Font font = new Font("Montserrat-Medium.ttf");
            var text = new Text("Esto es una prueba", font, 40);
            window.KeyPressed += Window_KeyPressed;

            while (window.IsOpen)
            {
                window.DispatchEvents();
                window.Draw(text);
                window.Display();
            }
        }

        private void Window_KeyPressed(object sender, SFML.Window.KeyEventArgs e)
        {
            var window = (Window)sender;
            if (e.Code == SFML.Window.Keyboard.Key.Escape)
            {
                window.Close();
            }
        }
    }
}
