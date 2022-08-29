using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recursive_Maze
{
    public partial class RecursiveMazeForm : Form
    {
        Color currentColor = Color.White;
        private int xTile = 25;
        private int yTile = 25;
        private int sizeTile = 10;
        private PictureBox[,] maze;

        public RecursiveMazeForm()
        {
            InitializeComponent();
        }

        private void RecursiveMazeForm_Load(object sender, EventArgs e)
        {
            CreateNewMaze();
        }

        private void whitePictureBox_Click(object sender, EventArgs e)
        {
            currentColor = Color.White;
        }

        private void blackPictureBox_Click(object sender, EventArgs e)
        {
            currentColor = Color.Black;
        }

        private void CreateNewMaze()
        {
            maze = new PictureBox[xTile, yTile];

            for (int i = 0; i < xTile; i++)
            {
                for (int j = 0; j < yTile; j++)
                {
                    maze[i, j] = new PictureBox();

                    int xPosition = (i * sizeTile) + 13;
                    int yPosition = (j * sizeTile) + 45;

                    maze[i, j].SetBounds(xPosition, yPosition, sizeTile, sizeTile);

                    if ((i == 0 && j == 0) || (i == xTile - 1 && j == yTile - 1))
                        maze[i, j].BackColor = Color.LightBlue;
                    else
                    {
                        maze[i, j].BackColor = Color.White;
                        maze[i, j].Click += new EventHandler(PictureBox_Click);
                    }

                    this.Controls.Add(maze[i, j]);
                }
            }
        }

        private bool SolveMaze(int xPos, int yPos, bool[,] alreadyVisited)
        {
            bool correctPath = false;

            bool mustCheck = true;

            if (xPos >= xTile || xPos < 0 || yPos >= yTile || yPos < 0)
                mustCheck = false;
            else
            {
                if (maze[xPos, yPos].BackColor == Color.LightBlue && (xPos != 0 && yPos != 0))
                {
                    correctPath = true;
                    mustCheck = false;
                }

                if (maze[xPos, yPos].BackColor == Color.Black)
                    mustCheck = false;

                if (alreadyVisited[xPos, yPos])
                    mustCheck = false;
            }

            if (mustCheck)
            {
                alreadyVisited[xPos, yPos] = true;

                correctPath = correctPath || SolveMaze(xPos + 1, yPos, alreadyVisited);
                correctPath = correctPath || SolveMaze(xPos, yPos + 1, alreadyVisited);
                correctPath = correctPath || SolveMaze(xPos - 1, yPos, alreadyVisited);
                correctPath = correctPath || SolveMaze(xPos, yPos - 1, alreadyVisited);
            }

            if (correctPath)
                maze[xPos, yPos].BackColor = Color.Gray;

            return correctPath;
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            ((PictureBox)sender).BackColor = currentColor;
        }

        private void solveButton_Click(object sender, EventArgs e)
        {
            

            bool[,] alreadyVisited = new bool[xTile, yTile];

            if (!SolveMaze(0, 0, alreadyVisited))
                MessageBox.Show("Maze does not have solution.");
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < xTile; i++)
            {
                for (int j = 0; j < yTile; j++)
                {
                    if (maze[i, j].BackColor == Color.Gray)
                        maze[i, j].BackColor = Color.White;
                }
            }

            maze[0, 0].BackColor = Color.LightBlue;
            maze[xTile - 1, yTile - 1].BackColor = Color.LightBlue;
        }
    }
}
