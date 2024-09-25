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
        private Image m_flagImage;
        private Image m_mineImage;
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
            m_flagImage = flagImage;
        }
        public void setmineimage(Image mineImage)
        {
            m_mineImage = mineImage;
        }
        public void setmine(Boolean b)
        { 
            m_mine = b;
        }
        public Boolean getmine()
        {
            return m_mine;
        }
        public void setdug()
        {
            m_dug = true;
            if (m_mine)
            {
                m_b.BackgroundImage = m_mineImage;
            }
        }
        public void setflag()
        {
            m_flag = !m_flag;
            m_b.BackgroundImage = m_flagImage;
            if (m_flag)
            {
                m_b.BackgroundImage = m_flagImage;
            }
            else 
            {
                m_b.BackgroundImage = null;
            }
        }
    }
}
