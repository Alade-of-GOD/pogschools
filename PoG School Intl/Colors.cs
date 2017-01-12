using DevComponents.DotNetBar;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoG_School_Intl
{
    class Colors
    {

        public void LabelHover(LabelX lX)
        {
            lX.BackColor = Color.Blue;
            lX.ForeColor = Color.Silver;
        }

        public void LabelOut(LabelX lX)
        {
            lX.BackColor = Color.FromArgb(78, 88, 222);
            lX.ForeColor = Color.White;
        }
        
        public void LabelNavHover(LabelX lX)
        {
            lX.ForeColor = Color.White;
        }

        public void LabelNavOut(LabelX lX)
        {
            lX.ForeColor = Color.DimGray;
        }

        public void CloseHover(PictureBox pB)
        {
            pB.BackColor = Color.Red;
        }

        public void CloseOut(PictureBox pB)
        {
            pB.BackColor = Color.Black;
        }
    }
}
