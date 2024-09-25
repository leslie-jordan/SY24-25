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
            reset();
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
            tile t = tileGrid[getIndex(b)];
            if (e.Button == MouseButtons.Right)
            {
                t.setflag();
            }
            else
            {
                t.setdug();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getIndex(sender as Button);
        }

        private void button101_Click(object sender, EventArgs e)
        {
            reset();
        }
   
        private void reset()
        {
            for (int i = 0; i < 100; i++)
            {
                btnGrid[i] = (Button)Controls["button" + (i + 1)];
                tileGrid[i] = new tile(btnGrid[i]);
                tileGrid[i].setflagimage(flagpictureBox.Image);
                tileGrid[i].setmineimage(minepictureBox.Image);
                //tileGrid[i].setflag(true);
            }
            createmines(5);
        }
        private void createmines(int numMines)
        {
            int mineCount = 0;
            //until we have enough mines
            while (mineCount < numMines)
            {
                //generate number 1-100
                int rNum = random.Next(0, 101);
                if (tileGrid[rNum].getmine() == false)
                {
                    mineCount++;
                    tileGrid[rNum].setmine(true);
                }
                //set mine on that tile if it doesn't already have a mine
            }
        }
    }
}
