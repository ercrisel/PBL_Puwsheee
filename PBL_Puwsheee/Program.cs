using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL_Puwsheee
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Charts(new Classes.UserInfo() { Username = "hrvrldn"})); //if you want to run the chart; change username then uncomment
            Application.Run(new SplashScreen());
        }
    }
}
