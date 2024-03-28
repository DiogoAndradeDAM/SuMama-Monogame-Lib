using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

using SuMamaLib.Base;

namespace SuMamaLib;

public class Game1 : Game
{
    private GraphicsDeviceManager _graphics;
	private GameManager gameManager;

    public Game1()
    {
        _graphics = new GraphicsDeviceManager(this);
        Content.RootDirectory = "Content";
        IsMouseVisible = true;

    }

    protected override void Initialize()
    {
        // TODO: Add your initialization logic here
		//

		gameManager = new GameManager(Window , Content, GraphicsDevice);

        base.Initialize();
    }

    protected override void LoadContent()
    {

        // TODO: use this.Content to load your game content here
		
		gameManager.Initialize();
    }

    protected override void Update(GameTime gameTime)
    {
        if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
            Exit();

		gameManager.Update(gameTime);

        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.CornflowerBlue);

        // TODO: Add your drawing code here

		gameManager.Draw(gameTime);

        // TODO: Add your drawing code here


        base.Draw(gameTime);
    }
}
