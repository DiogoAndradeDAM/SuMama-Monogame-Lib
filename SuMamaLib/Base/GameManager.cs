	using System;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

using SuMamaLib.Inputs.Mouse;
using SuMamaLib.Inputs.Keyboard;
using SuMamaLib.Items2D.Sprites;
using SuMamaLib.Items2D.Component;

namespace SuMamaLib.Base
{
	public class GameManager
	{
		public static GameWindow Window;
		public Component2D component;

		public GameManager(GameWindow window, ContentManager content, GraphicsDevice graphicsDevice)
		{
			Window = window;
			Globals.Initialize(graphicsDevice, content);
		}

		public void Initialize()
		{

			component = new Component2D(new Sprite(Globals.GlobalContent.Load<Texture2D>("Sprites/aiyra_spritesheet")));
		}

		public void Update(GameTime gameTime)
		{
			MouseManager.Update();
			KeyboardManager.Update();


			component.Update(gameTime);
		}

		public void Draw(GameTime gameTime)
		{
			Globals.SpriteBatch.Begin();

			component.Draw(gameTime);

			Globals.SpriteBatch.End();
		}
	}
}
