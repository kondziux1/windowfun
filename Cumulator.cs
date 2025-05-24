using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace windowfun
{
    public class Cumulator
    {
        public Cumulator()
        {
            SummonNewKamil();
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 300;
            timer.Tick += Timer_Tick;
            timer.Start();
            
        }
        int ticki = 0;
        

        private Dictionary<int, Jump> data = new Dictionary<int, Jump>() { [0] = new Jump() };

        private void Timer_Tick(object sender, System.EventArgs e)
        {
            if (data.Count<40)
            {
                ticki++;
                if (ticki > 2)
                {
                    ticki = 0;
                    for (int i = data.Count; i > 0; i--)
                    {
                        SummonNewKamil();
                    }
                }
            }
        }

        public void SummonNewKamil()
        {
            Jump c = data[data.Count - 1];
            c.Show();
            c.Kamilclick += C_Kamilclick;
            data.Add(data.Count, new Jump(c.Location.X, c.Location.Y));
        }

        private void C_Kamilclick(object sender, System.EventArgs e)
        {
            SummonNewKamil();
        }
    }
}