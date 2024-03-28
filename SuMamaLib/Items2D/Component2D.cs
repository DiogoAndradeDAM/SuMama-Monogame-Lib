using System;
using Microsoft.Xna.Framework;

using SuMamaLib.Items2D.Sprites;
using SuMamaLib.Base;

namespace SuMamaLib.Items2D.Component
{
	public class Component2D : IGameComponent, IUpdateable, IDrawable, IDisposable 
	{

		public Sprite Sprite { get; private set; }
		public Vector2 Position { get; set; }
		public Rectangle Body { get; private set; }
		public float Depth { get; private set; }

        public bool Enabled => throw new NotImplementedException();

        public int UpdateOrder => throw new NotImplementedException();

        public int DrawOrder => throw new NotImplementedException();

        public bool Visible => throw new NotImplementedException();

        public Component2D(Sprite sprite)
		{
			this.Sprite = sprite;
			this.Position = new Vector2(0, 0);
			this.Body = Globals.RectBase;
			this.Depth = 0f;
		}

		public Component2D(Sprite sprite, Vector2 pos, Rectangle body, float depth)
		{
			this.Sprite = sprite;
			this.Position = pos;
			this.Body = body;
			this.Depth = depth;
		}

        public event EventHandler<EventArgs> EnabledChanged;
        public event EventHandler<EventArgs> UpdateOrderChanged;
        public event EventHandler<EventArgs> DrawOrderChanged;
        public event EventHandler<EventArgs> VisibleChanged;

        public virtual void Initialize()
		{

		}

        public virtual void Update(GameTime gameTime)
        {
			Console.WriteLine("Hello World");
        }

        public virtual void Draw(GameTime gameTime)
        {
			Globals.SpriteBatch.Draw(
					this.Sprite.Texture,
					this.Position,
					Globals.RectBase,
					this.Sprite.Color,
					this.Sprite.Rotate,
					this.Sprite.Origin,
					this.Sprite.Scale,
					this.Sprite.SpriteEffects,
					this.Depth
					);
        }

        public virtual void Dispose()
        {
        }
    }
}
