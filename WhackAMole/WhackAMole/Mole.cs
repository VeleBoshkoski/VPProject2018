using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace WhackAMole
{
    class Mole
    {
        public string name { get; set; }
        public bool isPopped { get; set; }
        public Panel view { get; set; }

        System.Timers.Timer aTimer = new System.Timers.Timer();
        
        public void hideMole (){
            view.Visible = false;
            isPopped = false;
            //aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            //aTimer.Interval = 5;
            //aTimer.Enabled = true;
        }

        public void showMole()
        {
            view.Visible = true;
            isPopped = true;
            //aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            //aTimer.Interval = 5;
            //aTimer.Enabled = true;
        }

        private void OnTimedEvent(object sender, ElapsedEventArgs e)
        {
            if (view.Height <= 0)
            {
                aTimer.Stop();
                aTimer.Dispose();
                view.Height = 0;
            }
            else
            {
                view.Invoke(new MethodInvoker(delegate { view.Height -= 1; }));
            }
                
        }
    }
}
