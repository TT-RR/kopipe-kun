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

        //Load1はただの関数
        void Load1()
        {

            if (Properties.Settings.Default.ButtonKind == 1)
            {
                button1.BackColor = Color.DeepSkyBlue;
                button2.BackColor = Color.DarkGray;
                button3.BackColor = Color.DarkGray;

                button1.Text = Properties.Settings.Default.Title1;
                button2.Text = Properties.Settings.Default.Title2;
                button3.Text = Properties.Settings.Default.Title3;
                button4.Text = Properties.Settings.Default.Title4;
                button5.Text = Properties.Settings.Default.Title5;
                button6.Text = Properties.Settings.Default.Title6;
                button7.Text = Properties.Settings.Default.Title7;
                button8.Text = Properties.Settings.Default.Title8;
                button9.Text = Properties.Settings.Default.Title9;
                button10.Text = Properties.Settings.Default.Title10;
            }
            else if (Properties.Settings.Default.ButtonKind == 2)
            {
                button1.BackColor = Color.DarkGray;
                button2.BackColor = Color.DeepSkyBlue;
                button3.BackColor = Color.DarkGray;

                button1.Text = Properties.Settings.Default.Title11;
                button2.Text = Properties.Settings.Default.Title12;
                button3.Text = Properties.Settings.Default.Title13;
                button4.Text = Properties.Settings.Default.Title14;
                button5.Text = Properties.Settings.Default.Title15;
                button6.Text = Properties.Settings.Default.Title16;
                button7.Text = Properties.Settings.Default.Title17;
                button8.Text = Properties.Settings.Default.Title18;
                button9.Text = Properties.Settings.Default.Title19;
                button10.Text = Properties.Settings.Default.Title20;
            }
            else if (Properties.Settings.Default.ButtonKind == 3)
            {
                button1.BackColor = Color.DarkGray;
                button2.BackColor = Color.DeepSkyBlue;
                button3.BackColor = Color.DarkGray;

                button1.Text = Properties.Settings.Default.Title21;
                button2.Text = Properties.Settings.Default.Title22;
                button3.Text = Properties.Settings.Default.Title23;
                button4.Text = Properties.Settings.Default.Title24;
                button5.Text = Properties.Settings.Default.Title25;
                button6.Text = Properties.Settings.Default.Title26;
                button7.Text = Properties.Settings.Default.Title27;
                button8.Text = Properties.Settings.Default.Title28;
                button9.Text = Properties.Settings.Default.Title29;
                button10.Text = Properties.Settings.Default.Title30;
            }
            button11.Text = Properties.Settings.Default.TabName1;
            button12.Text = Properties.Settings.Default.TabName2;
            button13.Text = Properties.Settings.Default.TabName3;


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


        //名にも登録されていないので、空白がコピーされます

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {

            Properties.Settings.Default.ButtonNumber = 1;

            if(e.Button.ToString() == "Left")
            {
                if (Properties.Settings.Default.ButtonKind == 1)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.Content1);
                }
                else if (Properties.Settings.Default.ButtonKind == 2)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.Content11);
                }
                else if (Properties.Settings.Default.ButtonKind == 3)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.Content21);
                }
            }
            else if(e.Button.ToString() == "Right")
            {
                Form2 f = new Form2();
                f.ShowDialog();
            }
        }

        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            //対応したボタンを押したときにformを表示
            Properties.Settings.Default.ButtonNumber = 1;

            if (e.Button.ToString() == "Left")
            {
                if (Properties.Settings.Default.ButtonKind == 1)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.Content1);
                }
                else if (Properties.Settings.Default.ButtonKind == 2)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.Content11);
                }
                else if (Properties.Settings.Default.ButtonKind == 3)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.Content21);
                }
            }
            else if (e.Button.ToString() == "Right")
            {
                Form2 f = new Form2();
                f.ShowDialog();
            }
        }

        private void button3_MouseDown(object sender, MouseEventArgs e)
        {
            //対応したボタンを押したときにformを表示
            Properties.Settings.Default.ButtonNumber = 1;

            if (e.Button.ToString() == "Left")
            {
                if (Properties.Settings.Default.ButtonKind == 1)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.Content1);
                }
                else if (Properties.Settings.Default.ButtonKind == 2)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.Content11);
                }
                else if (Properties.Settings.Default.ButtonKind == 3)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.Content21);
                }
            }
            else if (e.Button.ToString() == "Right")
            {
                Form2 f = new Form2();
                f.ShowDialog();
            }
        }

        private void button4_MouseDown(object sender, MouseEventArgs e)
        {
            //対応したボタンを押したときにformを表示
            Properties.Settings.Default.ButtonNumber = 1;

            if (e.Button.ToString() == "Left")
            {
                if (Properties.Settings.Default.ButtonKind == 1)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.Content1);
                }
                else if (Properties.Settings.Default.ButtonKind == 2)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.Content11);
                }
                else if (Properties.Settings.Default.ButtonKind == 3)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.Content21);
                }
            }
            else if (e.Button.ToString() == "Right")
            {
                Form2 f = new Form2();
                f.ShowDialog();
            }
        }

        private void button5_MouseDown(object sender, MouseEventArgs e)
        {
            //対応したボタンを押したときにformを表示
            Properties.Settings.Default.ButtonNumber = 1;

            if (e.Button.ToString() == "Left")
            {
                if (Properties.Settings.Default.ButtonKind == 1)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.Content1);
                }
                else if (Properties.Settings.Default.ButtonKind == 2)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.Content11);
                }
                else if (Properties.Settings.Default.ButtonKind == 3)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.Content21);
                }
            }
            else if (e.Button.ToString() == "Right")
            {
                Form2 f = new Form2();
                f.ShowDialog();
            }
        }

        private void button6_MouseDown(object sender, MouseEventArgs e)
        {
            //対応したボタンを押したときにformを表示
            Properties.Settings.Default.ButtonNumber = 1;

            if (e.Button.ToString() == "Left")
            {
                if (Properties.Settings.Default.ButtonKind == 1)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.Content1);
                }
                else if (Properties.Settings.Default.ButtonKind == 2)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.Content11);
                }
                else if (Properties.Settings.Default.ButtonKind == 3)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.Content21);
                }
            }
            else if (e.Button.ToString() == "Right")
            {
                Form2 f = new Form2();
                f.ShowDialog();
            }
        }

        private void button7_MouseDown(object sender, MouseEventArgs e)
        {
            //対応したボタンを押したときにformを表示
            Properties.Settings.Default.ButtonNumber = 1;

            if (e.Button.ToString() == "Left")
            {
                if (Properties.Settings.Default.ButtonKind == 1)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.Content1);
                }
                else if (Properties.Settings.Default.ButtonKind == 2)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.Content11);
                }
                else if (Properties.Settings.Default.ButtonKind == 3)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.Content21);
                }
            }
            else if (e.Button.ToString() == "Right")
            {
                Form2 f = new Form2();
                f.ShowDialog();
            }
        }

        private void button8_MouseDown(object sender, MouseEventArgs e)
        {
            //対応したボタンを押したときにformを表示
            Properties.Settings.Default.ButtonNumber = 1;

            if (e.Button.ToString() == "Left")
            {
                if (Properties.Settings.Default.ButtonKind == 1)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.Content1);
                }
                else if (Properties.Settings.Default.ButtonKind == 2)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.Content11);
                }
                else if (Properties.Settings.Default.ButtonKind == 3)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.Content21);
                }
            }
            else if (e.Button.ToString() == "Right")
            {
                Form2 f = new Form2();
                f.ShowDialog();
            }
        }

        private void button9_MouseDown(object sender, MouseEventArgs e)
        {
            //対応したボタンを押したときにformを表示
            Properties.Settings.Default.ButtonNumber = 1;

            if (e.Button.ToString() == "Left")
            {
                if (Properties.Settings.Default.ButtonKind == 1)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.Content1);
                }
                else if (Properties.Settings.Default.ButtonKind == 2)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.Content11);
                }
                else if (Properties.Settings.Default.ButtonKind == 3)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.Content21);
                }
            }
            else if (e.Button.ToString() == "Right")
            {
                Form2 f = new Form2();
                f.ShowDialog();
            }
        }

        private void button10_MouseDown(object sender, MouseEventArgs e)
        {
            //対応したボタンを押したときにformを表示
            Properties.Settings.Default.ButtonNumber = 1;

            if (e.Button.ToString() == "Left")
            {
                if (Properties.Settings.Default.ButtonKind == 1)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.Content1);
                }
                else if (Properties.Settings.Default.ButtonKind == 2)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.Content11);
                }
                else if (Properties.Settings.Default.ButtonKind == 3)
                {
                    Clipboard.SetDataObject(Properties.Settings.Default.Content21);
                }
            }
            else if (e.Button.ToString() == "Right")
            {
                Form2 f = new Form2();
                f.ShowDialog();
            }
        }
    }
}
