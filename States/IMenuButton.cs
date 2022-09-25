using SFML.Graphics;
using SFML.System;
using SFML.Window;
using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matuatl.States
{
    internal interface IMenuButton
    {
        // Private
        const int NR_OF_STATES = 2;
        List<Sprite> Sprites { get; set; }
        ButtonState State { get; set; }
        Texture Texture { get; set; }
        Vector2f Position { get; set; }
        bool IsHoovered(RenderWindow window);

        // Public
        void AddSprite(IntRect intRet, ButtonState state);
        void Draw(RenderWindow window);
        bool IsClicked(RenderWindow window);
        void SetPosition(Vector2f position);
    }
}
