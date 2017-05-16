using System;
using Microsoft.Xna.Framework;
using Practice.View;
using Microsoft.Xna.Framework.Graphics;
namespace Practice
{
	public class Mortar
	{
		
		// Animation representing the player
		public Animation bulletAnimation;

		// Position of the Player relative to the upper left side of the screen

		public Vector2 Position;
		// State of the Projectile
		public bool Active;

		// The amount of damage the projectile can inflict to an enemy
		public int Damage;

		// Represents the viewable boundary of the game
		Viewport viewport;


		public int Width
		{
			get { return bulletAnimation.FrameWidth; }
		}

		// Get the height of the player ship
		public int Height
		{
			get { return bulletAnimation.FrameHeight; }
		}
	

		// Determines how fast the projectile moves
		float projectileMoveSpeed;


		public void Initialize(Animation animation, Vector2 position,Viewport viewprt)
		{
			this.bulletAnimation = animation;
			this.viewport = viewprt;
			// Set the starting position of the player around the middle of the screen and to the back
			Position = position;

			Damage = 200;

			projectileMoveSpeed = 1f;
			// Set the player to be active
			Active = true;



		}
		public void Update()
		{
			// Projectiles always move to the right
			Position.X += projectileMoveSpeed;

			// Deactivate the bullet if it goes out of screen
			if (Position.X + bulletAnimation.FrameWidth / 2 > viewport.Width)
				Active = false;
		}

		public void Draw(SpriteBatch spriteBatch)
		{
			bulletAnimation.Draw(spriteBatch);
		}


	}
}
