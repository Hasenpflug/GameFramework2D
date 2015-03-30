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


namespace GameFramework2D.BaseObjects
{
    /// <summary>
    /// This is a game component that implements IUpdateable.
    /// </summary>
    public class EnvironmentController : Microsoft.Xna.Framework.DrawableGameComponent
    {
        protected Vector2 position;
        protected Vector2 origin;
        protected short width;
        protected short height;

        public EnvironmentController(Game game, Vector2 position, Vector2 origin, short width, short height)
            : base(game)
        {
            // TODO: Construct any child components here
            this.position = position;
            this.origin = origin;
            this.width = width;
            this.height = height;
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

        public virtual Rectangle GetMask()
        {
            return new Rectangle((int)(position.X - origin.X), (int)(position.Y - origin.Y), width, height);
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
