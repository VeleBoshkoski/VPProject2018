using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhackAMole
{
    class Game
    {
        public Mole mole1;
        public Mole mole2;
        public Mole mole3;
        public Mole mole4;
        public Mole mole5;
        public Mole mole6;
        public Mole mole7;
        public Mole mole8;
        public Mole mole9;
        public Mole mole10;
        public Mole mole11;
        public Mole mole12;
        public int Points = 0;
        public int Level = 1;
        public int TimePast = 0;
        public int numberOfLives = 5;
        Label pTimeText;
        Label pLevelText;
        Label pLivesText;
        private int MAX_NUM_OF_MOLES = 3;

        private Timer mainTimer;
        public void InitTimer()
        {
            mainTimer = new Timer();
            mainTimer.Tick += new EventHandler(mainTimer_Tick);
            mainTimer.Interval = 3000; // in miliseconds
            mainTimer.Start();
        }
        private void mainTimer_Tick(object sender, EventArgs e)
        {
            numberOfLives -= countPoppedMoles();
            pLivesText.Text = numberOfLives + "";

            if (numberOfLives <= 0)
            {
                Form1.StopGame();
                STOP_TIMEERS();
            }
            hideAllMoles();
            int numOfMoles = Level;
            if (numOfMoles > MAX_NUM_OF_MOLES)
                numOfMoles = MAX_NUM_OF_MOLES;
            popRandomMoles(numOfMoles);
        }

        private Timer gameTimer;
        public void InitGameTimer()
        {
            gameTimer = new Timer();
            gameTimer.Tick += new EventHandler(gameTimer_Tick);
            gameTimer.Interval = 1000; // in miliseconds
            gameTimer.Start();
        }
        private void gameTimer_Tick(object sender, EventArgs e)
        {
            TimePast += 1;
            IncreseTime(TimePast);

            if ((TimePast / 60) >= 1 && (TimePast % 60 == 0))
            {
                Level += 1;
                pLevelText.Invoke(new MethodInvoker(delegate { pLevelText.Text = Level + ""; }));
                int multiplier = 200;
                if (Level >= 10)
                    multiplier = 0;
                mainTimer.Interval = 3000 - (Level * multiplier);
            }
        }

        public void IncreseTime(int seconds)
        {
            pTimeText.Invoke(new MethodInvoker(delegate { pTimeText.Text = seconds + ""; }));
        }

        public void RESET_TIMEERS (){
            gameTimer.Stop();
            gameTimer.Dispose();
            mainTimer.Stop();
            mainTimer.Dispose();
            pTimeText.Text = 0+"";
            pLevelText.Text = 1 + "";
            pLivesText.Text = 5 + "";
        }

        public void STOP_TIMEERS()
        {
            hideAllMoles();
            gameTimer.Stop();
            gameTimer.Dispose();
            mainTimer.Stop();
            mainTimer.Dispose();
            pTimeText.Text = 0 + "";
            pLevelText.Text = 1 + "";
            pLivesText.Text = 5 + "";
            MessageBox.Show("Your scrore is: " + Points, "Game Over",  MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        public bool AreTimerInitialized()
        {
            return mainTimer != null && gameTimer != null;
        }

        public Game (Panel pMole1, Panel pMole2, Panel pMole3, Panel pMole4, Panel pMole5, 
            Panel pMole6, Panel pMole7, Panel pMole8, Panel pMole9, Panel pMole10, Panel pMole11, Panel pMole12, Label pTime, Label pLevel, Label pLives)
        {
            pTimeText = pTime;
            pLevelText = pLevel;
            pLivesText = pLives;
            CreateMoles( pMole1,  pMole2,  pMole3,  pMole4,  pMole5,  pMole6,  pMole7,  pMole8,  pMole9,  pMole10,  pMole11,  pMole12);
            InitTimer();
            InitGameTimer();
        }

        public void CreateMoles(Panel pMole1, Panel pMole2, Panel pMole3, Panel pMole4, Panel pMole5, 
            Panel pMole6, Panel pMole7, Panel pMole8, Panel pMole9, Panel pMole10, Panel pMole11, Panel pMole12)
        {
            mole1 = new Mole();
            mole1.name = "mole1";
            mole1.view = pMole1;
            mole1.hideMole();

            mole2 = new Mole();
            mole2.name = "mole2";
            mole2.view = pMole2;
            mole2.hideMole();

            mole3 = new Mole();
            mole3.name = "mole3";
            mole3.view = pMole3;
            mole3.hideMole();

            mole4 = new Mole();
            mole4.name = "mole4";
            mole4.view = pMole4;
            mole4.hideMole();

            mole5 = new Mole();
            mole5.name = "mole5";
            mole5.view = pMole5;
            mole5.hideMole();

            mole6 = new Mole();
            mole6.name = "mole6";
            mole6.view = pMole6;
            mole6.hideMole();

            mole7 = new Mole();
            mole7.name = "mole7";
            mole7.view = pMole7;
            mole7.hideMole();

            mole8 = new Mole();
            mole8.name = "mole8";
            mole8.view = pMole8;
            mole8.hideMole();

            mole9 = new Mole();
            mole9.name = "mole9";
            mole9.view = pMole9;
            mole9.hideMole();

            mole10 = new Mole();
            mole10.name = "mole10";
            mole10.view = pMole10;
            mole10.hideMole();

            mole11 = new Mole();
            mole11.name = "mole11";
            mole11.view = pMole11;
            mole11.hideMole();

            mole12 = new Mole();
            mole12.name = "mole12";
            mole12.view = pMole12;
            mole12.hideMole();
        }
       
        public void popRandomMoles(int numberOfMoles)
        {
            Random rnd = new Random();
            for (int i =0;i<numberOfMoles; i++)
            {
                int RndNum = rnd.Next(1, 12);

                switch(RndNum)
                {
                    case 1:
                        mole1.showMole();
                        break;
                    case 2:
                        mole2.showMole();
                        break;
                    case 3:
                        mole3.showMole();
                        break;
                    case 4:
                        mole4.showMole();
                        break;
                    case 5:
                        mole5.showMole();
                        break;
                    case 6:
                        mole6.showMole();
                        break;
                    case 7:
                        mole7.showMole();
                        break;
                    case 8:
                        mole8.showMole();
                        break;
                    case 9:
                        mole9.showMole();
                        break;
                    case 10:
                        mole10.showMole();
                        break;
                    case 11:
                        mole11.showMole();
                        break;
                    case 12:
                        mole12.showMole();
                        break;
                }
            }
        }

        public void hideAllMoles()
        {
            mole1.hideMole();
            mole2.hideMole();
            mole3.hideMole();
            mole4.hideMole();
            mole5.hideMole();
            mole6.hideMole();
            mole7.hideMole();
            mole8.hideMole();
            mole9.hideMole();
            mole10.hideMole();
            mole11.hideMole();
            mole12.hideMole();
        }

        public int countPoppedMoles()
        {
            int result = 0;

            if (mole1.isPopped)
                result += 1;
            if (mole2.isPopped)
                result += 1;
            if (mole3.isPopped)
                result += 1;
            if (mole4.isPopped)
                result += 1;
            if (mole5.isPopped)
                result += 1;
            if (mole6.isPopped)
                result += 1;
            if (mole7.isPopped)
                result += 1;
            if (mole8.isPopped)
                result += 1;
            if (mole9.isPopped)
                result += 1;
            if (mole10.isPopped)
                result += 1;
            if (mole11.isPopped)
                result += 1;
            if (mole12.isPopped)
                result += 1;
            
            return result;
        }
        public void SaveGame()
        {
            List<string> toWrite = new List<string>();
            toWrite.Add(mole1.isPopped+"");
            toWrite.Add(mole2.isPopped + "");
            toWrite.Add(mole3.isPopped + "");
            toWrite.Add(mole4.isPopped + "");
            toWrite.Add(mole5.isPopped + "");
            toWrite.Add(mole6.isPopped + "");
            toWrite.Add(mole7.isPopped + "");
            toWrite.Add(mole8.isPopped + "");
            toWrite.Add(mole9.isPopped + "");
            toWrite.Add(mole10.isPopped + "");
            toWrite.Add(mole11.isPopped + "");
            toWrite.Add(mole12.isPopped + "");

            toWrite.Add(Points + "");
            toWrite.Add(Level + "");
            toWrite.Add(TimePast + "");
            toWrite.Add(numberOfLives + "");

            Directory.CreateDirectory(@"C:\Users\Public\WachAMoleGameFolder");
            var f = File.Create(@"C:\Users\Public\WachAMoleGameFolder\Save.txt");
            f.Close();
            System.IO.File.WriteAllLines(@"C:\Users\Public\WachAMoleGameFolder\Save.txt", toWrite);
        }

        public void LoadGame()
        {
            if (File.Exists(@"C:\Users\Public\WachAMoleGameFolder\Save.txt")) {
                List<string> lines = File.ReadAllLines(@"C:\Users\Public\WachAMoleGameFolder\Save.txt").ToList();

                mole1.isPopped = Boolean.Parse(lines[0]);
                mole2.isPopped = Boolean.Parse(lines[1]);
                mole3.isPopped = Boolean.Parse(lines[2]);
                mole4.isPopped = Boolean.Parse(lines[3]);
                mole5.isPopped = Boolean.Parse(lines[4]);
                mole6.isPopped = Boolean.Parse(lines[5]);
                mole7.isPopped = Boolean.Parse(lines[6]);
                mole8.isPopped = Boolean.Parse(lines[7]);
                mole9.isPopped = Boolean.Parse(lines[8]);
                mole10.isPopped = Boolean.Parse(lines[9]);
                mole11.isPopped = Boolean.Parse(lines[10]);
                mole12.isPopped = Boolean.Parse(lines[11]);

                Points = Int32.Parse(lines[12]);
                Level = Int32.Parse(lines[13]);
                TimePast = Int32.Parse(lines[14]);
                numberOfLives = Int32.Parse(lines[15]);

                Form1.UpdateUI();
                updatePoppedMoles();
            }
        }

        public void updatePoppedMoles() {
            if (mole1.isPopped)
                mole1.showMole();
            if (mole2.isPopped)
                mole2.showMole();
            if (mole3.isPopped)
                mole3.showMole();
            if (mole4.isPopped)
                mole4.showMole();
            if (mole5.isPopped)
                mole5.showMole();
            if (mole6.isPopped)
                mole6.showMole();
            if (mole7.isPopped)
                mole7.showMole();
            if (mole8.isPopped)
                mole8.showMole();
            if (mole9.isPopped)
                mole9.showMole();
            if (mole10.isPopped)
                mole10.showMole();
            if (mole11.isPopped)
                mole11.showMole();
            if (mole12.isPopped)
                mole12.showMole();
        }
    }
}
