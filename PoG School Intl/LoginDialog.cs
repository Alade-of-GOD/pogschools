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
    public partial class LoginDialog : Form
    {
        SetUp SU = new SetUp();
        Form1 MainForm = new Form1();
        Colors colors = new Colors();
        public LoginDialog()
        {
            InitializeComponent();
            this.ShowIcon = false;
        }

        private void minimizeThis()
        {
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
            this.ShowIcon = false;
        }

        private void labelX2_Click(object sender, EventArgs e)
        {
            SU.Show();
            minimizeThis();    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm.Show();
            minimizeThis();
        }

        private void labelX2_MouseHover(object sender, EventArgs e)
        {
            labelX2.ForeColor = Color.White;
        }

        private void labelX2_MouseLeave(object sender, EventArgs e)
        {
            labelX2.ForeColor = Color.DimGray;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            if (MainForm.Visible != true)
            {
                this.Show();
                this.ShowIcon = false;
                this.ShowInTaskbar = false;
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            colors.CloseHover(pictureBox2);
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            colors.CloseOut(pictureBox2);
        }
    }
}
