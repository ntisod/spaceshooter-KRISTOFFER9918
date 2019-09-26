﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace SpaceShooter
{
    /// <summary>
    /// This is the main type for your game.
    ///
    /// Kristoffer Barsum Te17 i kursen programmerring 2 2019-9-25
    ///
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        // mina variabler:

        Texture2D ship_texture;  // skeppets grafik
        Vector2 ship_vector;     //skeppets position
        Vector2 ship_speed; //rymdskeppets hastighet

        public Game1()

        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            //skeppets startposition
            ship_vector.X = 380;
            ship_vector.Y = 400;
  

            //skeppets starthastighet
            ship_speed.X = -2.5f;
            ship_speed.Y = -4.5f;

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            ship_texture = Content.Load<Texture2D>("ship");

        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            //Tangentbordstyrning
            KeyboardState keyboardsate = Keyboard.GetState();
     
      


            //skeppets förflyttning
            ship_vector.X += ship_speed.X;

            //förhindra skeppet att åka utanför sidkanterna
            if(ship_vector.X < 0 || ship_vector.X > Window.ClientBounds.Width-ship_texture.Width)
            {
                ship_speed.X = ship_speed.X * -1;
            }

            ship_vector.Y += ship_speed.Y;
            //förhindrar skeppet att åka utanför över- och underkanterna
            if(ship_vector.Y < 0 || ship_vector.Y>Window.ClientBounds.Height-ship_texture.Height)
            {
                ship_speed.Y = ship_speed.Y * -1;
            }



            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);

            // TODO: Add your drawing code here

            spriteBatch.Begin();
            spriteBatch.Draw(ship_texture, ship_vector, Color.White);
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}