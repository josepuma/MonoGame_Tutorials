﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Tutorial025.Sprites
{
  public class Sprite : Component
  {
    protected Texture2D _texture;

    public Vector2 Position;

    public Sprite(Texture2D texture)
    {
      _texture = texture;
    }

    public override void Update(GameTime gameTime)
    {

    }

    public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
    {
      spriteBatch.Draw(_texture, Position, Color.White);
    }
  }
}
