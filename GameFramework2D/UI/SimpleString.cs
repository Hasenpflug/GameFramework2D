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
    public class SimpleString : Microsoft.Xna.Framework.DrawableGameComponent
    {
        private SpriteBatch spriteBatch;

        public SpriteBatch SpriteBatch
        {
            get { return spriteBatch; }
            set { spriteBatch = value; }
        }

        private SpriteFont font;

        public SpriteFont Font
        {
            get { return font; }
            set { font = value; }
        }
        private Vector2 position;

        public Vector2 Position
        {
            get { return position; }
            set { position = value; }
        }
        private Color color;

        public Color Color
        {
            get { return color; }
            set { color = value; }
        }
        private string message;

        public string Message
        {
            get { return message; }
            set { message = value; }
        }

        public SimpleString(Game game, SpriteBatch spriteBatch, SpriteFont font, Vector2 position, Color color, string message)
            : base(game)
        {
            // TODO: Construct any child components here
            this.spriteBatch = spriteBatch;
            this.font = font;
            this.position = position;
            this.color = color;
            this.message = message;
            
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

        public override void Draw(GameTime gameTime)
        {
            spriteBatch.Begin();
            spriteBatch.DrawString(font, message, position, color);
            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
