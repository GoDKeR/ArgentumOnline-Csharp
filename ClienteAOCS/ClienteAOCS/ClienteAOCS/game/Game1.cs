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
using System.Windows.Forms;
using ClienteAOCS.engine;
using ClienteAOCS.map;

namespace ClienteAOCS.Game
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Control gameForms;
        IntPtr drawingSurface;
        Form parentForm;
        PictureBox pictureBox;

        public static byte b;

        public Game1(IntPtr drawingSurface, Form parentForm, PictureBox pictureBox)
        {
            this.drawingSurface = drawingSurface;
            this.parentForm = parentForm;
            this.pictureBox = pictureBox;

            graphics = new GraphicsDeviceManager(this);

            Content.RootDirectory = "Content";
            Components.Add(new FrameRateCounter(this));

            // prepare graphics event
            graphics.PreparingDeviceSettings +=
        new EventHandler<PreparingDeviceSettingsEventArgs>(graphics_PreparingDeviceSettings);

            graphics.PreferredBackBufferWidth = pictureBox.Width;
            graphics.PreferredBackBufferHeight = pictureBox.Height;
            graphics.SynchronizeWithVerticalRetrace = false;

            //GraphicsDevice.
            /*GraphicsDevice.PresentationParameters.BackBufferHeight = pictureBox.Height;
            GraphicsDevice.PresentationParameters.BackBufferWidth = pictureBox.Width;
            GraphicsDevice.PresentationParameters.PresentationInterval = PresentInterval.Immediate;
            GraphicsDevice.PresentationParameters.RenderTargetUsage = RenderTargetUsage.DiscardContents;
            */

            graphics.ApplyChanges();

            /*GraphicsDevice.RasterizerState = new RasterizerState()
            {
                FillMode = FillMode.WireFrame,
                CullMode = CullMode.None
            };*/

            gameForms = System.Windows.Forms.Control.FromHandle(this.Window.Handle);
            gameForms.VisibleChanged += gameForms_VisibleChanged;
            //Tell the mouse it will be getting it's input through the pictureBox
            Mouse.WindowHandle = drawingSurface;
        }

        void gameForms_VisibleChanged(object sender, EventArgs e) //Horrible esto
        {
            if (gameForms.Visible == true)
                gameForms.Visible = false;
        }

        private void graphics_PreparingDeviceSettings(object sender, PreparingDeviceSettingsEventArgs e)
        {
            // Finally attach game1's draw ability to the picture box in winforms.
            e.GraphicsDeviceInformation.PresentationParameters.DeviceWindowHandle = drawingSurface;
            
        }


        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            TextureManager.InitTextureManager(GraphicsDevice);

            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            // Allows the game to exit
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == Microsoft.Xna.Framework.Input.ButtonState.Pressed)
                this.Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {

            if (parentForm.Visible == true)
            {

                GraphicsDevice.Clear(ClearOptions.Target, Color.DarkSlateBlue, 1.0f, 0);

                RasterizerState state = new RasterizerState();

                if (b == 1)
                    state.FillMode = FillMode.WireFrame;
                else
                    state.FillMode = FillMode.Solid;

                spriteBatch.Begin(SpriteSortMode.Deferred,null,null,null,state);

                    Map.RenderMap(spriteBatch, 0, 0);

                spriteBatch.End();

                base.Draw(gameTime);

            }
        }
    }
}
