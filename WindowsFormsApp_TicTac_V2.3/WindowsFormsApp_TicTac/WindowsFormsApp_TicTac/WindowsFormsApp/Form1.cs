using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class UneForme : MetroFramework.Forms.MetroForm
    {
        private grille game;
        private PlayForm menu;
        private SoundPlayer FormMusic;
        private bool isMachine;
        private Computer PlayerMachine;

        /// <summary>
        ///  c'est le tour
        /// </summary>
        bool verrou = true;

        public UneForme(PlayForm menuForm, bool isM)
        {

            InitializeComponent();
            this.menu = menuForm;
            this.isMachine = isM;
            Point p = new Point(50, 120);
            game = new grille(100, p,ref MtrTextBox);
            if (isM)
            {
                this.PlayerMachine = new Computer(ref game);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.playeSound();
            panel1.BackColor = Color.Lime;
            panel2.BackColor = Color.Red;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
             Graphics g = e.Graphics;            
            game.dessiner(ref g);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            
            Graphics g = this.CreateGraphics();
            Point p = e.Location;
            switch (e.Button)
            {
                case MouseButtons.Left:
                    {
                        if (verrou || isMachine) {
                            
                            if (this.game.PlayerA(ref g, p, false))
                             
                            {
                                verrou = false;
                                panel1.BackColor = Color.Red;
                                panel2.BackColor = Color.Lime;
                            }

                            if (isMachine)
                            {
                                this.MachineMove(ref g);
                            }
                        }
                       // check for game over after 5 rounds

                        if (game.CheckForGameOver(this)) {

                            verrou = true;
                        }
                    }
                    
                    break;

                case MouseButtons.Right:
                    {
                        if (!isMachine)
                        {
                            if (!verrou)
                            {

                                if (this.game.PlayerB(ref g, p, false))
                                {
                                    verrou = true;
                                    panel1.BackColor = Color.Lime;
                                    panel2.BackColor = Color.Red;
                                }

                            }
                            if (game.CheckForGameOver(this))
                            {
                                verrou = true;
                            }
                        }
                    }

                    break;
                default:
                    break;
            }
        }

        private void playeSound()
        {
            FormMusic = new SoundPlayer(@"..\..\audio\sound.wav");
            FormMusic.PlayLooping();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            MtrTextBox.Text = "";
            if (isMachine)
            {
                this.PlayerMachine.ResetComputer();
                game.ResetGame(this);
            }
            else
                game.ResetGame(this);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void BunifuPlayer1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void MtrBtnBackM_Click(object sender, EventArgs e)
        {
            //this.FormMusic.Stop();
            menu.Show();
            this.Close();
        }

        /// <summary>
        /// l'appel pour que la machine commence le jeu en mode Robot
        /// </summary>
        /// <param name="g"></param>
        private void MachineMove(ref Graphics g)
        {
            this.PlayerMachine.RandomMove(ref g);
            verrou = true;
            panel1.BackColor = Color.Lime;
            panel2.BackColor = Color.Red;
        } 
    }
}
