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
    public partial class Form2 : Form
    {
        int buttonKind;
        int buttonNumber;
      
        public Form2()
        {
            InitializeComponent();

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        void Load1()
        {
            if (Properties.Settings.Default.ButtonKind == 1)
            {
                if (Properties.Settings.Default.ButtonNumber == 1)
                {
                    textBox1.Text = Properties.Settings.Default.Title1;
                    textBox2.Text = Properties.Settings.Default.Content1;
                }
                else if (Properties.Settings.Default.ButtonNumber == 2)
                {
                    textBox1.Text = Properties.Settings.Default.Title2;
                    textBox2.Text = Properties.Settings.Default.Content2;
                }

                else if (Properties.Settings.Default.ButtonNumber == 3)
                {
                    textBox1.Text = Properties.Settings.Default.Title3;
                    textBox2.Text = Properties.Settings.Default.Content3;
                }

                else if (Properties.Settings.Default.ButtonNumber == 4)
                {
                    textBox1.Text = Properties.Settings.Default.Title4;
                    textBox2.Text = Properties.Settings.Default.Content4;
                }

                else if (Properties.Settings.Default.ButtonNumber == 5)
                {
                    textBox1.Text = Properties.Settings.Default.Title5;
                    textBox2.Text = Properties.Settings.Default.Content5;
                }

                else if (Properties.Settings.Default.ButtonNumber == 6)
                {
                    textBox1.Text = Properties.Settings.Default.Title6;
                    textBox2.Text = Properties.Settings.Default.Content6;
                }

                else if (Properties.Settings.Default.ButtonNumber == 7)
                {
                    textBox1.Text = Properties.Settings.Default.Title7;
                    textBox2.Text = Properties.Settings.Default.Content7;
                }

                else if (Properties.Settings.Default.ButtonNumber == 8)
                {
                    textBox1.Text = Properties.Settings.Default.Title8;
                    textBox2.Text = Properties.Settings.Default.Content8;
                }

                else if (Properties.Settings.Default.ButtonNumber == 9)
                {
                    textBox1.Text = Properties.Settings.Default.Title9;
                    textBox2.Text = Properties.Settings.Default.Content9;
                }

                else if (Properties.Settings.Default.ButtonNumber == 10)
                {
                    textBox1.Text = Properties.Settings.Default.Title10;
                    textBox2.Text = Properties.Settings.Default.Content10;
                }

                else if (Properties.Settings.Default.ButtonKind == 2)
                {
                    if (Properties.Settings.Default.ButtonNumber == 1)
                    {
                        textBox1.Text = Properties.Settings.Default.Title11;
                        textBox2.Text = Properties.Settings.Default.Content11;
                    }
                    else if (Properties.Settings.Default.ButtonNumber == 2)
                    {
                        textBox1.Text = Properties.Settings.Default.Title12;
                        textBox2.Text = Properties.Settings.Default.Content12;
                    }

                    else if (Properties.Settings.Default.ButtonNumber == 3)
                    {
                        textBox1.Text = Properties.Settings.Default.Title13;
                        textBox2.Text = Properties.Settings.Default.Content13;
                    }

                    else if (Properties.Settings.Default.ButtonNumber == 4)
                    {
                        textBox1.Text = Properties.Settings.Default.Title14;
                        textBox2.Text = Properties.Settings.Default.Content14;
                    }

                    else if (Properties.Settings.Default.ButtonNumber == 5)
                    {
                        textBox1.Text = Properties.Settings.Default.Title15;
                        textBox2.Text = Properties.Settings.Default.Content15;
                    }

                    else if (Properties.Settings.Default.ButtonNumber == 6)
                    {
                        textBox1.Text = Properties.Settings.Default.Title16;
                        textBox2.Text = Properties.Settings.Default.Content16;
                    }

                    else if (Properties.Settings.Default.ButtonNumber == 7)
                    {
                        textBox1.Text = Properties.Settings.Default.Title17;
                        textBox2.Text = Properties.Settings.Default.Content17;
                    }

                    else if (Properties.Settings.Default.ButtonNumber == 8)
                    {
                        textBox1.Text = Properties.Settings.Default.Title18;
                        textBox2.Text = Properties.Settings.Default.Content18;
                    }

                    else if (Properties.Settings.Default.ButtonNumber == 9)
                    {
                        textBox1.Text = Properties.Settings.Default.Title19;
                        textBox2.Text = Properties.Settings.Default.Content19;
                    }

                    else if (Properties.Settings.Default.ButtonNumber == 10)
                    {
                        textBox1.Text = Properties.Settings.Default.Title20;
                        textBox2.Text = Properties.Settings.Default.Content20;
                    }

                    else if (Properties.Settings.Default.ButtonKind == 3)
                    {
                        if (Properties.Settings.Default.ButtonNumber == 1)
                        {
                            textBox1.Text = Properties.Settings.Default.Title21;
                            textBox2.Text = Properties.Settings.Default.Content21;
                        }
                        else if (Properties.Settings.Default.ButtonNumber == 2)
                        {
                            textBox1.Text = Properties.Settings.Default.Title22;
                            textBox2.Text = Properties.Settings.Default.Content22;
                        }

                        else if (Properties.Settings.Default.ButtonNumber == 3)
                        {
                            textBox1.Text = Properties.Settings.Default.Title23;
                            textBox2.Text = Properties.Settings.Default.Content23;
                        }

                        else if (Properties.Settings.Default.ButtonNumber == 4)
                        {
                            textBox1.Text = Properties.Settings.Default.Title24;
                            textBox2.Text = Properties.Settings.Default.Content24;
                        }

                        else if (Properties.Settings.Default.ButtonNumber == 5)
                        {
                            textBox1.Text = Properties.Settings.Default.Title25;
                            textBox2.Text = Properties.Settings.Default.Content25;
                        }

                        else if (Properties.Settings.Default.ButtonNumber == 6)
                        {
                            textBox1.Text = Properties.Settings.Default.Title26;
                            textBox2.Text = Properties.Settings.Default.Content26;
                        }

                        else if (Properties.Settings.Default.ButtonNumber == 7)
                        {
                            textBox1.Text = Properties.Settings.Default.Title27;
                            textBox2.Text = Properties.Settings.Default.Content27;
                        }

                        else if (Properties.Settings.Default.ButtonNumber == 8)
                        {
                            textBox1.Text = Properties.Settings.Default.Title28;
                            textBox2.Text = Properties.Settings.Default.Content28;
                        }

                        else if (Properties.Settings.Default.ButtonNumber == 9)
                        {
                            textBox1.Text = Properties.Settings.Default.Title29;
                            textBox2.Text = Properties.Settings.Default.Content29;
                        }

                        else if (Properties.Settings.Default.ButtonNumber == 10)
                        {
                            textBox1.Text = Properties.Settings.Default.Title30;
                            textBox2.Text = Properties.Settings.Default.Content30;
                        }
                    }
                }
            }
        }
        //追加
        private void button1_Click(object sender, EventArgs e)
        {
            buttonKind = Properties.Settings.Default.ButtonKind;
            buttonNumber = Properties.Settings.Default.ButtonNumber;

            if (buttonKind == 1)
            {
                if (buttonNumber == 1)
                {
                    Properties.Settings.Default.Title1 = textBox1.Text;
                    Properties.Settings.Default.Content1 = textBox2.Text;
                }

                else if (buttonNumber == 2)
                {
                    Properties.Settings.Default.Title2 = textBox1.Text;
                    Properties.Settings.Default.Content2 = textBox2.Text;
                }

                else if (buttonNumber == 3)
                {
                    Properties.Settings.Default.Title3 = textBox1.Text;
                    Properties.Settings.Default.Content3 = textBox2.Text;
                }

                else if (buttonNumber == 4)
                {
                    Properties.Settings.Default.Title4 = textBox1.Text;
                    Properties.Settings.Default.Content4 = textBox2.Text;
                }

                else if (buttonNumber == 5)
                {
                    Properties.Settings.Default.Title5 = textBox1.Text;
                    Properties.Settings.Default.Content5 = textBox2.Text;
                }

                else if (buttonNumber == 6)
                {
                    Properties.Settings.Default.Title6 = textBox1.Text;
                    Properties.Settings.Default.Content6 = textBox2.Text;
                }

                else if (buttonNumber == 7)
                {
                    Properties.Settings.Default.Title7 = textBox1.Text;
                    Properties.Settings.Default.Content7 = textBox2.Text;
                }

                else if (buttonNumber == 8)
                {
                    Properties.Settings.Default.Title8 = textBox1.Text;
                    Properties.Settings.Default.Content8 = textBox2.Text;
                }

                else if (buttonNumber == 9)
                {
                    Properties.Settings.Default.Title9 = textBox1.Text;
                    Properties.Settings.Default.Content9 = textBox2.Text;
                }

                else if (buttonNumber == 10)
                {
                    Properties.Settings.Default.Title10 = textBox1.Text;
                    Properties.Settings.Default.Content10 = textBox2.Text;
                }
            }

            else if (buttonKind == 2)
            {
                if (buttonNumber == 1)
                {
                    Properties.Settings.Default.Title11 = textBox1.Text;
                    Properties.Settings.Default.Content11 = textBox2.Text;
                }

                else if (buttonNumber == 2)
                {
                    Properties.Settings.Default.Title12 = textBox1.Text;
                    Properties.Settings.Default.Content12 = textBox2.Text;
                }

                else if (buttonNumber == 3)
                {
                    Properties.Settings.Default.Title13 = textBox1.Text;
                    Properties.Settings.Default.Content13 = textBox2.Text;
                }

                else if (buttonNumber == 4)
                {
                    Properties.Settings.Default.Title14 = textBox1.Text;
                    Properties.Settings.Default.Content14 = textBox2.Text;
                }

                else if (buttonNumber == 5)
                {
                    Properties.Settings.Default.Title15 = textBox1.Text;
                    Properties.Settings.Default.Content15 = textBox2.Text;
                }

                else if (buttonNumber == 6)
                {
                    Properties.Settings.Default.Title16 = textBox1.Text;
                    Properties.Settings.Default.Content16 = textBox2.Text;
                }

                else if (buttonNumber == 7)
                {
                    Properties.Settings.Default.Title17 = textBox1.Text;
                    Properties.Settings.Default.Content17 = textBox2.Text;
                }

                else if (buttonNumber == 8)
                {
                    Properties.Settings.Default.Title18 = textBox1.Text;
                    Properties.Settings.Default.Content18 = textBox2.Text;
                }

                else if (buttonNumber == 9)
                {
                    Properties.Settings.Default.Title19 = textBox1.Text;
                    Properties.Settings.Default.Content19 = textBox2.Text;
                }

                else if (buttonNumber == 10)
                {
                    Properties.Settings.Default.Title20 = textBox1.Text;
                    Properties.Settings.Default.Content20 = textBox2.Text;
                }
            }

            else if (buttonKind == 3)
            {
                if (buttonNumber == 1)
                {
                    Properties.Settings.Default.Title21 = textBox1.Text;
                    Properties.Settings.Default.Content21 = textBox2.Text;
                }

                else if (buttonNumber == 2)
                {
                    Properties.Settings.Default.Title22 = textBox1.Text;
                    Properties.Settings.Default.Content22 = textBox2.Text;
                }

                else if (buttonNumber == 3)
                {
                    Properties.Settings.Default.Title23 = textBox1.Text;
                    Properties.Settings.Default.Content23 = textBox2.Text;
                }

                else if (buttonNumber == 4)
                {
                    Properties.Settings.Default.Title24 = textBox1.Text;
                    Properties.Settings.Default.Content24 = textBox2.Text;
                }

                else if (buttonNumber == 5)
                {
                    Properties.Settings.Default.Title25 = textBox1.Text;
                    Properties.Settings.Default.Content25 = textBox2.Text;
                }

                else if (buttonNumber == 6)
                {
                    Properties.Settings.Default.Title26 = textBox1.Text;
                    Properties.Settings.Default.Content26 = textBox2.Text;
                }

                else if (buttonNumber == 7)
                {
                    Properties.Settings.Default.Title27 = textBox1.Text;
                    Properties.Settings.Default.Content27 = textBox2.Text;
                }

                else if (buttonNumber == 8)
                {
                    Properties.Settings.Default.Title28 = textBox1.Text;
                    Properties.Settings.Default.Content28 = textBox2.Text;
                }

                else if (buttonNumber == 9)
                {
                    Properties.Settings.Default.Title29 = textBox1.Text;
                    Properties.Settings.Default.Content29 = textBox2.Text;
                }

                else if (buttonNumber == 10)
                {
                    Properties.Settings.Default.Title30 = textBox1.Text;
                    Properties.Settings.Default.Content30 = textBox2.Text;
                }
            }

            Properties.Settings.Default.Save();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


