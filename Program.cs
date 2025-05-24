using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windowfun
{
    internal class Program
    {


        /// <summary>
        /// This code is dogshit
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Cumulator chujkuwra = new Cumulator();
            Application.Run();
            
        }

    }
}
