using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Spacepupupu
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Player player;
        PrintText printText;
        List<Enemy> enemies;


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
            player = new Player(Content.Load<Texture2D>("ship"), 380, 400, 40f, 40f);
            printText = new PrintText(Content.Load<SpriteFont>("myFont"));
            enemies = new List<Enemy>();
            Random random = new Random();
            Texture2D tmpSprite = Content.Load<Texture2D>("enemies/mine");
            for (int i = 0; i <12; i++)
            {
                int rndX = random.Next(0, Window.ClientBounds.Width - tmpSprite.Width);
                int rndY = random.Next(0, Window.ClientBounds.Height / 2);
                Enemy temp = new Enemy(tmpSprite, rndX, rndY);
                enemies.Add(temp);
            }

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
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();
            player.Update(Window);
            foreach (Enemy e in enemies.ToList())
            {
                if (e.IsAlive)
                    e.Update(Window);
                else
                    enemies.Remove(e);
            }

            base.Update(gameTime);

            foreach(Enemy e in enemies.ToList())
            {
                if (e.IsAlive)
                {
                    if (e.CheckCollision(player))
                        this.Exit();
                    e.Update(Window);
                }
                else enemies.Remove(e);
            }
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            spriteBatch.Begin();
            player.Draw(spriteBatch);
            printText.Print("Test," + enemies.Count, spriteBatch, 0, 0);
            foreach (Enemy e in enemies)
                e.Draw(spriteBatch);
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
