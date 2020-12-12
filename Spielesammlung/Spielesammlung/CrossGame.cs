using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Form2 : Form
    {
      
        public Form2()
        {
            InitializeComponent();
            End.Visible = false;  // Game over Label zu beginn unsichtbar
            Winning.Visible = false;  // Win Label zu beginn unsichtbar 
            labelRetry.Visible = false;
            Save1.Visible = true;
            GameReset();
        }

       

        private void Form2_Load(object sender, EventArgs e)
        {

        }
       
        void Sieg()
        {
            if (Player.Bounds.IntersectsWith(picBoxSave2.Bounds))
            {
                timer1.Enabled = false;
                Winning.Visible = true;
                Player.Visible = false;
                End.Visible = false;
                labelRetry.Visible = true;
                
            }
        }
        void GameOver()
        {
            
            if(Player.Bounds.IntersectsWith(Enemyd1.Bounds))
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
            
            Player.Top = 137;
            Player.Left = 576;
            Points.Text = "score: 0" ;
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
            if (Enemyd1.Top >= 365)
            { Enemyd1.Top = 0; }
            else { Enemyd1.Top += Speed; }

            if (Enemyd2.Top >= 365)
            { Enemyd2.Top = 0; }
            else { Enemyd2.Top += Speed; }

            if (Enemyd3.Top >= 365)
            { Enemyd3.Top = 0; }
            else { Enemyd3.Top += Speed; }

            if (Enemyd4.Top >= 365)
            { Enemyd4.Top = 0; }
            else { Enemyd4.Top += Speed; }

            if (Enemyd5.Top >= 365)                           //Enemys going down
            { Enemyd5.Top = 0; }
            else { Enemyd5.Top += Speed; }

            if (Enemyd6.Top >= 365)
            { Enemyd6.Top = 0; }
            else { Enemyd6.Top += Speed; }



            if (Enemyu1.Bottom <= 0)
            { Enemyu1.Top = 365; }
            else { Enemyu1.Top -= Speed; }

            if (Enemyu2.Bottom <= 0)
            { Enemyu2.Top = 365; }
            else { Enemyu2.Top -= Speed; }

            if (Enemyu3.Bottom <= 0)
            { Enemyu3.Top = 365; }                           //Enemys going up
            else { Enemyu3.Top -= Speed; }

            if (Enemyu4.Bottom <= 0)
            { Enemyu4.Top = 365; }
            else { Enemyu4.Top -= Speed; }

            if (Enemyu5.Bottom <= 0)
            { Enemyu5.Top = 365; }
            else { Enemyu5.Top -= Speed; }

            if (Enemyu6.Bottom <= 0)
            { Enemyu6.Top = 365; }
            else { Enemyu6.Top -= Speed; }


            if (EnemyL1.Left >= 623)
            { EnemyL1.Left = 0; }
            else { EnemyL1.Left += Speed; }         // Enemys going sideways 

            if (EnemyR1.Left <= 0)
            { EnemyR1.Left = 623; }
            else { EnemyR1.Left -= Speed; }
        }
        int Goldworth = 10;
        void Score()
        {
            if (Player.Bounds.IntersectsWith(Gold1.Bounds))
            {
                Goldworth ++;
                Gold1.Visible = false;
                Points.Text = "score: 0" + Goldworth.ToString();
            }

            if (Player.Bounds.IntersectsWith(Gold2.Bounds))
            {
                Goldworth++;
                Gold2.Visible = false;
                Points.Text = "score: 0" + Goldworth.ToString();
            }

            if (Player.Bounds.IntersectsWith(Gold3.Bounds))
            {
                Goldworth++;
                Gold3.Visible = false;
                Points.Text = "score: 0" + Goldworth.ToString();
            }

            if (Player.Bounds.IntersectsWith(Gold4.Bounds))
            {
                Goldworth++;
                Gold4.Visible = false;
                Points.Text = "score: 0" + Goldworth.ToString();
            }

            if (Player.Bounds.IntersectsWith(Gold5.Bounds))
            {
                Goldworth++;
                Gold5.Visible = false;
                Points.Text = "score: 0" + Goldworth.ToString();
            }

            if (Player.Bounds.IntersectsWith(Gold6.Bounds))
            {
                Goldworth++;
                Gold6.Visible = false;
                Points.Text = "score: 0" + Goldworth.ToString();
            }
            if (Player.Bounds.IntersectsWith(Gold7.Bounds))
            {
                Goldworth++;
                Gold7.Visible = false;
                Points.Text = "score: 0" + Goldworth.ToString();
            }
        }

        int gamespeed = 20;
        private void Form2_KeyDown(object sender, KeyEventArgs e)             // Abfrage ob Taste gedrückt
        {
            if (e.KeyCode == Keys.Left)                  // Tastencode gleich Pfeiltaste Links
            {
                if (Player.Left > 0)
                    Player.Left += -gamespeed;
            }
            if (e.KeyCode == Keys.Right)                 // Tastencode gleich Pfeiltaste Rechts
            {
                if (Player.Right < 610)
                    Player.Left += gamespeed;
            }

            if (e.KeyCode == Keys.Up)                    // Tastencode gleich Pfeiltaste Oben
            {
                if (Player.Top > 0)
                    Player.Top += -gamespeed;
            }
            if (e.KeyCode == Keys.Down)                    // Tastencode gleich Pfeiltaste Unten
            {
                if (Player.Bottom < 333)
                    Player.Top += gamespeed;
            }

           
            
            if (e.KeyCode == Keys.Enter)       // überprüfung ob Entertaste gedrückt wurde 
            
            { 
               
               
                
                if (End.Visible || Winning.Visible == true)         // Falls  Win oder Gameover eintritt  und Entertaste gedrücktwird mittels Entertaste folgendes vollbracht 
                
                {
                    

                    End.Visible = false;                       // falls End sichtbar mit entertaste beendet
                    Winning.Visible = false;                   // falls winning sichtbar mit entertaste beendet
                    timer1.Enabled = true;
                    Player.Visible = true;
                    labelRetry.Visible = true;




                    if (e.KeyCode == Keys.Enter)
                    {
                        labelRetry.Visible = false;
                        GameReset(); 
                    }
                    
                    
                    
                }
            
            }
        }
       
        private void timer1_Tick(object sender, EventArgs e)
        {
            Enemy(10);
            GameOver();
            Sieg();
            Score();
            
        }

        private void spielVerlassenToolStripMenuItem_Click(object sender, EventArgs e)
        {
             this.Close();
        }
    }

}
