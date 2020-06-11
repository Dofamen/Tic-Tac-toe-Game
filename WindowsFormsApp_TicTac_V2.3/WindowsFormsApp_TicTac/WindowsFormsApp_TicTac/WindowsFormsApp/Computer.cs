using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.IO;

namespace WindowsFormsApp
{
    class Computer
    {
        private grille game;
        private List<Point2D> LstPoint;


        public Computer(ref grille gg)
        {
            LstPoint = new List<Point2D>();
            this.game = gg;
            this.preConstructorCmp();
        }

        /// <summary>
        /// Choisir une Case dont le computer ( robot ) joue. en mode Aleatoire
        /// </summary>
        /// <param name="g"></param>
        public void RandomMove(ref Graphics g)
        {
            int index;
            Random rdm = new Random();
            do
            {
                this.FilterGrille();
                index = rdm.Next(this.LstPoint.Count());
            }
            while (this.game.isMovesLeft() && !this.game.PlayerB(ref g, new Point(0,0), true, LstPoint[index].x, LstPoint[index].y));  // l'ordinateur joue dans n'importe quel slot.
        }

        /// <summary>
        ///  Sumppression des points inclus des Cases que n'ont pas l'accés à jouer.
        /// </summary>
        private void FilterGrille()
        {
            for (int i = 0; i < LstPoint.Count; i++)
            {
                if (!this.game.isSafeToPlay(LstPoint[i].x, LstPoint[i].y))
                {
                    LstPoint.RemoveAt(i);
                }
            }
     
        }

        class Point2D
        {
            public int x,y;
            public Point2D(int x , int y)
            {
                this.x = x;
                this.y = y;
            }
        }

        private void preConstructorCmp()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    LstPoint.Add(new Point2D(i, j));
                }
            }
        }

        public void ResetComputer()
        {
            this.preConstructorCmp();
        }

        //   class Move
        //   {
        //       public int row, col;
        //   }

        //   private int evaluate(grille b)
        //   {
        //       if (b.IsWinner() == 1)
        //       {
        //           return 10;
        //       }
        //       else if (b.IsWinner() == -1)
        //       {
        //           return -10;
        //       }

        //       return 0;
        //   }

        //   private int minimax(grille board,ref Graphics g ,int depth, bool isMax)
        //   {
        //       int score = evaluate(board);

        //       // If Maximizer has won the game  
        //       // return his/her evaluated score 
        //       if (score == 10)
        //           return score;

        //       // If Minimizer has won the game  
        //       // return his/her evaluated score 
        //       if (score == -10)
        //           return score;

        //       // If there are no more moves and  
        //       // no winner then it is a tie 
        //       if (board.isMovesLeft() == false)
        //           return 0;

        //       // If this maximizer's move 
        //       // For the Player A +1
        //       if (isMax)
        //       {
        //           int best = -1000;

        //           // Traverse all cells 
        //           for (int i = 0; i < 3; i++)
        //           {
        //               for (int j = 0; j < 3; j++)
        //               {
        //                   // Check if cell is empty 
        //                   if (board.isSafeToPlay(i, j))
        //                   {
        //                       // Make the move 
        //                       board.PlayerA(g, new Point(0, 0), true, i, j); // let the game play 

        //                       // Call minimax recursively and choose 
        //                       // the maximum value 
        //                       best = Math.Max(best, minimax(board, g, depth + 1, !isMax));

        //                       // Undo the move 
        //                       board.resetRectPos(i, j); // vide la case
        //                   }
        //               }
        //           }
        //           return best;
        //       }
        //       else // for Player B -1
        //       {
        //           int best = 1000;

        //           // Traverse all cells 
        //           for (int i = 0; i < 3; i++)
        //           {
        //               for (int j = 0; j < 3; j++)
        //               {
        //                   // Check if cell is empty 
        //                   if (board.isSafeToPlay(i, j))
        //                   {
        //                       // Make the move 
        //                       board.PlayerB(g, new Point(0, 0), true, i, j);

        //                       // Call minimax recursively and choose 
        //                       // the minimum value 
        //                       best = Math.Min(best, minimax(board, g, depth + 1, !isMax));

        //                       // Undo the move 
        //                       board.resetRectPos(i, j); // vide la case
        //                   }
        //               }
        //           }
        //           return best;
        //       } // mini

        //   }

        //public Move findBestMove(grille board, ref Graphics g)  // grill
        //   {
        //       int bestVal = -1000;
        //       Move bestMove = new Move();
        //       bestMove.row = -1;
        //       bestMove.col = -1;

        //       // Traverse all cells, evaluate minimax function  
        //       // for all empty cells. And return the cell  
        //       // with optimal value. 
        //       for (int i = 0; i < 3; i++)
        //       {
        //           for (int j = 0; j < 3; j++)
        //           {
        //               // Check if cell is empty 
        //               if (board.isSafeToPlay(i, j))
        //               {
        //                   // Make the move 
        //                   board.PlayerA(ref board, new Point(0, 0), true, i, j);

        //                   // compute evaluation function for this 
        //                   // move. 
        //                   int moveVal = minimax(board, g, 0, false);

        //                   // Undo the move 
        //                   board.resetRectPos(i, j);

        //                   // If the value of the current move is 
        //                   // more than the best value, then update 
        //                   // best/ 
        //                   if (moveVal > bestVal)
        //                   {
        //                       bestMove.row = i;
        //                       bestMove.col = j;
        //                       bestVal = moveVal;
        //                   }
        //               }
        //           }
        //       }

        //       return bestMove;
        //   }









    }
}
