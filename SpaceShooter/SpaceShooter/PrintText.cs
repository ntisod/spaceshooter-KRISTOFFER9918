using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace SpaceShooter
{
    class PrintText
    {
        SpriteFont font;

        public PrintText(SpriteFont font)
        {
            this.font = font;
        }
        // print(), skriv ut texten på skärmen

        public void Print(string text, SpriteBatch spriteBatch, int X, int Y)
        {
            spriteBatch.DrawString(font, text, new Vector2(X, Y), Color.White);
        }
    }
}
