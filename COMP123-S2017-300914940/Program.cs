using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Name:Dennis Kanzira
 * Date:08/17/2017
 * StudentID:300914940
 * Description:This is the Driver Class for the Card Game
 * Version: 0.1 - Running the Splash Form
 */

namespace COMP123_S2017_300914940
{
    public static class Program
    {

        /// <summary>
        /// This is the reference for the forms
        /// </summary>
        public static PickHighestCardForm pickhighestcardForm;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            pickhighestcardForm = new PickHighestCardForm();
            Application.Run(new SplashForm());
        }
    }
}
