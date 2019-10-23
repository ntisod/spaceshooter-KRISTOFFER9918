using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace SpaceShooter
{
    class Player : MovingObject
    {

        int points = 0;




        public Player(Texture2D texture, float X, float Y, float speedX, float speedY) : base(texture, X, Y, speedX, speedY)
        {

        }

        public void Update(GameWindow window)
        {
            KeyboardState keyboardState = Keyboard.GetState();

            if (position.X <= window.ClientBounds.Width - gfx.Width && position.X >= 0)
            {
                if (keyboardState.IsKeyDown(Keys.Right))
                    position.X += speed.X;
                if (keyboardState.IsKeyDown(Keys.Left))
                    position.X -= speed.X;
            }

            if (position.Y <= window.ClientBounds.Height - gfx.Height && position.Y >= 0)
            {
                if (keyboardState.IsKeyDown(Keys.Down))
                    position.Y += speed.Y;
                if (keyboardState.IsKeyDown(Keys.Up))
                    position.Y -= speed.Y;

            }

            if (position.X < 0)
                position.X = 0;

            if (position.X > window.ClientBounds.Width - gfx.Width)
                position.X = window.ClientBounds.Width - gfx.Width;

            if (position.Y < 0)
                position.Y = 0;

            if (position.Y > window.ClientBounds.Height - gfx.Height)
                position.Y = window.ClientBounds.Height - gfx.Height;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(gfx, position, Color.White);
        }

        internal void Update(object window)
        {
            throw new NotImplementedException();
        }

    }
}

