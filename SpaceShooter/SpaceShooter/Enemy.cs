using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceShooter
{
    class Enemy : MovingObject
    {
        // För att hålla koll på om fienden lever eller inte
        bool isAlive = true;

        public Enemy(Texture2D texture, float X, float Y) : base(texture, X, Y, 6f, 0.3f)
        {

        }
        // update(), uppdaterar fiendes position
        public void Update(GameWindow window)
        {
            // Flytta på fienden
            position.X += speed.X;
            // Kontrollera så den inte åker utanför fönstret på sidorna                   // Byt riktning på fienden
            if (position.X > window.ClientBounds.Width - gfx.Width || position.X < 0) speed.X *= -1; position.Y += speed.Y;
            // Gör fienden inaktiv om den åker ut där nere
            if (position.Y > window.ClientBounds.Height) isAlive = false;
        }

        // Egenskaper för Enemy

        public bool IsAlive
        {
            get { return isAlive; }
            set { isAlive = value; }
        }
    }
}
