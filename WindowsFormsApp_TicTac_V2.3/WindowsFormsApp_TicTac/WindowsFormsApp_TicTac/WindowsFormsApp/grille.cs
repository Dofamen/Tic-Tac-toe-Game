using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.IO;


namespace WindowsFormsApp
{
    class grille
    {
        private Rect[,] grid; //=new Rect [3,3];
        public VAR histVar;
        private uint optimiser = 0;

        private string namePlayerA = "A";
        private string namePlayerB = "B";

        public string NamePlayerA {set => namePlayerA = value; }
        public string NamePlayerB {set => namePlayerB = value; }

        public grille(int L, Point start, ref MetroFramework.Controls.MetroTextBox txtB)
        {
            grid = new Rect[3,3];
            for (int i = 0; i < 3; i++){
                for (int j = 0; j < 3; j++){
                    grid[i, j] = new Rect(start.X + j * L, start.Y + i * L, 100);
                }
                
            }
            

            histVar = new VAR(ref txtB);

        }

        public bool SeachRect(Point p, out int ix , out int jy)
        {
            ix = -1;
            jy = -1;
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    if (grid[i, j].PointInRect(p)) { ix = i; jy = j; return true; } ;

            return false ;
        }

        public bool isSafeToPlay(int i, int j)
        {
            return grid[i, j].isEmpty();
        }

        public bool PlayerB(ref Graphics g, Point p, bool machine, int x=-1, int y=-1)
        {
            int i = x, j = y;
            if (!machine)
            {
                bool r = SeachRect(p, out i, out j);
                if (!r || !isSafeToPlay(i, j))
                {
                    validatePlayerEntry('B');
                    return false;
                }

            }
            
            grid[i, j].rond(ref g);
            histVar.WriteHistoVAR("B", i, j);
            return true;
            
        }
        public bool PlayerA( ref Graphics g, Point p, bool machine, int x=-1, int y=-1)
        {
            int i=x, j=y;
            if (!machine)
            {
                bool r = SeachRect(p, out i, out j);
                if (!r || !isSafeToPlay(i, j))
                {
                    validatePlayerEntry('A');
                    return false;
                }

            }
            
        grid[i, j].Croix(ref g);
        histVar.WriteHistoVAR("A", i, j);
        return true;
            
        }
        public void dessiner(ref Graphics g)
        {
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    grid[i, j].desiner(ref g);

        }

        public void ResetGame(UneForme f)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    grid[i, j].reset();
                }
                    
            }
            this.histVar.ResetVAR();
            f.Refresh();
        }


        

            // is winner
        public int IsWinner()
        {

            // player A
            if (
                (grid[0, 0].PlayerA()) &&
                (grid[1, 0].PlayerA()) &&
                (grid[2, 0].PlayerA())
                )
                return 1;

            if (
                (grid[0, 1].PlayerA()) &&
                (grid[1, 1].PlayerA()) &&
                (grid[2, 1].PlayerA())
                )
                return 1;

            if (
                (grid[0, 2].PlayerA()) &&
                (grid[1, 2].PlayerA()) &&
                (grid[2, 2].PlayerA())
                )
                return 1;

            if (
                            (grid[0, 0].PlayerA()) &&
                            (grid[0, 1].PlayerA()) &&
                            (grid[0, 2].PlayerA())
                            )
                return 1;

            if (
                (grid[1, 0].PlayerA()) &&
                (grid[1, 1].PlayerA()) &&
                (grid[1, 2].PlayerA())
                )
                return 1;

            if (
                (grid[2, 0].PlayerA()) &&
                (grid[2, 1].PlayerA()) &&
                (grid[2, 2].PlayerA())
                )
                return 1;


            // player B

            if (
                (grid[0, 0].PlayerB()) &&
                (grid[1, 0].PlayerB()) &&
                (grid[2, 0].PlayerB())
                )
                return -1;

            if (
                (grid[0, 1].PlayerB()) &&
                (grid[1, 1].PlayerB()) &&
                (grid[2, 1].PlayerB())
                )
                return -1;

            if (
                (grid[0, 2].PlayerB()) &&
                (grid[1, 2].PlayerB()) &&
                (grid[2, 2].PlayerB())
                )
                return -1;

            if (
                            (grid[0, 0].PlayerB()) &&
                            (grid[0, 1].PlayerB()) &&
                            (grid[0, 2].PlayerA())
                            )
                return -1;

            if (
                (grid[1, 0].PlayerB()) &&
                (grid[1, 1].PlayerB()) &&
                (grid[1, 2].PlayerB())
                )
                return -1;

            if (
                (grid[2, 0].PlayerB()) &&
                (grid[2, 1].PlayerB()) &&
                (grid[2, 2].PlayerB())
                )
                return -1;






            // player A
            if (
                (grid[0, 0].PlayerA()) &&
                (grid[1, 1].PlayerA()) &&
                (grid[2, 2].PlayerA())
                )
                return 1;

            // player A
            if (
                (grid[0, 2].PlayerA()) &&
                (grid[1, 1].PlayerA()) &&
                (grid[2, 0].PlayerA())
                )
                return 1;


            // player B
            if (
                (grid[0, 2].PlayerB()) &&
                (grid[1, 1].PlayerB()) &&
                (grid[2, 0].PlayerB())
                )
                return -1;

            // player B
            if (
                (grid[0, 0].PlayerB()) &&
                (grid[1, 1].PlayerB()) &&
                (grid[2, 2].PlayerB())
                )
                return -1;


            return 0;
}

        public bool isMovesLeft()
        {
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    if (!grid[i,j].PlayerA() && !grid[i,j].PlayerB())
                        return true;
            return false;
        }

        private void validatePlayerEntry(char player){


            string message = "You did not click on the gri. Cancel this operation?";
            string caption = "Error Detected in Input given by Player "+player.ToString();
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result;

            // Displays the MessageBox.
            result = MessageBox.Show(message, caption, buttons);

            
        }

//

    public bool CheckForGameOver(UneForme f)
        {
            if (++this.optimiser >= 5) // Check for Game Over when the 5th case played
            {
                string messageA = "Player A Wins !";
                string messageB = "Player B Wins !";
                string caption = "Ending Game bye !";
                string messageDraw = " it's a Draw";
                MessageBoxButtons buttons = MessageBoxButtons.OK;


                // Displays the MessageBox.
                // result = MessageBox.Show(messageA, caption, buttons);
                int nWin = this.IsWinner();
                if (nWin == 1)
                {
                    histVar.WriteWiner("A");
                    MessageBox.Show(messageA, caption, buttons);
                    //this.ResetGame(f);
                    return true;
                }
                else if (nWin == -1)
                {
                    histVar.WriteWiner("B");
                    MessageBox.Show(messageB, caption, buttons);
                    //this.ResetGame(f);
                    return true;
                }
                else if (!this.isMovesLeft())
                {
                    MessageBox.Show(messageDraw, caption, buttons);
                    //this.ResetGame(f);
                    return true;
                }
            }

            return false;

            }

        //public void resetRectPos(int i, int j)
        //{
        //    grid[i, j].reset();
        //}
        

    }


}
