using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Name:Dennis Kanzira
 * Date:08/17/2017
 * StudentID:300914940
 * Description:This is the ScoreBoard Class for the Card Game
 * Version: 0.1 - Created the scoreboard class
 */
namespace COMP123_S2017_300914940
{
    public class ScoreBoard
    {
        //PRIVATE INSTANCE VARIABLES **********************************
        private TextBox _finalScoreTextBox;
        private int _score;
        private TextBox _scoreTextBox;
        private int _time;
        private TextBox _timeTextBox;
        
        //PUBLIC PROPERTIES ********************************************
        public TextBox FinalScoreTextBox
        {
            get
            {
                return this._finalScoreTextBox;
            }
            set
            {
                this._finalScoreTextBox = value;
                this._score = Convert.ToInt32(this.FinalScoreTextBox.Text);
            }
        }
        public int Score
        {
            get
            {
                return this._score;
            }
            set
            {
                this._score = value;
                _scoreTextBox.Text = this._score.ToString();
            }
        }
        public TextBox ScoreTextBox
        {
            get
            {
                return this._scoreTextBox;
            }
            set
            {
                this._scoreTextBox = value;
            }
        }
        public int Time
        {
            get
            {
                return this._time;
            }
            set
            {
                this._time = value;
                this.TimeTextBox.Text = this._time.ToString();
            }
        }
        public TextBox TimeTextBox
        {
            get
            {
                return this._timeTextBox;
            }
            set
            {
                this._timeTextBox = value;
            }
        }

        //PUBLIC METHODS ************************************************
        public void UpdateTime()
        {
            int newTime = Convert.ToInt32(this.TimeTextBox.Text);
            newTime = newTime - 1;
            this.Time = newTime;
        }

        /// <summary>
        /// This is the main constructor of the Board Game
        /// </summary>
        /// <param name="scoreTextBox"></param>
        /// <param name="timeTextBox"></param>
        /// <param name="finalScoreTextBox"></param>
        public ScoreBoard(TextBox scoreTextBox,TextBox timeTextBox,TextBox finalScoreTextBox)
        {
            this.ScoreTextBox = scoreTextBox;
            this.TimeTextBox = timeTextBox;
            this.FinalScoreTextBox = finalScoreTextBox;
        }



    }
}
