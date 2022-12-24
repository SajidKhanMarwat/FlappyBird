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
    public partial class FPBird : Form
    {
        public FPBird()
        {
            InitializeComponent();


            //this.MaximumSize = new System.Drawing.Size(300, 500);

            this.MaximizeBox = false;

        }

        private void lblExit_Click(object sender, EventArgs e)
        {

            //MessageBox.Show("Are you sure?");

            DialogResult = MessageBox.Show("Are you sure to exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (DialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }            
        }
    }
}
