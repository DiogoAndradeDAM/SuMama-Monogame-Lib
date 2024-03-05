namespace SuMamaLib.Inputs.Keyboard
{

using Microsoft.Xna.Framework.Input;

   	public static class KeyboardManager
	{
		private static KeyboardState _prevState = Keyboard.GetState();
		private static KeyboardState _currState = Keyboard.GetState();

        public static void Update()
        {
            _prevState = _currState;
            _currState = Keyboard.GetState();
        }


		public static bool KeyIsPressed(Keys key)
		{
			return _currState.IsKeyDown(key);
		}

		public static bool KeyIsReleased(Keys key)
		{
			return _currState.IsKeyUp(key);
		}

		public static bool KeyWasPressed(Keys key)
		{
			return _currState.IsKeyDown(key) && !(_prevState.IsKeyDown(key));
		}

		public static bool KeyWasReleased(Keys key)
		{
			return !(_currState.IsKeyDown(key)) && _prevState.IsKeyDown(key);
		}

		public static bool KeysIsPressed(Keys[] keys)
		{
			foreach(Keys key in keys){
				if( KeyIsPressed(key) == false ) return false;
			}
			return true;
		}

		public static bool KeysWasPressed(Keys[] keys)
		{
			foreach(Keys key in keys){
				if( KeyWasPressed(key) == false ) return false;
			}
			return true;
		}

		public static bool KeysWasReleased(Keys[] keys)
		{
			foreach(Keys key in keys){
				if( KeyWasReleased(key) == false ) return false;
			}
			return true;
		}
	}
} 
