using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhackAMole
{
    public partial class Form1 : Form
    {
        static Game g;
        static Form1 f1;
        public Form1()
        {
            InitializeComponent();
            startMoles();
        }
        public void startMoles() {
           f1 = this;
           //g = new Game(pMole1, pMole2, pMole3, pMole4, pMole5, pMole6, pMole7, pMole8, pMole9, pMole10, pMole11, pMole12, pTime, pLevel, pLives);
            
            //MessageBox.Show("Error Message", "Error Title", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        
        public static void startNewGame()
        {
            g = new Game(f1.pMole1, f1.pMole2, f1.pMole3, f1.pMole4, f1.pMole5, f1.pMole6, f1.pMole7, f1.pMole8, f1.pMole9, f1.pMole10, f1.pMole11, f1.pMole12, f1.pTime, f1.pLevel, f1.pLives);
            f1.pPoints.Text = 0 + "";
        }

        public void IncreasePoints()
        {
            g.Points += g.Level * 100;
            pPoints.Text = g.Points + "";
        }

        private void mole1Click(object sender, MouseEventArgs e)
        {
            g.mole1.hideMole();
            IncreasePoints();
        }

        private void mole2Click(object sender, MouseEventArgs e)
        {
            g.mole2.hideMole();
            IncreasePoints();
        }

        private void mole3Click(object sender, MouseEventArgs e)
        {
            g.mole3.hideMole();
            IncreasePoints();
        }

        private void mole4Click(object sender, MouseEventArgs e)
        {
            g.mole4.hideMole();
            IncreasePoints();
        }

        private void mole5Click(object sender, MouseEventArgs e)
        {
            g.mole5.hideMole();
            IncreasePoints();
        }

        private void mole6Click(object sender, MouseEventArgs e)
        {
            g.mole6.hideMole();
            IncreasePoints();
        }

        private void mole7Click(object sender, MouseEventArgs e)
        {
            g.mole7.hideMole();
            IncreasePoints();
        }

        private void mole8Click(object sender, MouseEventArgs e)
        {
            g.mole8.hideMole();
            IncreasePoints();
        }

        private void mole9Click(object sender, MouseEventArgs e)
        {
            g.mole9.hideMole();
            IncreasePoints();
        }

        private void mole10Click(object sender, MouseEventArgs e)
        {
            g.mole10.hideMole();
            IncreasePoints();
        }

        private void mole11Click(object sender, MouseEventArgs e)
        {
            g.mole11.hideMole();
            IncreasePoints();
        }

        private void mole12Click(object sender, MouseEventArgs e)
        {
            g.mole12.hideMole();
            IncreasePoints();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (g != null)
            {
                if (g.AreTimerInitialized())
                    g.RESET_TIMEERS();
            }
            startNewGame();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            g.SaveGame();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            g.LoadGame();
        }

        public static void UpdateUI()
        {
            f1.pPoints.Text = g.Points+"";
            f1.pTime.Text = g.TimePast + "";
            f1.pLevel.Text = g.Level + "";
            f1.pLives.Text = g.numberOfLives + "";
        }

        public static void StopGame() {
            g = null;
        }
    }
}
