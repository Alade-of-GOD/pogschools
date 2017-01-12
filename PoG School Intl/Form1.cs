using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoG_School_Intl
{
    public partial class Form1 : Form
    {
        Colors colors = new Colors();
        public Form1()
        {
            InitializeComponent();
            labelX5.Text = dateTimePicker1.Value.ToLongDateString();
            //.Text = dateTimePicker1.Value.ToLongTimeString();
            
        }
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelX14_MouseHover(object sender, EventArgs e)
        {
            colors.LabelHover(labelX14);
        }

        private void labelX14_MouseLeave(object sender, EventArgs e)
        {
            colors.LabelOut(labelX14);
        }

        private void labelX16_MouseHover(object sender, EventArgs e)
        {
            colors.LabelHover(labelX16);
        }

        private void labelX16_MouseLeave(object sender, EventArgs e)
        {
            colors.LabelOut(labelX16);
        }

        private void labelX15_MouseHover(object sender, EventArgs e)
        {
            colors.LabelHover(labelX15);
        }

        private void labelX15_MouseLeave(object sender, EventArgs e)
        {
            colors.LabelOut(labelX15);
        }

        private void labelX17_MouseHover(object sender, EventArgs e)
        {
            colors.LabelHover(labelX17);
        }

        private void labelX17_MouseLeave(object sender, EventArgs e)
        {
            colors.LabelOut(labelX17);
        }

        private void labelX18_MouseHover(object sender, EventArgs e)
        {
            colors.LabelHover(labelX18);
        }

        private void labelX18_MouseLeave(object sender, EventArgs e)
        {
            colors.LabelOut(labelX18);
        }

        private void labelX19_MouseHover(object sender, EventArgs e)
        {
            colors.LabelHover(labelX19);
        }

        private void labelX19_MouseLeave(object sender, EventArgs e)
        {
            colors.LabelOut(labelX19);
        }

        private void metroTileItem9_Click(object sender, EventArgs e)
        {

        }

        private void labelX32_MouseHover(object sender, EventArgs e)
        {
            colors.LabelHover(labelX32);
        }

        private void labelX32_MouseLeave(object sender, EventArgs e)
        {
            colors.LabelOut(labelX32);
        }

        private void labelX33_MouseHover(object sender, EventArgs e)
        {
            colors.LabelHover(labelX33);
        }

        private void labelX33_MouseLeave(object sender, EventArgs e)
        {
            colors.LabelOut(labelX33);
        }

        private void labelX34_MouseHover(object sender, EventArgs e)
        {
            colors.LabelHover(labelX34);
        }

        private void labelX34_MouseLeave(object sender, EventArgs e)
        {
            colors.LabelOut(labelX34);
        }

        private void labelX35_MouseHover(object sender, EventArgs e)
        {
            colors.LabelHover(labelX35);
        }

        private void labelX35_MouseLeave(object sender, EventArgs e)
        {
            colors.LabelOut(labelX35);
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox17_MouseHover(object sender, EventArgs e)
        {
            pictureBox17.BackColor = SystemColors.ControlDark;
        }

        private void pictureBox17_MouseLeave(object sender, EventArgs e)
        {
            pictureBox17.BackColor = SystemColors.ActiveCaptionText;
        }

        private void panel8_MouseHover(object sender, EventArgs e)
        {
            panel8.BackColor = Color.FromArgb(40, 40, 236);
        }

        private void panel8_MouseLeave(object sender, EventArgs e)
        {
            panel8.BackColor = Color.MediumBlue;
        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            panel8_MouseHover(sender, e);
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            panel8_MouseLeave(sender, e);
        }

        private void labelX20_MouseHover(object sender, EventArgs e)
        {
            panel8_MouseHover(sender, e);
        }

        private void labelX20_MouseLeave(object sender, EventArgs e)
        {
            panel8_MouseLeave(sender, e);
        }

        private void panel9_MouseHover(object sender, EventArgs e)
        {
            panel9.BackColor = Color.Gold;
        }

        private void panel9_MouseLeave(object sender, EventArgs e)
        {
            panel9.BackColor = Color.Orange;
        }

        private void labelX21_MouseHover(object sender, EventArgs e)
        {
            panel9_MouseHover(sender, e);
        }

        private void labelX21_MouseLeave(object sender, EventArgs e)
        {
            panel9_MouseLeave(sender, e);
        }

        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            panel9_MouseHover(sender, e);
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            panel9_MouseLeave(sender, e);
        }

        private void panel10_MouseHover(object sender, EventArgs e)
        {
            panel10.BackColor = Color.FromArgb(128, 83, 232);
        }

        private void panel10_MouseLeave(object sender, EventArgs e)
        {
            panel10.BackColor = Color.FromArgb(103, 90, 222);
        }

        private void labelX22_MouseHover(object sender, EventArgs e)
        {
            panel10_MouseHover(sender, e);
        }

        private void labelX22_MouseLeave(object sender, EventArgs e)
        {
            panel10_MouseLeave(sender, e);
        }

        private void pictureBox7_MouseHover(object sender, EventArgs e)
        {
            panel10_MouseHover(sender, e);
        }

        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            panel10_MouseLeave(sender, e);
        }

        private void panel11_MouseHover(object sender, EventArgs e)
        {
            panel11.BackColor = Color.FromArgb(35, 35, 35);
        }

        private void panel11_MouseLeave(object sender, EventArgs e)
        {
            panel11.BackColor = Color.Black;
        }

        private void labelX23_MouseHover(object sender, EventArgs e)
        {
            panel11_MouseHover(sender, e);
        }

        private void labelX23_MouseLeave(object sender, EventArgs e)
        {
            panel11_MouseLeave(sender, e);
        }

        private void pictureBox8_MouseHover(object sender, EventArgs e)
        {
            panel11_MouseHover(sender, e);
        }

        private void pictureBox8_MouseLeave(object sender, EventArgs e)
        {
            panel11_MouseLeave(sender, e);
        }

        private void panel12_MouseHover(object sender, EventArgs e)
        {
            panel12.BackColor = Color.FromArgb(98, 222, 75);
        }

        private void panel12_MouseLeave(object sender, EventArgs e)
        {
            panel12.BackColor = Color.FromArgb(37, 197, 49);
        }

        private void labelX24_MouseHover(object sender, EventArgs e)
        {
            panel12_MouseHover(sender, e);
        }

        private void labelX24_MouseLeave(object sender, EventArgs e)
        {
            panel12_MouseLeave(sender, e);
        }

        private void pictureBox9_MouseHover(object sender, EventArgs e)
        {
            panel12_MouseHover(sender, e);
        }

        private void pictureBox9_MouseLeave(object sender, EventArgs e)
        {
            panel12_MouseLeave(sender, e);
        }

        private void panel13_MouseHover(object sender, EventArgs e)
        {
            panel13.BackColor = Color.FromArgb(191, 91, 213);
        }

        private void panel13_MouseLeave(object sender, EventArgs e)
        {
            panel13.BackColor = Color.FromArgb(192, 0, 192);
        }

        private void labelX25_MouseHover(object sender, EventArgs e)
        {
            panel13_MouseHover(sender, e);
        }

        private void labelX25_MouseLeave(object sender, EventArgs e)
        {
            panel13_MouseLeave(sender, e);
        }

        private void pictureBox10_MouseHover(object sender, EventArgs e)
        {
            panel13_MouseHover(sender, e);
        }

        private void pictureBox10_MouseLeave(object sender, EventArgs e)
        {
            panel13_MouseLeave(sender, e);
        }

        private void panel14_MouseHover(object sender, EventArgs e)
        {
            panel14.BackColor = Color.FromArgb(111, 27, 122);
        }

        private void panel14_MouseLeave(object sender, EventArgs e)
        {
            panel14.BackColor = Color.FromArgb(64, 0, 64);
        }

        private void labelX26_MouseHover(object sender, EventArgs e)
        {
            panel14_MouseHover(sender, e);
        }

        private void labelX26_MouseLeave(object sender, EventArgs e)
        {
            panel14_MouseLeave(sender, e);
        }

        private void pictureBox11_MouseHover(object sender, EventArgs e)
        {
            panel14_MouseHover(sender, e);
        }

        private void pictureBox11_MouseLeave(object sender, EventArgs e)
        {
            panel14_MouseLeave(sender, e);
        }

        private void panel15_MouseHover(object sender, EventArgs e)
        {
            panel15.BackColor = Color.LimeGreen;
        }

        private void panel15_MouseLeave(object sender, EventArgs e)
        {
            panel15.BackColor = Color.DarkGreen;
        }

        private void labelX27_MouseHover(object sender, EventArgs e)
        {
            panel15_MouseHover(sender, e);
        }

        private void labelX27_MouseLeave(object sender, EventArgs e)
        {
            panel15_MouseLeave(sender, e);
        }

        private void pictureBox12_MouseHover(object sender, EventArgs e)
        {
            panel15_MouseHover(sender, e);
        }

        private void pictureBox12_MouseLeave(object sender, EventArgs e)
        {
            panel15_MouseLeave(sender, e);
        }

        private void panel16_MouseHover(object sender, EventArgs e)
        {
            panel16.BackColor = Color.MediumTurquoise;
        }

        private void panel16_MouseLeave(object sender, EventArgs e)
        {
            panel16.BackColor = Color.LightSeaGreen;
        }

        private void labelX28_MouseHover(object sender, EventArgs e)
        {
            panel16_MouseHover(sender, e);
        }

        private void labelX28_MouseLeave(object sender, EventArgs e)
        {
            panel16_MouseLeave(sender, e);
        }

        private void pictureBox13_MouseHover(object sender, EventArgs e)
        {
            panel16_MouseHover(sender, e);
        }

        private void pictureBox13_MouseLeave(object sender, EventArgs e)
        {
            panel16_MouseLeave(sender, e);
        }

        private void panel17_MouseHover(object sender, EventArgs e)
        {
            panel17.BackColor = Color.Firebrick;
        }

        private void panel17_MouseLeave(object sender, EventArgs e)
        {
            panel17.BackColor = Color.DarkRed;
        }

        private void labelX29_MouseHover(object sender, EventArgs e)
        {
            panel17_MouseHover(sender, e);
        }

        private void labelX29_MouseLeave(object sender, EventArgs e)
        {
            panel17_MouseLeave(sender, e);
        }

        private void pictureBox14_MouseHover(object sender, EventArgs e)
        {
            panel17_MouseHover(sender, e);
        }

        private void pictureBox14_MouseLeave(object sender, EventArgs e)
        {
            panel17_MouseLeave(sender, e);
        }

        private void panel18_MouseHover(object sender, EventArgs e)
        {
            panel18.BackColor = Color.FromArgb(55, 141, 159);
        }

        private void panel18_MouseLeave(object sender, EventArgs e)
        {
            panel18.BackColor = Color.FromArgb(23, 78, 94);
        }

        private void labelX30_MouseHover(object sender, EventArgs e)
        {
            panel18_MouseHover(sender, e);
        }

        private void labelX30_MouseLeave(object sender, EventArgs e)
        {
            panel18_MouseLeave(sender, e);
        }

        private void pictureBox15_MouseHover(object sender, EventArgs e)
        {
            panel18_MouseHover(sender, e);
        }

        private void pictureBox15_MouseLeave(object sender, EventArgs e)
        {
            panel18_MouseLeave(sender, e);
        }

        private void panel19_MouseHover(object sender, EventArgs e)
        {
            panel19.BackColor = Color.FromArgb(131, 214, 39);
        }

        private void panel19_MouseLeave(object sender, EventArgs e)
        {
            panel19.BackColor = Color.Olive;
        }

        private void labelX31_MouseHover(object sender, EventArgs e)
        {
            panel19_MouseHover(sender, e);
        }

        private void labelX31_MouseLeave(object sender, EventArgs e)
        {
            panel19_MouseLeave(sender, e);
        }

        private void pictureBox16_MouseHover(object sender, EventArgs e)
        {
            panel19_MouseHover(sender, e);
        }

        private void pictureBox16_MouseLeave(object sender, EventArgs e)
        {
            panel19_MouseLeave(sender, e);
        }

        private void labelX3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void labelX2_MouseHover(object sender, EventArgs e)
        {
            colors.LabelNavHover(labelX2);
        }

        private void labelX2_MouseLeave(object sender, EventArgs e)
        {
            colors.LabelNavOut(labelX2);
        }

        private void labelX4_MouseHover(object sender, EventArgs e)
        {
            colors.LabelNavHover(labelX4);
        }

        private void labelX4_MouseLeave(object sender, EventArgs e)
        {
            colors.LabelNavOut(labelX4);
        }

        private void labelX3_MouseHover(object sender, EventArgs e)
        {
            colors.LabelNavHover(labelX3);
        }

        private void labelX3_MouseLeave(object sender, EventArgs e)
        {
            colors.LabelNavOut(labelX3);
        }
    }
}
