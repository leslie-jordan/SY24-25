using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        int totalA = 0;
        int totalB = 0;
        int totalC = 0;
        int[] bits = new int[8];
        int[] bitsB = new int[8];
        int[] bitsC = new int[8];
        public Form1()
        {
            InitializeComponent();
        }
        private void Calc()
        {
        totalA = 0;
        if (bits[0] != 0) { totalA += 1; }
        if (bits[1] != 0) { totalA += 2; }
        if (bits[2] != 0) { totalA += 4; }
        if (bits[3] != 0) { totalA += 8; }
        if (bits[4] != 0) { totalA += 16; }
        if (bits[5] != 0) { totalA += 32; }
        if (bits[6] != 0) { totalA += 64; }
        if (bits[7] != 0) { totalA += 128; }
        label2.Text = totalA.ToString();
        }
        private void CalcB()
        {
            totalB = 0;
            if (bitsB[0] != 0) { totalB += 1; }
            if (bitsB[1] != 0) { totalB += 2; }
            if (bitsB[2] != 0) { totalB += 4; }
            if (bitsB[3] != 0) { totalB += 8; }
            if (bitsB[4] != 0) { totalB += 16; }
            if (bitsB[5] != 0) { totalB += 32; }
            if (bitsB[6] != 0) { totalB += 64; }
            if (bitsB[7] != 0) { totalB += 128; }
            label3.Text = totalB.ToString();
        }
        private void CalcC()
        {
            totalC = 0;
            if (bitsC[0] != 0) { totalC += 1; }
            if (bitsC[1] != 0) { totalC += 2; }
            if (bitsC[2] != 0) { totalC += 4; }
            if (bitsC[3] != 0) { totalC += 8; }
            if (bitsC[4] != 0) { totalC += 16; }
            if (bitsC[5] != 0) { totalC += 32; }
            if (bitsC[6] != 0) { totalC += 64; }
            if (bitsC[7] != 0) { totalC += 128; }
            label4.Text = totalC.ToString();
        }

        private void Bit8_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void bit1_MouseDown(object sender, MouseEventArgs e)
        {
            if (((TextBox)(sender)).Text == "1")
                ((TextBox)(sender)).Text = "0";
            else
                ((TextBox)(sender)).Text = "1";

            //bit1
            if (bit1.Text == "1")
                bits[0] = 1;
            else
                bits[0] = 0;
            //bit2
            if (bit2.Text == "1")
                bits[1] = 1;
            else
                bits[1] = 0;
            //bit3
            if (bit3.Text == "1")
                bits[2] = 1;
            else
                bits[2] = 0;
            //bit4
            if (bit4.Text == "1")
                bits[3] = 1;
            else
                bits[3] = 0;
            //bit5
            if (bit5.Text == "1")
                bits[4] = 1;
            else
                bits[4] = 0;
            //bit6
            if (bit6.Text == "1")
                bits[5] = 1;
            else
                bits[5] = 0;
            //bit7
            if (bit7.Text == "1")
                bits[6] = 1;
            else
                bits[6] = 0;
            //bit8
            if (bit8.Text == "1")
                bits[7] = 1;
            else
                bits[7] = 0;
            //bitB1
            if (bitB1.Text == "1")
                bits[0] = 1;
            else
                bits[0] = 0;
            //bitB2
            if (bitB2.Text == "1")
                bitsB[1] = 1;
            else
                bitsB[1] = 0;
            //bitB3
            if (bitB3.Text == "1")
                bitsB[2] = 1;
            else
                bitsB[2] = 0;
            //bitB4
            if (bitB4.Text == "1")
                bitsB[3] = 1;
            else
                bitsB[3] = 0;
            //bitB5
            if (bitB5.Text == "1")
                bitsB[4] = 1;
            else
                bitsB[4] = 0;
            //bitB6
            if (bitB6.Text == "1")
                bitsB[5] = 1;
            else
                bitsB[5] = 0;
            //bitB7
            if (bitB7.Text == "1")
                bitsB[6] = 1;
            else
                bitsB[6] = 0;
            //bitB8
            if (bitB8.Text == "1")
                bitsB[7] = 1;
            else
                bitsB[7] = 0;
            //bitC1
            if (bitC1.Text == "1")
                bitsC[0] = 1;
            else
                bitsC[0] = 0;
            //bitC2
            if (bitC2.Text == "1")
                bitsC[1] = 1;
            else
                bitsC[1] = 0;
            //bitC3
            if (bitC3.Text == "1")
                bitsC[2] = 1;
            else
                bitsC[2] = 0;
            //bitC4
            if (bitC4.Text == "1")
                bitsC[3] = 1;
            else
                bitsC[3] = 0;
            //bitC5
            if (bitC5.Text == "1")
                bitsC[4] = 1;
            else
                bitsC[4] = 0;
            //bitC6
            if (bitC6.Text == "1")
                bitsC[5] = 1;
            else
                bitsC[5] = 0;
            //bitC7
            if (bitC7.Text == "1")
                bitsC[6] = 1;
            else
                bitsC[6] = 0;
            //bitC8
            if (bitC8.Text == "1")
                bitsC[7] = 1;
            else
                bitsC[7] = 0;
            Calc();
            CalcB();
            CalcC();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < bits.Length; i++)
            {
                bits[i] = 0;
            }
            Update();
        }

        private void Update()
        {
            bit1.Text = (bits[0] == 1 ? "1" : "0");
            bit2.Text = (bits[1] == 1 ? "1" : "0");
            bit3.Text = (bits[2] == 1 ? "1" : "0");
            bit4.Text = (bits[3] == 1 ? "1" : "0");
            bit5.Text = (bits[4] == 1 ? "1" : "0");
            bit6.Text = (bits[5] == 1 ? "1" : "0");
            bit7.Text = (bits[6] == 1 ? "1" : "0");
            bit8.Text = (bits[7] == 1 ? "1" : "0");
            Calc();
        }
        private void UpdateB()
        {
            bitB1.Text = (bitsB[0] == 1 ? "1" : "0");
            bitB2.Text = (bitsB[1] == 1 ? "1" : "0");
            bitB3.Text = (bitsB[2] == 1 ? "1" : "0");
            bitB4.Text = (bitsB[3] == 1 ? "1" : "0");
            bitB5.Text = (bitsB[4] == 1 ? "1" : "0");
            bitB6.Text = (bitsB[5] == 1 ? "1" : "0");
            bitB7.Text = (bitsB[6] == 1 ? "1" : "0");
            bitB8.Text = (bitsB[7] == 1 ? "1" : "0");
            CalcB();
        }
        private void UpdateC()
        {
            bitC1.Text = (bitsC[0] == 1 ? "1" : "0");
            bitC2.Text = (bitsC[1] == 1 ? "1" : "0");
            bitC3.Text = (bitsC[2] == 1 ? "1" : "0");
            bitC4.Text = (bitsC[3] == 1 ? "1" : "0");
            bitC5.Text = (bitsC[4] == 1 ? "1" : "0");
            bitC6.Text = (bitsC[5] == 1 ? "1" : "0");
            bitC7.Text = (bitsC[6] == 1 ? "1" : "0");
            bitC8.Text = (bitsC[7] == 1 ? "1" : "0");
            CalcC();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < bitsB.Length; i++)
            {
                bitsB[i] = 0;
            }
            UpdateB();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < bitsC.Length; i++)
            {
                bitsC[i] = 0;
            }
            UpdateC();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < bits.Length; i++)
            {
                bits[i] = 0;
            }
            Update();
            for (int i = 0; i < bitsB.Length; i++)
            {
                bitsB[i] = 0;
            }
            UpdateB();
            for (int i = 0; i < bitsC.Length; i++)
            {
                bitsC[i] = 0;
            }
            UpdateC();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < bits.Length; i++)
            {

            }
        }
    }
    }
