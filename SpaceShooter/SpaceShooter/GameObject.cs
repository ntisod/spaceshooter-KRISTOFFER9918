using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace SpaceShooter
{
    class GameObject // GameObject, En bas klass för att kunna olika spelobjekt.
    {
        protected Texture2D gfx; //Rymdskeppets textur
        protected Vector2 position; // Rymdskeppets koordinater


        public GameObject(Texture2D texture, float X, float Y)
        {
            this.gfx = texture;
            this.position.X = X;
            this.position.Y = Y;
        }

        // Draw(), ritar ut bilden på skärmen

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(gfx, position, Color.White);
        }

        // Egenskaper för GameObject

        public float X { get { return position.X; } }
        public float Y { get { return position.Y; } }
        public float Width { get { return gfx.Width; } }
        public float Height { get { return gfx.Height; } }
    }

    //MovingObject, klass för objekt som rör sig

    abstract class MovingObject : GameObject
    {
        protected Vector2 speed; // Hastighet på objektet

        public MovingObject(Texture2D gfx, float X, float Y, float speedX, float speedY) : base(gfx, X, Y)

        {
            this.speed.X = speedX;
            this.speed.Y = speedY;

        }
    }
}
