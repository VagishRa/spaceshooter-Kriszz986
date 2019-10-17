using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Spacepupupu
{
    class Player:GameObject
    {
        Vector2 speed;

        public Player(Texture2D gfx, float X, float Y, float speedX, float speedY):base(gfx,X,Y)
        {
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