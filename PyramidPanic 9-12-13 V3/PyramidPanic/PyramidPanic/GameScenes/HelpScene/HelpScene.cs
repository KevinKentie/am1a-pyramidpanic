﻿//met Using kan je een XNA codebibliotheer gebruiken in je class
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

namespace PyramidPanic
{
    public class HelpScene : IState
    {
        //Fields van de class HelpScene
        private PyramidPanic game;

        //Constructor van de StartScene-class krijgt een object mee van het type PyramidPanic 
        public HelpScene(PyramidPanic game)
        {
            this.game = game;
            this.Initialize();
        }

        //Initialize methode. deze methode initialiseert (geeft startwaarden aan variabelen)
        //Void wil zeggen dat er niets terug gegeven word
        public void Initialize()
        {
            this.LoadContent();
        }

        //LoadContent methode. Deze methode maakt nieuwe objecten aan van verschillende
        //classes
        public void LoadContent()
        {

        }

        // Update methode. Deze methode wordt normaal 60 maal per seconde aangeroepen
        // en update alle variabelen, methods enz.......
        public void Update(GameTime gameTime)
        {
            if (Input.EdgeDetectKeyDown(Keys.Right) || Input.EdgeDetectMousePressLeft())
            {
                this.game.IState = this.game.StartScene;
            }
            if (Input.EdgeDetectKeyDown(Keys.Left))
            {
                this.game.IState = this.game.PlayScene;
            }
            if (Input.EdgeDetectKeyUp(Keys.Up))
            {
                this.game.IState = this.game.StartScene;
            }
        }

        // Draw methode. Deze methode wordt normaal 60 maal per seconde aangeroepen en
        // tekent de textures p[ het canvas
        public void Draw(GameTime gameTime)
        {
            this.game.GraphicsDevice.Clear(Color.Red);

        }
    }
}
