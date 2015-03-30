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
    public class MenuComponent : Microsoft.Xna.Framework.DrawableGameComponent
    {
        private SpriteBatch spriteBatch;
        private SpriteFont regularFont;
        private SpriteFont hilightedFont;
        private List<string> menuItems;

        private int selectedIndex;

        public int SelectedIndex
        {
            get { return selectedIndex; }
            set { selectedIndex = value; }
        }

        private Vector2 position;
        private Color regularFontColor = Color.Purple;
        private Color hilightedFontColor = Color.Gold;
        private KeyboardState oldState;

        public MenuComponent(Game game, SpriteBatch spriteBatch, SpriteFont regularFont, SpriteFont hilightedFont, string[] menus, Vector2 position) 
            : base(game)
        {
            // TODO: Construct any child components here
            this.spriteBatch = spriteBatch;
            this.regularFont = regularFont;
            this.hilightedFont = hilightedFont;
            menuItems = new List<string>();
            for (int i = 0; i < menus.Length; i++)
            {
                menuItems.Add(menus[i]);
            }
            this.position = position;
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
            KeyboardState ks = Keyboard.GetState();
            if (ks.IsKeyUp(Keys.Down) && oldState.IsKeyDown(Keys.Down))
            {
                selectedIndex++;
                if (selectedIndex == menuItems.Count)
                {
                    selectedIndex = 0;
                }
            }

            if (ks.IsKeyUp(Keys.Up) && oldState.IsKeyDown(Keys.Up))
            {
                selectedIndex--;
                if (selectedIndex == -1)
                {
                    selectedIndex = menuItems.Count - 1;
                }
            }
            oldState = ks;

            base.Update(gameTime);
        }

        public override void Draw(GameTime gameTime)
        {
            Vector2 tempPos = position;
            spriteBatch.Begin();
            for (int i = 0; i < menuItems.Count; i++)
            {
                if (selectedIndex == i)
                {
                    spriteBatch.DrawString(hilightedFont, menuItems[i], tempPos, hilightedFontColor);
                    tempPos.Y += hilightedFont.LineSpacing;
                }
                else
                {
                    spriteBatch.DrawString(regularFont, menuItems[i], tempPos, regularFontColor);
                    tempPos.Y += regularFont.LineSpacing;
                }
                
            }
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
