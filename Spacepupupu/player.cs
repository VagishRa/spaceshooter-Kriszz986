using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Spacepupupu
{
    class Player: PhysicalObject
    {
        int points = 0;

        public Player(Texture2D gfx, float X, float Y, float speedX, float speedY): base(gfx,X,Y, speedX, speedY)
        {
        }
        public void Update(GameWindow window)
        {
            KeyboardState keyboardState = Keyboard.GetState();

            if (pos.X <= window.ClientBounds.Width - gfx.Width && pos.X >= 0)
            {
                if (keyboardState.IsKeyDown(Keys.Right)|| keyboardState.IsKeyDown(Keys.D))
                    pos.X += speed.X;
                if (keyboardState.IsKeyDown(Keys.Left)|| keyboardState.IsKeyDown(Keys.A))
                    pos.X -= speed.X;
            }
            if(pos.Y <= window.ClientBounds.Height - gfx.Height && pos.Y >= 0)
            {
                if (keyboardState.IsKeyDown(Keys.Down)|| keyboardState.IsKeyDown(Keys.S))
                    pos.Y += speed.Y;
                if (keyboardState.IsKeyDown(Keys.Up) || keyboardState.IsKeyDown(Keys.W))
                    pos.Y -= speed.Y;
            }
            if (pos.X < 0)
                pos.X = 0;
            if (pos.X > window.ClientBounds.Width - gfx.Width)
                pos.X = window.ClientBounds.Width - gfx.Width;
            if (pos.Y < 0)
                pos.Y = 0;
            if (pos.Y > window.ClientBounds.Height - gfx.Height)
                pos.Y = window.ClientBounds.Height - gfx.Height;
        }
    }
}