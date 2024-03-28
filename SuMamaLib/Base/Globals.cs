using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace SuMamaLib.Base
{
	public static class Globals
	{
		public static SpriteBatch SpriteBatch;
		public static ContentManager GlobalContent;

		public static Rectangle RectBase = new Rectangle(0, 0, 64, 64);

		public static void Initialize(GraphicsDevice graphicsDevice, ContentManager content)
		{
			SpriteBatch = new SpriteBatch(graphicsDevice);
			GlobalContent = content;
		}

    }
}
