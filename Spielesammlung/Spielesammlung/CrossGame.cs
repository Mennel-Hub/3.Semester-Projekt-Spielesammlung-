using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spielesammlung
{
    public partial class CrossGame : Form               // CrossGame abgeleitet von der Basis Form
    {
        bool moveLeft, moveRight, moveUp, moveDown;
        int speed = 15;


        public CrossGame()
        {
            InitializeComponent();       
            GameReset();
            End.Visible = false;  // Game over Label zu beginn unsichtbar
            Winning.Visible = false;  // Win Label zu beginn unsichtbar 
            labelRetry.Visible = false;    //Retry Label zu beginn unsichtbar 
            Save1.Visible = true;        //Methode des GameReset immer vorhanden damit jederzeit resetet werden kann
            lblmax.Visible = false;
           
        }
       
        void Sieg()
        {
            
            if (Player.Bounds.IntersectsWith(Save2.Bounds))
            {
                if (Goldworth <3)
                {
                    Winning.Visible = false;
                }
                if (Goldworth >=7)
                {
                
                    lblmax.Visible = true;
                    timer1.Enabled = false;
                    Winning.Visible = false;
                    Player.Visible = false;
                    End.Visible = false;
                    labelRetry.Visible = true;
                }
                else
                {
                            timer1.Enabled = false;
                            Winning.Visible = true;
                            Player.Visible = false;
                            End.Visible = false;
                            labelRetry.Visible = true;
                }


            }
            
        }

        void GameOver()
        {

            if (Player.Bounds.IntersectsWith(Enemyd1.Bounds))
            {
                timer1.Enabled = false;
                End.Visible = true;
                Player.Visible = false;
                labelRetry.Visible = true;
            }

            if (Player.Bounds.IntersectsWith(Enemyd2.Bounds))
            {
                timer1.Enabled = false;
                End.Visible = true;
                Player.Visible = false;
                labelRetry.Visible = true;
            }

            if (Player.Bounds.IntersectsWith(Enemyd3.Bounds))
            {
                timer1.Enabled = false;
                End.Visible = true;
                Player.Visible = false;
                labelRetry.Visible = true;
            }

            if (Player.Bounds.IntersectsWith(Enemyd4.Bounds))
            {
                timer1.Enabled = false;
                End.Visible = true;
                Player.Visible = false;
                labelRetry.Visible = true;
            }

            if (Player.Bounds.IntersectsWith(Enemyd5.Bounds))
            {
                timer1.Enabled = false;
                End.Visible = true;
                Player.Visible = false;
                labelRetry.Visible = true;
            }

            if (Player.Bounds.IntersectsWith(Enemyd6.Bounds))
            {
                timer1.Enabled = false;
                End.Visible = true;
                Player.Visible = false;
                labelRetry.Visible = true;
            }

            if (Player.Bounds.IntersectsWith(Enemyu1.Bounds))
            {
                timer1.Enabled = false;
                End.Visible = true;
                Player.Visible = false;
                labelRetry.Visible = true;
            }

            if (Player.Bounds.IntersectsWith(Enemyu2.Bounds))
            {
                timer1.Enabled = false;
                End.Visible = true;
                Player.Visible = false;
                labelRetry.Visible = true;
            }

            if (Player.Bounds.IntersectsWith(Enemyu3.Bounds))
            {
                timer1.Enabled = false;
                End.Visible = true;
                Player.Visible = false;
                labelRetry.Visible = true;
            }

            if (Player.Bounds.IntersectsWith(Enemyu4.Bounds))
            {
                timer1.Enabled = false;
                End.Visible = true;
                Player.Visible = false;
                labelRetry.Visible = true;
            }

            if (Player.Bounds.IntersectsWith(Enemyu5.Bounds))
            {
                timer1.Enabled = false;
                End.Visible = true;
                Player.Visible = false;
                labelRetry.Visible = true;
            }

            if (Player.Bounds.IntersectsWith(Enemyu6.Bounds))
            {
                timer1.Enabled = false;
                End.Visible = true;
                Player.Visible = false;
                labelRetry.Visible = true;
            }

            if (Player.Bounds.IntersectsWith(EnemyR1.Bounds))
            {
                timer1.Enabled = false;
                End.Visible = true;
                Player.Visible = false;
                labelRetry.Visible = true;
            }

            if (Player.Bounds.IntersectsWith(EnemyL1.Bounds))
            {
                timer1.Enabled = false;
                End.Visible = true;
                Player.Visible = false;
                labelRetry.Visible = true;
            }


        }

        //  int position;

        private void GameReset()
        {
            Goldworth = 1;
            Player.Top = 240;
            Player.Left = 615;
            Points.Text = "score: 0";
            Gold1.Visible = true;
            Gold2.Visible = true;
            Gold3.Visible = true;
            Gold4.Visible = true;
            Gold5.Visible = true;
            Gold6.Visible = true;
            Gold7.Visible = true;
        }

       
        void Enemy(int Speed)
        {
            if (Enemyd1.Top >= 426)
            { Enemyd1.Top = 27; }
            else { Enemyd1.Top += Speed; }

            if (Enemyd2.Top >= 426)
            { Enemyd2.Top = 27; }
            else { Enemyd2.Top += Speed; }

            if (Enemyd3.Top >= 426)
            { Enemyd3.Top = 27; }
            else { Enemyd3.Top += Speed; }

            if (Enemyd4.Top >= 426)
            { Enemyd4.Top = 27; }
            else { Enemyd4.Top += Speed; }

            if (Enemyd5.Top >= 426)                           //Enemys going down
            { Enemyd5.Top = 27; }
            else { Enemyd5.Top += Speed; }

            if (Enemyd6.Top >= 426)
            { Enemyd6.Top = 27; }
            else { Enemyd6.Top += Speed; }



            if (Enemyu1.Bottom <= 27)
            { Enemyu1.Top = 426; }
            else { Enemyu1.Top -= Speed; }

            if (Enemyu2.Bottom <= 27)
            { Enemyu2.Top = 426; }
            else { Enemyu2.Top -= Speed; }

            if (Enemyu3.Bottom <= 27)
            { Enemyu3.Top = 426; }                           //Enemys going up
            else { Enemyu3.Top -= Speed; }

            if (Enemyu4.Bottom <= 27)
            { Enemyu4.Top = 426; }
            else { Enemyu4.Top -= Speed; }

            if (Enemyu5.Bottom <= 27)
            { Enemyu5.Top = 426; }
            else { Enemyu5.Top -= Speed; }

            if (Enemyu6.Bottom <= 27)
            { Enemyu6.Top = 426; }
            else { Enemyu6.Top -= Speed; }


            if (EnemyL1.Left >= 666)
            { EnemyL1.Left = 0; }
            else { EnemyL1.Left += Speed; }         // Enemys going sideways 

            if (EnemyR1.Left <= 0)
            { EnemyR1.Left = 666; }
            else { EnemyR1.Left -= Speed; }
        }
       
      
        
        int Goldworth = 0;
        void Score()
        {
            foreach( Control x in this.Controls)
            {
                if (x is PictureBox && ( string) x.Tag == "object" )
                {
                    
                       if (Player.Bounds.IntersectsWith(x.Bounds)&& x.Visible == Visible)
                        {


                            Points.Text = "score: 0" + Goldworth.ToString();
                            Goldworth++; 
                         

                        }
                   
                        
                   
                }
            }
            if (Player.Bounds.IntersectsWith(Gold1.Bounds))
            {
                Gold1.Visible = false;
            }
          
            if (Player.Bounds.IntersectsWith(Gold2.Bounds))

            {
                Gold2.Visible = false;
            }

            if (Player.Bounds.IntersectsWith(Gold3.Bounds))

            {
                Gold3.Visible = false;
            }

            if (Player.Bounds.IntersectsWith(Gold4.Bounds))

            {
                Gold4.Visible = false;
            }

            if (Player.Bounds.IntersectsWith(Gold5.Bounds))

            {
                Gold5.Visible = false;
            }

            if (Player.Bounds.IntersectsWith(Gold6.Bounds))

            {
                Gold6.Visible = false;
            }

            if (Player.Bounds.IntersectsWith(Gold7.Bounds))

            {

                Gold7.Visible = false;
            }
        }




        private void timer1_Tick(object sender, EventArgs e)
        {
            if (moveLeft == true && Player.Left > 0)             // BoolVariable ist true und linke grenze von Player gräßer Null 
            {
                Player.Left -= speed;                            // -= Operator da Spieler in Richtung (-) x-Achse 
            }

            if (moveRight == true && Player.Left < 625)
            {
                Player.Left += speed;
            }
            if (moveUp == true && Player.Top > 0)
            {
                Player.Top -= speed;
            }
            if (moveDown == true && Player.Top < 401)
            {
                Player.Top += speed;
            }


            
        



            Enemy(10);
            GameOver();
            Sieg();
            Score();
            
        }


        
        

        private void CrossGame_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)                  // Tastencode gleich Pfeiltaste Links
            {
                moveLeft = false;
            }
            if (e.KeyCode == Keys.Right)                 // Tastencode gleich Pfeiltaste Rechts
            {
                moveRight = false;
            }

            if (e.KeyCode == Keys.Up)                    // Tastencode gleich Pfeiltaste Oben
            {
                moveUp = false;
            }
            if (e.KeyCode == Keys.Down)                    // Tastencode gleich Pfeiltaste Unten
            {
                moveDown = false;
            }
        }

       

        private void CrossGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)                  // Tastencode gleich Pfeiltaste Links
            {
                moveLeft = true;
            }
            if (e.KeyCode == Keys.Right)                 // Tastencode gleich Pfeiltaste Rechts
            {
                moveRight = true;
            }

            if (e.KeyCode == Keys.Up)                    // Tastencode gleich Pfeiltaste Oben
            {
                moveUp = true;
            }
            if (e.KeyCode == Keys.Down)                    // Tastencode gleich Pfeiltaste Unten
            {
                moveDown = true;
            }



            if (e.KeyCode == Keys.Enter)       // überprüfung ob Entertaste gedrückt wurde 

            {



                if (End.Visible || Winning.Visible ||lblmax.Visible == true)  // Falls  Win- oder Gameover-Sequenz eintritt und Entertaste gedrückt wird tritt folgendes ein

                {


                    End.Visible = false;                       // Gameover-Sequenz wird unsichtbar
                    Winning.Visible = false;                   // Gameover-Sequenz wird unsichtbar
                    timer1.Enabled = true;                     // Timer ist true damit sich Gegner weiter bewegen
                    lblmax.Visible = false;
                    Player.Visible = true;                     // Der Player ist Sichtbar 
                    labelRetry.Visible = true;                 // Retry label ist sichtbar




                    if (e.KeyCode == Keys.Enter)         //Sofern Spiel gewonnen oder verloren wurde kann mit der Entertaste das Spiel resetet werden.
                    {                                    //Damit kann das Spiel schneller wieder begonnen werden. Spiel wird flüssiger.
                        labelRetry.Visible = false;      //Das Label Retry wird nicht mehr sichtbar.
                        GameReset();                     //Methode um das Spiel zu reseten.
                    }



                }

            }
        }

        private void spielVerlassenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close(); // Wenn auf der Grafischen Oberfläche im oberen linken Eck auf Spielverlassen geklickt wird soll sich dieses Fenster schließen
        }

        private void neuesSpielToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GameReset();  // Wenn auf der Grafischen Oberfläche im oberen linken Eck auf neues Spiel geklickt wird soll sich dieses Fenster reseten
        }
    }
}
