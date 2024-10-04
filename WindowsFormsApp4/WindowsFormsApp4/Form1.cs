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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

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
            int idx = (r - 1) * 10 + (c - 1);
            return btnGrid[idx];    
        }
    private int getIndex(Button b)
    {
        string tmp = b.Name.Substring(6);
        int retVal = 0;
        int.TryParse(tmp, out retVal);
        return retVal -1;
    }
        private void getrc(Button b, out int r, out int c)
        {
            int i = getIndex(b);
            r = i / 10 + 1;
            c = i % 10;
        }
        private void setCounts()
        {
            //for every tile on the board
            for (int r = 1; r < 11; r++)
            {
                for (int c = 1; c < 11; c++)
                {
                    getButton(r, c).BackColor = Color.Honeydew;
                }
            }
            //add one for each adjacent mine
            //set that count into the tile
        }
        private int countAdjacent(int r, int c)
        {
            int count = 0;
            if (r > 1 && c > 1)
            {
                if (tileGrid[getIndex(getButton(r - 1, c - 1))].getmine()) count++;
            }
            if (r > 1)
            {
                if (tileGrid[getIndex(getButton(r - 1, c))].getmine()) count++;
            }
            if (r > 1 && c < 10)
            {
                if (tileGrid[getIndex(getButton(r - 1, c + 1))].getmine()) count++;
            }
            if (c > 1)
            {
                if (tileGrid[getIndex(getButton(r, c - 1))].getmine()) count++;
            }
            if (c < 10)
            {
                if (tileGrid[getIndex(getButton(r, c + 1))].getmine()) count++;
            }
            if (r < 10 && c > 1)
            {
                if (tileGrid[getIndex(getButton(r + 1, c - 1))].getmine()) count++;
            }
            if (r < 10)
            {
                if (tileGrid[getIndex(getButton(r + 1, c))].getmine()) count++;
            }
            if (r < 10 && c < 10)
            {
                if (tileGrid[getIndex(getButton(r + 1, c + 1))].getmine()) count++;
            }
            return count;
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
                int count = 0;
                for (int i = 0; i < 100; i++)
                {
                    if (tileGrid[i].getdug())
                    {
                        count++;
                    }
                    if (count == 95)
                    {
                        win();
                    }
                    {
                        int r = 0;
                        int c = 0;
                        getrc(b, out r, out c);
                    }
                }
            }
            if (e.Button == MouseButtons.Left && t.getmine())
            {
                label2.Visible = true;
                for (int i = 0; i < 100; i++)
                {
                    btnGrid[i].BackColor = Color.Red;
                    btnGrid[i].BackgroundImage = null;

                }
            }
        }

        private void win()
        {
            label1.Visible = true;
            for (int i = 0; i < 100; i++)
            {
                btnGrid[i].BackColor = Color.Green;
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
            //setCounts();
            //countAdjacent(1,1);
            for (int r = 1; r < 11; r++)
            {
                for (int c = 1; c < 11; c++)
                {
                    tileGrid[getIndex(getButton(r, c))].setnearby(countAdjacent(r, c));
                }
            }
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
