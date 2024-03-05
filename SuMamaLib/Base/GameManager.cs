using System;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

using SuMamaLib.Inputs.Mouse;
using SuMamaLib.Inputs.Keyboard;

namespace SuMamaLib.Base.GameManager
{
	public class GameManager
	{
		public static SpriteBatch SpriteBatch;
		public static ContentManager GlobalContent;
		public static GameWindow Window;

		public GameManager(GameWindow window, ContentManager content, GraphicsDevice graphicsDevice)
		{
			Window = window;
			GlobalContent = content;
			SpriteBatch = new SpriteBatch(graphicsDevice);
		}

		public void Initialize()
		{
		}

		public void Update(GameTime gameTime)
		{
			MouseManager.Update(Window);
			KeyboardManager.Update();

			Console.WriteLine($"Mouse Position: {MouseManager.GetMousePosition()}");
		}

		public void Draw(GameTime gameTime)
		{
			SpriteBatch.Begin();

			SpriteBatch.End();
		}
	}
}
