using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SFML.Audio;
using SFML.Graphics;
using SFML.Window;
using SFML.System;


namespace Matuatl.States
{
    internal class MenuButton : IMenuButton
    {
        public List<Sprite> Sprites { get; set; }
        public ButtonState State { get; set; }
        public Texture Texture { get; set; }
        public Vector2f Position { get; set; }

        public MenuButton(Texture texture)
        {
            Sprites = new List<Sprite>();
            State = ButtonState.NORMAL;
            Texture = texture;
        }

        public MenuButton()
        {
            Sprites = new List<Sprite>();
        }

        public void AddSprite(IntRect intRect, ButtonState state)
        {
            Sprite sprite = new Sprite();
            sprite.Texture = Texture;
            sprite.TextureRect = intRect;
            Sprites.Add(sprite);
        }

        public void Draw(RenderWindow window)
        {
            Sprite currentSprite = Sprites[(int)State]; // Check this
            currentSprite.Position = Position;

            if (IsHoovered(window))
            {
                State = ButtonState.PRESSED;

            }
            else
            {
                State = ButtonState.NORMAL;
            }

            window.Draw(currentSprite);
        }

        public bool IsClicked(RenderWindow window)
        {
            bool mousePressed = Mouse.IsButtonPressed(Mouse.Button.Left);
            return mousePressed && IsHoovered(window);
        }

        public void SetPosition(Vector2f position) => Position = position;


        public bool IsHoovered(RenderWindow window)
        {
            Sprite currentSprite = Sprites.ElementAt((int)State); // Check this
            currentSprite.Position = Position;

            FloatRect spriteRect = currentSprite.GetGlobalBounds();
            Vector2f mousePos = window.MapPixelToCoords(Mouse.GetPosition(window));

            return spriteRect.Contains(mousePos.X, mousePos.Y);
        }
    }
}
