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
    public partial class StartForm : Form
    {
        public StartForm()
        {
            
            InitializeComponent();
            btnStart.Hide();

            

            //Application.Run(new FPBird());

        }

        private void LoaderEvent(object sender, EventArgs e)
        {

            progressBar.Value++;

                if (progressBar.Value == 100)
                {
                    btnStart.Show();
                    loader.Stop(); //timer
                }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            FPBird fBird = new FPBird();
            this.Hide();
            fBird.Show();
        }
    }
}
