using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MazeGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            movetostart();
        }

        private void wall_MouseEnter(object sender, EventArgs e)
        {
            movetostart();
        }
       

        private void Finish_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("You won pretty");
            Close();
        }

        private void movetostart()
        {
            Point startingpoint = panel1.Location;
            startingpoint.Offset(10, 10);
            Cursor.Position = PointToScreen(startingpoint);
        }

    }
}
