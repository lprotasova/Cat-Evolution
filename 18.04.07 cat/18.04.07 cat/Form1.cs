using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _18._04._07_cat.Properties;
using System.Diagnostics;
using System.Media;

namespace _18._04._07_cat
{
	public partial class mainForm : Form
	{
		public Stopwatch timer = new Stopwatch();
		public SoundPlayer player = new SoundPlayer();

		public mainForm()
		{
			InitializeComponent();
			KeyDown += new KeyEventHandler(mainForm_KeyDown);
			spawnFood(600, 400);
			spawnDog(600, 400);
			timer.Start();
			//player.SoundLocation = "Resources/nyan1.mp3";
			//player.PlayLooping();
		}

		/*private void panel1_DragEnter(object sender, ItemDragEventArgs e)
		{
			MessageBox.Show("dragenter");

			if (e.Data.GetDataPresent(typeof(Bitmap)))
				e.Effect = DragDropEffects.Copy;
			else
				e.Effect = DragDropEffects.None;
		}*/

		private void mainForm_KeyDown(object sender, KeyEventArgs e)
		{
			int x = cat1.Location.X;
			int y = cat1.Location.Y;
			int stepVal = 50;
			int formSizeX = 600;
			int formSizeY = 400;

			//handle for keys we use
			if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
				x += stepVal;
			else if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
				x -= stepVal;
			else if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
				y -= stepVal;
			else if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
				y += stepVal;
			else if (e.KeyCode == Keys.Escape)
				Application.Exit();

			//ensure we don't go off-screen
			if (x >= 0 && x + 50 <= formSizeX && y >= 0 && y + 50 <= formSizeY)
				cat1.Location = new System.Drawing.Point(x, y);

			//handle collision with food
			if (x == food1.Location.X && y == food1.Location.Y)
			{
				spawnFood(formSizeX, formSizeY);
				spawnDog(formSizeX, formSizeY);
				int score = Convert.ToInt32(scoreLabel.Text.Substring(7));
				score++;
				//score += 100;
				scoreLabel.Text = "Score: " + score;

				switch ((int) Math.Log(score, 2))
				{
					case 2:
						cat1.BackgroundImage = Resources.c2;
						break;
					case 3:
						cat1.BackgroundImage = Resources.c3;
						break;
					case 4:
						cat1.BackgroundImage = Resources.c4;
						break;
					case 5:
						cat1.BackgroundImage = Resources.c5;
						break;
					case 6:
						cat1.BackgroundImage = Resources.c6;
						break;
					case 7:
						cat1.BackgroundImage = Resources.c7;
						break;
					case 8:
						cat1.BackgroundImage = Resources.c8;
						break;
					case 9:
						cat1.BackgroundImage = Resources.c9;
						break;
					case 10:
						cat1.BackgroundImage = Resources.c10;
						timer.Stop();
						player.Stop();
						MessageBox.Show("YOU HAVE EVOLVED TO ULTIMATE CAT. YOUR TIME IS " + timer.ElapsedMilliseconds / 60000 +
							" MINUTES, " + (timer.ElapsedMilliseconds % 60000) / 1000 + " SECONDS. PLEASE RECORD YOUR TIME ON THE LIST OF CHAMPIONS.");
						Application.Exit();
						break;
					default:
						break;
				}
			}
			//handle collision with dog
			else if (x == dog1.Location.X && y == dog1.Location.Y)
			{
				MessageBox.Show("BARK BARK BARK BARK BARK BARK BARK BARK BARK BARK BARK BARK BARK BARK BARK BARK BARK BARK BARK BARK BARK " +
					"BARK BARK BARK BARK BARK BARK BARK BARK BARK BARK BARK BARK BARK BARK BARK BARK BARK BARK BARK BARK BARK BARK BARK BARK " +
					"BARK BARK BARK BARK BARK BARK BARK BARK BARK BARK BARK BARK BARK BARK BARK.\n\n" + 
					"(your score was " + scoreLabel.Text.Substring(7) + ", please record this on the high score list)", "BARK.", MessageBoxButtons.OK);
				Application.Exit();
			}
		}

		private void spawnFood(int screenX, int screenY)
		{
			Random rand = new Random();
			int foodX = rand.Next(0, screenX / 50);
			int foodY = rand.Next(0, screenY / 50);

			//while loop of re-loading to prevent spawn onto cat
			while (foodX * 50 == cat1.Location.X && foodY * 50 == cat1.Location.Y)
			{
				foodX = rand.Next(0, screenX / 50);
				foodY = rand.Next(0, screenY / 50);
			}

			food1.Location = new System.Drawing.Point(foodX * 50, foodY * 50);
			food1.BackgroundImage = Resources.f1;
		}

		private void spawnDog(int screenX, int screenY)
		{
			Random rand = new Random();
			int dogX = rand.Next(0, screenX / 50);
			int dogY = rand.Next(0, screenY / 50);

			//while loop of re-loading to prevent spawn onto food or cat
			while ((dogX * 50 == food1.Location.X && dogY * 50 == food1.Location.Y)
				|| (dogX * 50 == cat1.Location.X && dogY * 50 == cat1.Location.Y))
			{
				dogX = rand.Next(0, screenX / 50);
				dogY = rand.Next(0, screenY / 50);
			}

			dog1.Location = new System.Drawing.Point(dogX * 50, dogY * 50);
			dog1.BackgroundImage = Resources.d1;
		}
	}
}
