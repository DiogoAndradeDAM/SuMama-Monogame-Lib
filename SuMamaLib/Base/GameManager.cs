using System;

using Microsoft.Xna.Framework;

using SuMamaLib.Inputs.Mouse;
using SuMamaLib.Inputs.Keyboard;

namespace SuMamaLib.Base.GameManager
{
	public class GameManager
	{
		public GameManager()
		{

		}

		public void Initialize()
		{

		}

		public void Update(GameTime gameTime)
		{
			MouseManager.Update();
			KeyboardManager.Update();

			if( MouseManager.MouseRightButtonWasPressed()){
				Console.WriteLine("Hello World");
			}
		}

		public void Draw(GameTime gameTime)
		{
		
		}
	}
}
