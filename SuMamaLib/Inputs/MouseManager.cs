using SuMamaLib.Base;

namespace SuMamaLib.Inputs.Mouse
{
	using Microsoft.Xna.Framework;
	using Microsoft.Xna.Framework.Input;

   public static class MouseManager
   {
		private static MouseState _prevState = Mouse.GetState();
		private static MouseState _currState = Mouse.GetState();

		public static void Update()
		{
			_prevState = _currState;
			_currState = Mouse.GetState(GameManager.Window);
		}

		public static Point GetMousePositionWindow()
		{
			return new Point(_currState.X, _currState.Y);
		}

		public static Point GetMousePosition()
		{
			return new Point(MathHelper.Clamp(_currState.X, 0, GameManager.Window.ClientBounds.Width), MathHelper.Clamp(_currState.Y, 0, GameManager.Window.ClientBounds.Height));
		}

		public static void SetMousePosition(int x, int y)
		{
			Mouse.SetPosition(x, y);
		}

		public static bool MouseIsMovedX()
		{
			return _currState.X - _prevState.X != 0;
		}

		public static bool MouseIsMovedY()
		{
			return _currState.Y - _prevState.Y != 0;
		}

		public static bool MouseIsMoved()
		{
			return MouseIsMovedX() || MouseIsMovedY();
		}

		public static int GetScrollValue()
		{
			return _currState.ScrollWheelValue;
		}

		public static bool MouseScrollMoved()
		{
			return _currState.ScrollWheelValue - _prevState.ScrollWheelValue == 0;
		}


		public static bool MouseLeftButtonIsPressed()
		{
			return _currState.LeftButton == ButtonState.Pressed;
		}

		public static bool MouseLeftButtonIsReleased()
		{
			return _currState.LeftButton == ButtonState.Released;
		}

		public static bool MouseLeftButtonWasPressed()
		{
			return _currState.LeftButton == ButtonState.Pressed && !(_prevState.LeftButton == ButtonState.Pressed);
		}

		public static bool MouseLeftButtonWasReleased()
		{
			return !(_currState.LeftButton == ButtonState.Pressed) && _prevState.LeftButton == ButtonState.Pressed;
		}

		public static bool MouseRightButtonIsPressed()
		{
			return _currState.RightButton == ButtonState.Pressed;
		}

		public static bool MouseRightButtonIsReleased()
		{
			return _currState.RightButton == ButtonState.Released;
		}

		public static bool MouseRightButtonWasPressed()
		{
			return _currState.RightButton == ButtonState.Pressed && !(_prevState.RightButton == ButtonState.Pressed);
		}

		public static bool MouseRightButtonWasReleased()
		{
			return !(_currState.RightButton == ButtonState.Pressed) && _prevState.RightButton == ButtonState.Pressed;
		}

		public static bool MouseMiddleButtonIsPressed()
		{
			return _currState.MiddleButton == ButtonState.Pressed;
		}

		public static bool MouseMiddleButtonIsReleased()
		{
			return _currState.MiddleButton == ButtonState.Released;
		}

		public static bool MouseMiddleButtonWasPressed()
		{
			return _currState.MiddleButton == ButtonState.Pressed && !(_prevState.MiddleButton == ButtonState.Pressed);
		}

		public static bool MouseMiddleButtonWasReleased()
		{
			return !(_currState.MiddleButton == ButtonState.Pressed) && _prevState.MiddleButton == ButtonState.Pressed;
		}
   }
}
