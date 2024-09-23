using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    internal class tile
    {
        Button m_b;
        private bool m_flag;
        private bool m_dug;
        private bool m_mine;
        private int m_nearby;
        private Image m_flagimage;
        private Image m_mineimage;
        public tile(Button b)
        {
            m_b = b;
            m_b.BackColor = Color.Green;
        }
        public void setnearby(int n)
        {
            m_nearby = n;
        }
        public void setflagimage(Image flagImage)
        {
            m_flagimage = flagImage;
        }
        public void setmineimage(Image mineImage)
        {
            m_mineimage = mineImage;
        }
        public void setmine(Boolean b)
        { 
            m_mine = b; 
            m_b.BackgroundImage = m_mineimage;
        }
        public void setdug(Boolean b)
        {
            m_dug = b;
        }
        public void setflag(Boolean b)
        {
            m_flag = b;
            m_b.BackgroundImage = m_flagimage;
        }
    }
}
