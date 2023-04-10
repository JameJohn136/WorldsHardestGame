// Worlds Hardest Game Remake By James Johnson
// Made March 2023

#region System Declarations
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
#endregion

namespace WorldsHardestGame
{
    public partial class GameScreen : UserControl
    {
        Player hero;
        List<Floor> floors = new List<Floor>();
        WinArea winArea;
        List<Ball> balls = new List<Ball>();
        List<Key> keys = new List<Key>();
        List<Rectangle> keySprites = new List<Rectangle>();

        public int totalKeys = 4;

        bool leftArrowDown = false, rightArrowDown = false, upArrowDown = false, downArrowDown = false;

        Random randGen = new Random();

        SolidBrush wallBrush = new SolidBrush(Color.DarkGray);
        SolidBrush redBrush = new SolidBrush(Color.Red);
        SolidBrush ballBrush = new SolidBrush(Color.MediumPurple);
        SolidBrush greenBrush = new SolidBrush(Color.Green);

        // Sounds

        // Images
        Image keySprite;
        Image nullKeySprite;


        public GameScreen()
        {
            InitializeComponent();
            SpawnLevel();
        }


        public void SpawnLevel()
        {
            #region Floor Spawning
            Floor newFloor = new Floor(0, 0, 600, 25);
            floors.Add(newFloor);

            newFloor = new Floor(0, 25, 25, 600);
            floors.Add(newFloor);

            newFloor = new Floor(0, 475, 450, 25);
            floors.Add(newFloor);

            newFloor = new Floor(425, 25, 25, 600);
            floors.Add(newFloor);

            newFloor = new Floor(0, 100, 375, 25);
            floors.Add(newFloor);

            newFloor = new Floor(575, 600, 25, 600);
            floors.Add(newFloor);

            newFloor = new Floor(250, 150, 200, 20);
            floors.Add(newFloor);
            #endregion


            #region Ball Spawning
            Ball newBall = new Ball(250, 250, 25, 0, 10);
            balls.Add(newBall);

            newBall = new Ball(220, 25, 10, 0, 4);
            balls.Add(newBall);

            newBall = new Ball(265, 25, 15, 0, 3);
            balls.Add(newBall);

            newBall = new Ball(315, 25, 10, 0, 4);
            balls.Add(newBall);
            #endregion


            #region Key UI
            for (int i = 0; i < totalKeys; i++)
            {
                Rectangle newSprite = new Rectangle(325 + (32 * i), 10, 16, 16);
                keySprites.Add(newSprite);
            }

            keySprite = Properties.Resources.keySprite;
            nullKeySprite = Properties.Resources.nullKeySprite;
            #endregion

            #region Key Spawning
            Key key = new Key(250, 250);
            keys.Add(key);
            #endregion

            winArea = new WinArea(400, 425, 25);
            StartGame();
        }



        public void StartGame()
        {
            hero = new Player(25, 25);

            gameLoop.Start();
        }


        private void gameLoop_Tick(object sender, EventArgs e)
        {
            /**
             * Debug Output for finding the players position, this is to be able to move
             * to a location in game and see the x and y values for it, making it easier to build the level
             */
            posLabel.Text = $"X: {hero.x}\nY: {hero.y}";


            hero.prevX = hero.x;
            hero.prevY = hero.y;

            // Player Movement
            if (upArrowDown && hero.y > 0)
            {
                hero.Move("up");
            }
            if (downArrowDown && hero.y < this.Height - hero.height)
            {
                hero.Move("down");
            }

            if (leftArrowDown && hero.x > 0)
            {
                hero.Move("left");
            }

            if (rightArrowDown && hero.x < this.Width - hero.width)
            {
                hero.Move("right");
            }

            // Check for collision with walls
            foreach (Floor floor in floors)
            {
                if (hero.Collision(floor))
                {
                    hero.x = hero.prevX;
                    hero.y = hero.prevY;
                }
            }

            // Check for collision with keys
            foreach(Key key in keys)
            {
                if (hero.Collision(key))
                {
                    hero.currentKeys++;
                    keys.Remove(key);
                    break;
                }
            }

            // Check for collision with balls
            foreach (Ball ball in balls)
            {
                // Move each ball
                ball.x += ball.xSpeed;
                ball.y += ball.ySpeed;
                foreach (Floor floor in floors)
                {
                    if (ball.Collision(floor))
                    {
                        ball.InvertSpeed();
                    }

                    if (hero.Collision(ball))
                    {
                        hero.Restart();
                        deathsLabel.Text = $"Deaths: {hero.deaths}";
                    }
                }

            }

            // Check for collision with win area
            if (hero.Collision(winArea))
            {
                // Play Win Sound

                // Move to win screen
            }


            // End of gameloop Refresh
            Refresh();
        }
        private void GameScreen_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.A:
                    leftArrowDown = true;
                    break;
                case Keys.D:
                    rightArrowDown = true;
                    break;
                case Keys.W:
                    upArrowDown = true;
                    break;
                case Keys.S:
                    downArrowDown = true;
                    break;
            }
        }

        private void GameScreen_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.A:
                    leftArrowDown = false;
                    break;
                case Keys.D:
                    rightArrowDown = false;
                    break;
                case Keys.W:
                    upArrowDown = false;
                    break;
                case Keys.S:
                    downArrowDown = false;
                    break;
            }
        }
        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {

            foreach (Ball ball in balls)
            {
                e.Graphics.FillRectangle(ballBrush, ball.x, ball.y, ball.size, ball.size);
            }

            e.Graphics.FillRectangle(greenBrush, winArea.x, winArea.y, winArea.size, winArea.size);
            e.Graphics.FillRectangle(redBrush, hero.x, hero.y, hero.width, hero.height);

            // Draw Keys
            foreach(Key key in keys)
            {
                e.Graphics.DrawImage(keySprite, key.x, key.y);
            }

            foreach (Floor floor in floors)
            {
                e.Graphics.FillRectangle(wallBrush, floor.x, floor.y, floor.width, floor.height);
            }

            // Print Keys
            for (int i = 0; i < totalKeys; i++)
            {
                if (i < hero.currentKeys) // if key is found
                {
                    e.Graphics.DrawImage(keySprite, keySprites[i]);

                }
                else
                {
                    e.Graphics.DrawImage(nullKeySprite, keySprites[i]);
                }
            }
        }
    }
}
