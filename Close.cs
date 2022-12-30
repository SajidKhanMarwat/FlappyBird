using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBird
{
    public partial class Close : Form
    {
        public Close()
        {
            InitializeComponent();
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            
        }

        private void pbRestart_Click(object sender, EventArgs e)
        {
            FPBird fPBird = new FPBird();
            fPBird.Show();
            this.Hide();
        }

        private void lblYes_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FPBird fPBird = new FPBird();
            fPBird.Show();
            this.Hide();
        }

        private void lblNo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }
    }
}
