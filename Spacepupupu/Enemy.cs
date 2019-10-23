using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace Spacepupupu
{
    class Enemy: PhysicalObject
    {

        public Enemy(Texture2D gfx, float X, float Y ) : base(gfx, X, Y, 6f, 0.3f)
        {
        }
        public void Update(GameWindow window)
        {
            pos.X += speed.X;
            if (pos.X > window.ClientBounds.Width - gfx.Width || pos.X < 0)
                speed.X *= -1;
            pos.Y += speed.Y;
            if (pos.Y > window.ClientBounds.Height)
                isAlive = false;
        }
    }
}
