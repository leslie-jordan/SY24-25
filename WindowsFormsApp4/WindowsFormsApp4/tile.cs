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
        int m_nearby;
        public tile(Button b)
        {
            m_b = b;
            m_b.BackColor = Color.Green;
        }
        public void setmine(Boolean b)
        { 
            m_mine = b; 
        }
        public void setdug(Boolean b)
        {
            m_dug = b;
        }
        public void setflag(Boolean b)
        {
            m_flag = b;
        }
    }
}
