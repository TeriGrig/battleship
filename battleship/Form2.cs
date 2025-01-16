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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            Form1 form1 = new Form1();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            PictureBox submarine = new PictureBox();            
            PictureBox battleship = new PictureBox();
            PictureBox destroyer = new PictureBox();
            PictureBox aircraft_carrier = new PictureBox();            
        }
    }
}
