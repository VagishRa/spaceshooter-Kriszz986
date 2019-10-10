using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Spacepupupu
{
    /*
    class GameObject
    {
        protected Texture2D texture;
        protected Vector2 vector;

        public GameObject(Texture2D texture, float X, float Y)
        {
            this.texture = texture;
            this.vector.X = X;
            this.vector.Y = Y;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, vector, Color.White);
        }
    }*/

    class Player
    {
        Texture2D gfx; //rymdskeppet grafik
        Vector2 pos; //rymdskeppet position
        Vector2 speed;

        public Player(Texture2D gfx, float X, float Y, float speedX, float speedY)
        {
            this.gfx = gfx;
            this.pos.X = X;
            this.pos.Y = Y;
            this.speed.X = X;
            this.speed.Y = Y;
        }
        public void Update(GameWindow window)
        {
            KeyboardState keyboardState = Keyboard.GetState();

            if (pos.X <= window.ClientBounds.Width - gfx.Width && pos.X >= 0)
            {
                if (keyboardState.IsKeyDown(Keys.Right))
                    pos.X += speed.X;
                if (keyboardState.IsKeyDown(Keys.Left))
                    pos.X -= speed.X;
            }
            if (pos.Y <= window.ClientBounds.Height - gfx.Height && pos.Y >= 0)
            {
                if (keyboardState.IsKeyDown(Keys.Right))
                    pos.Y += speed.Y;
                if (keyboardState.IsKeyDown(Keys.Left))
                    pos.Y -= speed.Y;
            }
            if (pos.X < 0)
                pos.X = 0;
            if (pos.X > window.ClientBounds.Width - gfx.Width)
            {
                pos.X
            }

        }
    }
}