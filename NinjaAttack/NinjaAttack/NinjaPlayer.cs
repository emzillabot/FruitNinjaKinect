﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Research.Kinect.Nui;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace NinjaAttack
{
    public class NinjaPlayer
    {
        private Vector2 oldHandVector = new Vector();

        private NinjaGame mGame;

        private Vector2 realHandPosition = new Vector2(400, 300);
        private Texture2D handTexture;

        public NinjaPlayer(NinjaGame game)
        {
            mGame = game;
            LoadContent();
        }

        private void LoadContent()
        {
            handTexture = mGame.Content.Load<Texture2D>("sword");
        }

        public void UpdateHand(Vector hand)
        {
            //convert to XNA vector for ease
            Vector2 convertedHand = new Vector2(hand.X, hand.Y);
        }

        public void Draw(SpriteBatch sprite)
        {
            sprite.Draw(handTexture, realHandPosition, null, Color.White, 0.0f, new Vector2(50.0f, 50.0f), 1, SpriteEffects.None, 0);
        }
    }
}
