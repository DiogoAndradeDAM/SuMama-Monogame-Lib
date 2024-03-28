using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace SuMamaLib.Items2D.Sprites
{
	public class Sprite
	{
		public Texture2D Texture { get; private set; }
		public Color Color { get; set; }
		public SpriteEffects SpriteEffects { get; set; }
		public int Width { get; private set; }
		public int Height { get; private set; }
		public Point Position { get; private set; }
		public float Rotate {get; set; }
		public Vector2 Origin { get; set; }
		public Vector2 Scale { get; set; }

		public Sprite(Texture2D texture)
		{
			this.Texture = texture;
			this.Color = Color.White;
			this.SpriteEffects = SpriteEffects.None;
			this.Width = texture.Bounds.Width;
			this.Height = texture.Bounds.Height;
			this.Position = new Point(0, 0);
			this.Rotate = 0f;
			this.Origin = Vector2.Zero;
			this.Scale =  Vector2.One;
		}

		public Sprite(Texture2D texture, Color color, float rotate)
		{
			this.Texture = texture;
			this.Color = color;
			this.SpriteEffects = SpriteEffects.None;
			this.Width = texture.Bounds.Width;
			this.Height = texture.Bounds.Height;
			this.Position = new Point(0, 0);
			this.Rotate = rotate;
			this.Origin = Vector2.Zero;
			this.Scale = Vector2.One;
		}
		
		public Sprite(Texture2D texture, Color color, float rotate, Vector2 origin, Vector2 scale)
		{
			this.Texture = texture;
			this.Color = color;
			this.SpriteEffects = SpriteEffects.None;
			this.Width = texture.Bounds.Width;
			this.Height = texture.Bounds.Height;
			this.Position = new Point(0, 0);
			this.Rotate = rotate;
			this.Origin = origin; 
			this.Scale = scale; 
		}

	}
}
