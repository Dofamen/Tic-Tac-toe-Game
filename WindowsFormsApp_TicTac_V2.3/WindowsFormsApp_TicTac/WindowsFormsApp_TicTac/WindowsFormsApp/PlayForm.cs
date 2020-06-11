using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class PlayForm : MetroFramework.Forms.MetroForm
    {
        public PlayForm()
        {
            InitializeComponent();
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    UneForme F1 = new UneForme(this);
        //    F1.Show();
        //    this.Hide();
        //}

        private void BtnExit_Click(object sender, EventArgs e)
        {
                
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PlayForm_Load(object sender, EventArgs e)
        {

        }

        private void BtnP2P_Click(object sender, EventArgs e)
        {
            UneForme F1 = new UneForme(this,false);
            F1.Show();
            this.Hide();
        }

        private void BtnBunifExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnPlay2Comp_Click(object sender, EventArgs e)
        {
            UneForme F1 = new UneForme(this, true);
            F1.Show();
            this.Hide();
        }
    }
}
