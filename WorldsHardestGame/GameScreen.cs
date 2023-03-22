using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorldsHardestGame
{
    public partial class GameScreen : UserControl
    {
        Player hero;
        List<Floor> floors = new List<Floor>();
        private int floorsHit;

        bool leftArrowDown = false, rightArrowDown = false, upArrowDown = false, downArrowDown = false;

        Random randGen = new Random();

        SolidBrush greenBrush = new SolidBrush(Color.Green);
        SolidBrush redBrush = new SolidBrush(Color.Red);
        SolidBrush whiteBrush = new SolidBrush(Color.White);

        public GameScreen()
        {
            InitializeComponent();
            SpawnLevel();
        }


        public void SpawnLevel()
        {
            Floor newFloor = new Floor(10, 10, 50, 50);
            floors.Add(newFloor);

            newFloor = new Floor(25, 25, 50, 100);
            floors.Add(newFloor);

            StartGame();
        }



        public void StartGame()
        {
            hero = new Player(25, 25);

            gameLoop.Start();
        }


        private void gameLoop_Tick(object sender, EventArgs e)
        {
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

            floorsHit = 0;
            foreach (Floor floor in floors)
            {
                
                if (hero.Collision(floor))
                {
                    floorsHit++;
                }
            }
                if (floorsHit == 0)
                {
                    hero.x = hero.prevX;
                    hero.y = hero.prevY;
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
            foreach(Floor floor in floors)
            {
                e.Graphics.FillRectangle(whiteBrush, floor.x, floor.y, floor.width, floor.height);
            }

            e.Graphics.FillRectangle(redBrush, hero.x, hero.y, hero.width, hero.height);
        }
    }
}
