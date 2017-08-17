using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Name:Dennis Kanzira
 * Student ID#:300914940    
 * Subject:Comp123
 * Event:Final Exam Summer 2017
 * Date:08/17/2017
 * Description: This is the splash Form for the Card Game
 * Version: 0.2 - created event handler for the "Tick"
 * 
 */
namespace COMP123_S2017_300914940
{
    public partial class SplashForm : Form
    {
        //PUBLIC PROPERTIES
        public PickHighestCardForm PickHighestCardForm
        {
            get
            {
                return Program.pickhighestcardForm;
            }
        }
        // CONSTRUCTORS ++++++++++++++++++++++++++++++++++++++++++++++++

        /// <summary>
        /// This is the main constructor for the Splash Form
        /// </summary>
        public SplashForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This is the event handler for the "Tick"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Timer_Tick(object sender, EventArgs e)
        {
            this.PickHighestCardForm.Show();
            this.Hide();
            Timer.Enabled = false;//turn timer off
        }
    }
}
