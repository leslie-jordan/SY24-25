using System;
using System.Collections.Generic;
using System.Drawing;
using System.Dynamic;
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

        private int getindex(Button b)
        {
            string tmp = b.Name.Substring(6);
            int retval = 0;
            int.TryParse(tmp, out retval);
            return retval - 1;
        }
        private void getrc(Button b, out int r, out int c)
        {
            int i = getindex(b);
            r = i / 10 + 1;
            c = i % 10;
        }
        public void setnearby(int n)
        {
            m_nearby = n;
            m_b.Text = m_nearby.ToString();
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
            m_b.BackgroundImage = m_mineImage;
        }
        public Boolean getmine()
        {
            return m_mine;
        }
        public void setdug()
        {
            m_dug = true;
            m_b.BackColor = Color.Gray;
            if (m_mine)
            {
                m_b.BackgroundImage = m_mineImage;
            }
        }

        public Boolean getdug()
        {
            return m_dug;
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
        public Boolean getflag()
        {
            return m_flag;
        }
    }
}
