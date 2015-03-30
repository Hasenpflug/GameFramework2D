using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;


namespace GameFramework2D
{
    /// <summary>
    /// This is a game component that implements IUpdateable.
    /// </summary>
    public class StartScene : GameScene
    {
        private MenuComponent menuComponent;

        public MenuComponent MenuComponent
        {
            get { return menuComponent; }
            set { menuComponent = value; }
        }

        string[] menu = { "Start Game", "How to Play", "Help", "About", "Exit" };

        private SpriteBatch spriteBatch;

        public SpriteBatch SpriteBatch
        {
            get { return spriteBatch; }
            set { spriteBatch = value; }
        }

        public StartScene(Game game, SpriteBatch spriteBatch)
            : base(game)
        {
            // TODO: Construct any child components here
            this.spriteBatch = spriteBatch;
            menuComponent = new MenuComponent(game, spriteBatch, game.Content.Load<SpriteFont>("fonts/regularFont"),
            game.Content.Load<SpriteFont>("fonts/hilightedFont"), menu, new Vector2(200, 200));
            this.Components.Add(menuComponent);
            
        }

        /// <summary>
        /// Allows the game component to perform any initialization it needs to before starting
        /// to run.  This is where it can query for any required services and load content.
        /// </summary>
        public override void Initialize()
        {
            // TODO: Add your initialization code here

            base.Initialize();
        }

        /// <summary>
        /// Allows the game component to update itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        public override void Update(GameTime gameTime)
        {
            // TODO: Add your update code here

            base.Update(gameTime);
        }
    }
}
