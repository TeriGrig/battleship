using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace battleship
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] boardSize = new int[11];
        int[,] shipsPositions = new int[4, 2];
        List<PictureBox> ships = new List<PictureBox>();
        bool[,] shipsPlaced = new bool[10,10];
        bool ready = false;

        private void Form1_Load(object sender, EventArgs e)
        {   //start screen
            panel2.Visible = false;
            Label label = new Label();
            label.Text = "Battleship!";
            label.ForeColor = Color.DarkBlue;
            label.Font = new Font("Microsoft Sans Serif", 20, FontStyle.Bold);
            label.Location = new Point(350, 100);
            label.AutoSize = true;
            label.BackColor = Color.LightCyan;
            this.Controls.Add(label);
            Button play_button = new Button();
            play_button.Text = "PLAY";
            play_button.Font = new Font("Microsoft Sans Serif", 15, FontStyle.Bold);
            play_button.AutoSize = true;
            play_button.Enabled = true;
            play_button.Location = new Point(385, 300);
            this.Controls.Add(play_button);
            play_button.Click += new EventHandler(play_button_Click);

            panel1.Width = 400;
            panel1.Height = 400;
            boardSize[0] = 0;
            for (int i = 1; i < 11; i++)
            {
                boardSize[i] = boardSize[i - 1] + panel1.Width / 10;
            }

            ships.Add(submarine);
            ships.Add(battleship);
            ships.Add(destroyer);
            ships.Add(aircraft_carrier);

            ToolTip toolTip1 = new ToolTip();
            toolTip1.SetToolTip(submarine, "Άλλαξε κατεύθυνση με δεξί κλικ");
            toolTip1.SetToolTip(battleship, "Άλλαξε κατεύθυνση με δεξί κλικ");
            toolTip1.SetToolTip(destroyer, "Άλλαξε κατεύθυνση με δεξί κλικ");
            toolTip1.SetToolTip(aircraft_carrier, "Άλλαξε κατεύθυνση με δεξί κλικ");
        }

        //play button
        private void play_button_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            submarine.Visible = false;
            battleship.Visible = false;
            destroyer.Visible = false;
            aircraft_carrier.Visible = false;
        }

        //selection of each ship
        private void s_image_Click(object sender, EventArgs e)
        {
            submarine.Visible = true;
        }

        private void b_image_Click(object sender, EventArgs e)
        {
            battleship.Visible = true;
        }

        private void d_image_Click(object sender, EventArgs e)
        {
            destroyer.Visible = true;
        }

        private void ac_image_Click(object sender, EventArgs e)
        {
            aircraft_carrier.Visible = true;
        }

        //change of direction of each ship
        bool sb = false;
        private void submarine_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                sb = !sb;
                changeShipSize(submarine);
                if (sb) submarine.Image = Properties.Resources.s_vertical;
                else submarine.Image = Properties.Resources.s;
            }
        }

        bool bb = false;
        private void battleship_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                bb = !bb;
                changeShipSize(battleship);
                if (bb) battleship.Image = Properties.Resources.b_vertical;
                else battleship.Image = Properties.Resources.b;
            }
            else if (e.Button == MouseButtons.Left)
            {

            }

        }

        bool db = false;
        private void destroyer_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                db = !db;
                changeShipSize(destroyer);
                if (db) destroyer.Image = Properties.Resources.d_vertical;
                else destroyer.Image = Properties.Resources.d;
            }
            else if (e.Button == MouseButtons.Left)
            {

            }
        }

        bool ab = false;
        private void aircraft_carrier_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ab = !ab;
                changeShipSize(aircraft_carrier);
                if (ab) aircraft_carrier.Image = Properties.Resources.ac_vertical;
                else aircraft_carrier.Image = Properties.Resources.ac;
            }
            else if (e.Button == MouseButtons.Left)
            {

            }
        }

        //change of size of each ship
        public void changeShipSize(PictureBox p)
        {
            p.Size = new Size(p.Size.Height, p.Size.Width);
        }

        //clear all button
        private void Clear_Btn_Click(object sender, EventArgs e)
        {
            submarine.Visible = false;
            submarine.Location = new Point(0, 0);
            battleship.Visible = false;
            battleship.Location = new Point(0, 0);
            destroyer.Visible = false;
            destroyer.Location = new Point(0, 0);
            aircraft_carrier.Visible = false;
            aircraft_carrier.Location = new Point(0, 0);
        }

        //play button 2
        private void Play_Btn_Click(object sender, EventArgs e)
        {
            if (ready)
            {
                Form2 form2 = new Form2();
                this.Hide();
                form2.Show();
            }
        }

        //moving of each ship       
        bool dragging = false;
        int x, y;
        private void submarine_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
            Picture_Dropping(submarine, dragging, 2);
        }

        private void submarine_MouseMove(object sender, MouseEventArgs e)
        {
            Picture_Moving(submarine, x, y, dragging, sender, e);
        }

        private void submarine_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dragging = true;
                x = e.X;
                y = e.Y;
            }
        }

        private void battleship_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
            Picture_Dropping(battleship, dragging, 3);
        }

        private void battleship_MouseMove(object sender, MouseEventArgs e)
        {
            Picture_Moving(battleship, x, y, dragging, sender, e);
        }

        private void battleship_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dragging = true;
                x = e.X;
                y = e.Y;
            }
        }

        private void destroyer_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
            Picture_Dropping(destroyer, dragging, 4);
        }

        private void destroyer_MouseMove(object sender, MouseEventArgs e)
        {
            Picture_Moving(destroyer, x, y, dragging, sender, e);
        }

        private void destroyer_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dragging = true;
                x = e.X;
                y = e.Y;
            }
        }

        private void aircraft_carrier_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
            Picture_Dropping(aircraft_carrier, dragging, 5);
        }

        private void aircraft_carrier_MouseMove(object sender, MouseEventArgs e)
        {
            Picture_Moving(aircraft_carrier, x, y, dragging, sender, e);
        }

        private void aircraft_carrier_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dragging = true;
                x = e.X;
                y = e.Y;
            }
        }

        public void Picture_Moving(PictureBox p, int x, int y, bool d, object sender, MouseEventArgs e)
        {
            Control c = sender as Control;

            if (dragging && c != null)
            {
                c.Top += e.Y - y;
                c.Left += e.X - x;
            }
        }

        public void Picture_Dropping(PictureBox p, bool d, int size)
        {
            //Control c = sender as Control;
            if (!dragging)
            {
                for (int i = 0; i < 11; i++)
                {
                    for (int j = 0; j < 11; j++)
                    {
                        if (p.Location.X >= boardSize[i] && p.Location.X < boardSize[i + 1] && p.Location.Y >= boardSize[j] && p.Location.Y < boardSize[j + 1])
                        {
                            p.Location = new Point(boardSize[i], boardSize[j]);
                        }
                    }

                    //na mhn kanoun intersect ta ploia
                    //na mhn bgainoun ektos oriwn
                    //na ypologizw na einai mesa kai to megethos tou ploiou
                    
                    //-----------------------------------------
                    foreach (PictureBox pb in ships)
                    {
                        if (pb != p)
                        {
                            if (p.Bounds.IntersectsWith(pb.Bounds))
                            {//-----------------------------------------
                                p.Location = new Point(0, 0);
                            }
                        }
                    }

                    shipsPositions[size - 2, 0] = p.Location.X;
                    shipsPositions[size - 2, 1] = p.Location.Y;
                }
            }
        }
    }
}
