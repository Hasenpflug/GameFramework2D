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
    public class Actor : Microsoft.Xna.Framework.DrawableGameComponent
    {
        protected SpriteBatch spriteBatch;
        protected Texture2D tex;
        protected Vector2 position;
        protected Vector2 origin;
        protected float rotationFactor;
        protected float rotation;
        protected float scaleFactor;
        protected float scale;
        protected string state;
        protected string animationName;
        
        public Actor(Game game, SpriteBatch spriteBatch, Texture2D tex, Vector2 position, Vector2 origin)
            : base(game)
        {
            // TODO: Construct any child components here
            this.spriteBatch = spriteBatch;
            this.tex = tex;
            this.position = position;
            this.origin = origin;
        }

        public Actor(Game game, SpriteBatch spriteBatch, Texture2D tex, Vector2 position, Vector2 origin, float rotationFactor, 
        float rotation, float scaleFactor, float scale, string state, string animationName) 
            : base(game)
        {
            // TODO: Construct any child components here
            this.spriteBatch = spriteBatch;
            this.tex = tex;
            this.position = position;
            this.origin = origin;
            this.rotationFactor = rotationFactor;
            this.rotation = rotation;
            this.scaleFactor = scaleFactor;
            this.scale = scale;
            this.state = state;
            this.animationName = animationName;

            if (scale == 0)
            {
                scale = 1;
            }
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
        /// Returns the bounding box for the object from the top-left corner
        /// </summary>
        /// <returns>Rectangle</returns>
        public virtual Rectangle GetMask()
        {
            return new Rectangle((int)(position.X - origin.X), (int)(position.Y - origin.Y), tex.Width, tex.Height);
        }

        public virtual Texture2D GetSingleTextureFromArray(string name, Texture2D[] textures)
        {
            foreach (Texture2D texture in textures)
            {
                if (texture.Name == name.Substring(name.LastIndexOf('/') + 1, name.IndexOf('.') - name.LastIndexOf('/') - 1))
                {
                    return texture;
                }
            }
            return null;
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
