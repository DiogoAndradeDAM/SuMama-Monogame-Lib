	using System;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

using SuMamaLib.Inputs.Mouse;
using SuMamaLib.Inputs.Keyboard;
using SuMamaLib.Items2D.Sprite;

namespace SuMamaLib.Base.GameManager
{
	public class GameManager
	{
		public static SpriteBatch SpriteBatch;
		public static ContentManager GlobalContent;
		public static GameWindow Window;
		public Sprite sprite;

		public GameManager(GameWindow window, ContentManager content, GraphicsDevice graphicsDevice)
		{
			Window = window;
			GlobalContent = content;
			SpriteBatch = new SpriteBatch(graphicsDevice);
		}

		public void Initialize()
		{
			sprite = new Sprite(GlobalContent.Load<Texture2D>("Sprites/aiyra_spritesheet"));
		}

		public void Update(GameTime gameTime)
		{
			MouseManager.Update();
			KeyboardManager.Update();

			Console.WriteLine($"Mouse Position: {MouseManager.GetMousePosition()}");
		}

		public void Draw(GameTime gameTime)
		{
			SpriteBatch.Begin();

			SpriteBatch.Draw(sprite.Texture, new Vector2(100, 100), new Rectangle(sprite.Position.X, sprite.Position.Y, sprite.Width, sprite.Height), sprite.Color, sprite.Rotate, sprite.Origin, sprite.Scale, sprite.SpriteEffects, 1f);

			SpriteBatch.End();
		}
	}
}
