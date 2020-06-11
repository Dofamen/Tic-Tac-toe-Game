using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    class VAR
    {
        private String fileName;
        private MetroFramework.Controls.MetroTextBox TxtVar;
    
       public  VAR(ref MetroFramework.Controls.MetroTextBox txtB)
        {
            this.TxtVar = txtB;
            this.preConstructor();
        }

        private void preConstructor()
        {
            fileName = "VAR" + DateTime.Now.ToString("yyyy-MM-dd-HH-mm") + ".txt";

            string v = "VAR GAME Tic Tac Toe , Timer: " + DateTime.Now.ToString() + "\n";
            this.TxtVar.Text = v;
            File.WriteAllText(fileName, v);

        }
        public void WriteHistoVAR(string player, int i, int j)
        {

            string txt = "Player " + player + " move to the slot (" + i.ToString() + ", " + j.ToString() + ")" + "\n";

            this.TxtVar.Text += txt.ToString();
            using (StreamWriter sw = File.AppendText(this.fileName))
            {
                sw.WriteLine(txt);
            }
        }
        public void WriteWiner(string player)
        {
            string win = "Player " + player + " is THE WINNER !!!!";

            this.TxtVar.Text += win.ToString();
            using (StreamWriter sw = File.AppendText(this.fileName))
            {
                sw.WriteLine(win);
            }
        }

        public void ResetVAR()
        {
            this.preConstructor();
        }
    }
}
