/*Copyright 2016 OUNL

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
This project has received funding from the European Union’s Horizon
2020 research and innovation programme under grant agreement No 644187.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//for stopwatch
using System.Diagnostics;

namespace Prototype1v1
{
    public partial class Form1 : Form
    {
        /*
        private HintingAsset hintAssetObject = new HintingAsset();

        //////////////////old code
        //private Rules rulesObject = new Rules();
        //private Metrics metricsObject = new Metrics();

        private DiagnosticRules rulesObject = new DiagnosticRules();
        private PlayerMetrics metricsObject = new PlayerMetrics();


        private TimeMetrics timeMetricsObject = new TimeMetrics();
        private ActivityMetrics taskMetricsObject = new ActivityMetrics();
        private HintMetrics hintMetricsObject = new HintMetrics();
        private ErrorMetrics errorMetricsObject = new ErrorMetrics();*/

        //private Stopwatch stopwatch = new Stopwatch();


        //public event FormClosingEventHandler FormClosing;


        /*private bool showHintFlag=false;

        public void SetShowHintFlag(bool newValue)
        {
            showHintFlag = newValue;
        }*/


        public Form1()
        {
            InitializeComponent();
            //Form1.FormClosed += Form1_FormClosed;
            //this.FormClosing += this.MainWin_FormClosing;

            //start the timer form the begining
            /*rulesObject.SetMetricsObject(metricsObject);
            metricsObject.taskMetricsObject = taskMetricsObject;
            metricsObject.timeMetricsObject = timeMetricsObject;
            metricsObject.hintMetricsObject = hintMetricsObject;
            metricsObject.errorMetricsObject = errorMetricsObject;

            metricsObject.timeMetricsObject.StartAndStopTimeCounterSinceBeginningOfGame(true);
            this.textBox2.Multiline = true;*/


        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            //metricsObject.timeMetricsObject.StartAndStopTimeCounterSinceBeginningOfGame(false);
            
            /*MessageBox.Show(this, "Oh, don't go, Boo will miss you. :(\n Log file created (NOT)!"
                , "Total time:" + metricsObject.timeMetricsObject.GetStoredCountTimeSinceBeginningOfGame());
            */
            //metricsObject.WriteToLogFile();
            //and create log of all the data!!!!!!!!!!!!
        }

        

        /*protected override void OnClosing(CancelEventArgs e)
        {
            e.Cancel = (MessageBox.Show("Are you sure? Boo will miss you.", "Question?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1) == DialogResult.No);

            base.OnClosing(e);
            //MessageBox.Show("Log created (NOT)");
        }*/

        /*private void Form1_FormClosing(Object sender, FormClosingEventArgs e)
        {

            System.Text.StringBuilder messageBoxCS = new System.Text.StringBuilder();
            messageBoxCS.AppendFormat("{0} = {1}", "CloseReason", e.CloseReason);
            messageBoxCS.AppendLine();
            messageBoxCS.AppendFormat("{0} = {1}", "Cancel", e.Cancel);
            messageBoxCS.AppendLine();
            MessageBox.Show(messageBoxCS.ToString(), "FormClosing Event");
        }*/

        /*override void OnFormClosing(FormClosingEventArgs e)
        {
            
            MessageBox.Show("Why close me?");
            Application.Exit();
        }*/

        /*private void Form1_FormClosing(object sender, FormClosingEventArgs e) 
        {

            if (string.Equals((sender as Button).Name, @"CloseButton"))
                MessageBox.Show("Why close me?");
                CheckAndStoreInputTimeLimit
        }*/



        private void button1_Click(object sender, EventArgs e)
        {
/*
            //TimeMetrics.CheckAndStoreInputTimeLimit(textBox3.Text);
            metricsObject.taskMetricsObject.CheckAndStoreInputTimeLimit(textBox3.Text);

            //needs mulptiple split inputs, not just one string
            //metricsObject.timeMetricsObject.CheckAndStoreInputGameTimeLimit(textBox3.Text);
            
            //notifyIcon1.Text="title";
               // notifyIcon1.BalloonTipText="My Hints go here";
           // notifyIcon1.Visible=true;
          //  notifyIcon1.ShowBalloonTip(1000);

            HintMetrics hintGivenObj = new HintMetrics();

            //stopwatch.Start();

            //TimeSpan test_time1 = stopwatch.Elapsed;
            string teststring2 = "Faaather!!!";
            //HintNumberAndTimestamps hintGivenObj = new HintNumberAndTimestamps();


            if (!metricsObject.GetGivenHintsList().ContainsKey(teststring2))
            {
                hintGivenObj.HintGiven(metricsObject.timeMetricsObject.GetCountTimeSinceBeginningOfGame());
                metricsObject.GetGivenHintsList().Add(teststring2, hintGivenObj);
            }
            else
            {
                HintMetrics temp_container;
                metricsObject.GetGivenHintsList().TryGetValue(teststring2, out temp_container);
                temp_container.HintGiven(metricsObject.timeMetricsObject.GetCountTimeSinceBeginningOfGame());
                //hintGivenObj.HintGiven(test_time);
            }

            //MessageBox.Show(teststring2, "Hint Time!");

            
            metricsObject.CheckAndStoreInputScore(textBox1.Text);
            MessageBox.Show("Your score is:"+metricsObject.GetGameScore().ToString()+
                    " Your input time limit is: " + metricsObject.taskMetricsObject.GetTaskTimeLimitInput());
            


            string hint = "Hints: ";
            for (int i = 0; i < metricsObject.GetGivenHintsList().Count; i++)
            {

                hint += " \n\n" + metricsObject.GetGivenHintsList().ElementAt(i).Key + " Timestamps: ";
                for (int j = 0; j < metricsObject.GetGivenHintsList().ElementAt(i).Value.GetTimeStamps().Count; j++)
                {
                    hint += metricsObject.GetGivenHintsList().ElementAt(i).Value.GetTimeStamps().ElementAt(j) + " -------- ";
                }
                hint += "number of times this hint is given: " + 
                    metricsObject.GetGivenHintsList().ElementAt(i).Value.GetHintCount();

            }

            hint += "\n\n";

            textBox2.Text += hint + System.Environment.NewLine;
            textBox2.SelectionStart = textBox2.Text.Length;
            textBox2.ScrollToCaret();
*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
 /*           //HintAssetObject.stopwatch.Stop();
            //HintAssetObject.errorFlag = true;

            HintMetrics hintGivenObj = new HintMetrics();

            //stopwatch.Stop();

            string teststring = "Strewth!";
            //TimeSpan test_time =stopwatch.Elapsed;

            //if (!metricsObject.givenHintsList.ContainsKey(teststring))
            //{
            //    hintGivenObj.HintGiven(test_time);
            //    metricsObject.givenHintsList.Add(teststring, hintGivenObj);
            //}
            //hintGivenObj.HintGiven(test_time);

            if (!metricsObject.GetGivenHintsList().ContainsKey(teststring))
            {
                hintGivenObj.HintGiven(metricsObject.timeMetricsObject.GetCountTimeSinceBeginningOfGame());
                metricsObject.GetGivenHintsList().Add(teststring, hintGivenObj);
            }
            else
            {
                HintMetrics temp_container;
                metricsObject.GetGivenHintsList().TryGetValue(teststring, out temp_container);
                temp_container.HintGiven(metricsObject.timeMetricsObject.GetCountTimeSinceBeginningOfGame());

                //test_time += test_time;
                //hintGivenObj.HintGiven(test_time);

                //test_time += test_time;
                //hintGivenObj.HintGiven(test_time);

                //test_time += test_time;
                //hintGivenObj.HintGiven(test_time);
            }

            //this.label2.Text = metricsObject.time_since_start_of_game.Elapsed.ToString();


            string hint = "Hints: ";
            for (int i = 0; i < metricsObject.GetGivenHintsList().Count; i++)
            {

                hint += " \n\n" + metricsObject.GetGivenHintsList().ElementAt(i).Key + " Timestamps: ";
                for (int j = 0; j < metricsObject.GetGivenHintsList().ElementAt(i).Value.GetTimeStamps().Count; j++)
                {
                    hint += metricsObject.GetGivenHintsList().ElementAt(i).Value.GetTimeStamps().ElementAt(j) + " -------- ";
                }
                hint += "number of times this hint is given: "
                    + metricsObject.GetGivenHintsList().ElementAt(i).Value.GetHintCount();

            }
            hint += "\n\n";

            textBox2.Text += hint + System.Environment.NewLine;
            textBox2.SelectionStart = textBox2.Text.Length;
            textBox2.ScrollToCaret();

            //Rules ruleObject = new Rules();
            rulesObject.CompareCurrentGameTimeWithGameTimeLimit();
            rulesObject.CheckIfHintShouldBeGiven();
   */
        }

        private void label1_Click(object sender, EventArgs e)
        {
          /*  string hint = "Hints: ";
            for (int i = 0; i < metricsObject.GetGivenHintsList().Count; i++)
            {

                hint += " \n" + metricsObject.GetGivenHintsList().ElementAt(i).Key + " Timestamps: ";
                for (int j = 0; j < metricsObject.GetGivenHintsList().ElementAt(i).Value.GetTimeStamps().Count; j++)
                {
                    hint += metricsObject.GetGivenHintsList().ElementAt(i).Value.GetTimeStamps().ElementAt(j) + "-";
                }
                hint +="number of times this hint is given: "
                    + metricsObject.GetGivenHintsList().ElementAt(i).Value.GetHintCount();

            }

            //this.label1.Text = "Time " + HintAssetObject.stopwatch.Elapsed;
            //HintAssetObject.SetTimeOfError(HintAssetObject.stopwatch.Elapsed);


            this.label1.Text = hint;
            //this.label1.Refresh();
         */
        }


    }
}
