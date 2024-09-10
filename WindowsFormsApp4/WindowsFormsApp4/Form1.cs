using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        Button[] btnGrid = new Button[100];
        tile[] tileGrid  = new tile[100];
        public Form1()
        {
            InitializeComponent();

            for (int i = 0; i < 100; i++)
            {
                btnGrid[i] = (Button)Controls["button" +(i + 1)];
                tileGrid[i] = new tile(btnGrid[i]);
                btnGrid[i].BackColor = Color.Green;
            }
        }
        private Button getButton(int r, int c)
        {
        return (Button)getButton(r, c);
        }
    private int getIndex(Button b)
    {
        string tmp = b.Name.Substring(6);
        int retVal = 0;
        int.TryParse(tmp, out retVal);
        return retVal -1;
    }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            Button b = sender as Button;
            b.BackColor = Color.Red;
            /*if (e.Button == MouseButtons.Right)
            {
                if (!flag)
                {
                    button.BackgroundImage = pictureBox1.Image;

                }
                else
                {
                    button.BackgroundImage = null;
                }
                flag = !flag;
                if (e.Button == MouseButtons.Left)
                {
                    button1.BackgroundImage = pictureBox2.Image;
                }

            }*/
        }

        private void Form1_Load(object sender, EventArgs e)
        {
       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getIndex(sender as Button);
        }
    }
}
