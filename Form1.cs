using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kopipe_kun
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Properties.Settings.Default.ButtonKind = 1;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button11_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button.ToString() == "Left")
            {

            }
            if (e.Button.ToString() == "Right")
            {
                Form3 f = new Form3();
                f.ShowDialog();
            }
        }

        private void button12_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button.ToString() == "Left")
            {

            }
            if (e.Button.ToString() == "Right")
            {
                Form3 f = new Form3();
                f.ShowDialog();
            }
        }

        private void button13_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button.ToString() == "Left")
            {

            }
            if (e.Button.ToString() == "Right")
            {
                Form3 f = new Form3();
                f.ShowDialog();
            }
        }
    }
}
