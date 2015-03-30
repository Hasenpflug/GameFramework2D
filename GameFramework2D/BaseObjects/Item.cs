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
    public class Item : Actor
    {
        protected Vector2 velocityFactor;
        protected float velocity;
        
        public Item(Game game, SpriteBatch spriteBatch, Texture2D tex, Vector2 position, Vector2 origin)
            : base(game, spriteBatch, tex, position, origin)
        {
            // TODO: Construct any child components here

        }

        public Item(Game game, SpriteBatch spriteBatch, Texture2D tex, Vector2 position, Vector2 origin, Vector2 velocityFactor, float velocity)
            : base(game, spriteBatch, tex, position, origin)
        {
            // TODO: Construct any child components here
            this.velocityFactor = velocityFactor;
            this.velocity = velocity;
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

        public override Rectangle GetMask()
        {
            return base.GetMask();
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
            base.Draw(gameTime);
        }
    }
}
