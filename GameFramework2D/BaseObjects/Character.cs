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
    public class Character : Actor
    {
        protected short currentHealth;
        protected short maxHealth;
        protected Vector2 velocityFactor;
        protected float velocity;
        protected byte frameIndex;
        protected byte frameDelay;
        
        public Character(Game game, SpriteBatch spriteBatch, Texture2D tex, Vector2 position, Vector2 origin)
            : base(game, spriteBatch, tex, position, origin)
        {
            // TODO: Construct any child components here
                       
        }

        public Character(Game game, SpriteBatch spriteBatch, Texture2D tex, Vector2 position, Vector2 origin, 
        float rotationFactor, float rotation, float scaleFactor, float scale, string state, string animationName)
            : base(game, spriteBatch, tex, position, origin, rotationFactor, rotation, scaleFactor, scale, state, animationName)
        {
            // TODO: Construct any child components here
            this.currentHealth = 1;
            this.maxHealth = 1;
            this.velocity = 0f;
            this.velocityFactor = Vector2.Zero;
            this.frameIndex = 0;
        }

        public Character(Game game, SpriteBatch spriteBatch, Texture2D tex, Vector2 position, Vector2 origin,
        float rotationFactor, float rotation, float scaleFactor, float scale, short currentHealth, short maxHealth, Vector2 velocityFactor, float velocity, string state, string animationName)
            : base(game, spriteBatch, tex, position, origin, rotationFactor, rotation, scaleFactor, scale, state, animationName)
        {
            // TODO: Construct any child components here
            this.currentHealth = currentHealth;
            this.maxHealth = maxHealth;
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

        public virtual void Stop()
        {
            position -= velocityFactor * velocity;
        }

        public virtual void Bounce()
        {
            velocityFactor = velocityFactor * (-1);
        }
        
        /// <summary>
        /// Allows the game component to update itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        public override void Update(GameTime gameTime)
        {
            // TODO: Add your update code here
            position += velocity * velocityFactor;
            base.Update(gameTime);
        }

        public override void Draw(GameTime gameTime)
        {
            base.Draw(gameTime);
        }
    }
}
