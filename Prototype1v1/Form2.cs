using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototype1v1
{
    public partial class Form2 : Form
    {

        private AllActivitiesConfigData activitiesDataObj;


        public Form2()
        {
            InitializeComponent();

            activitiesDataObj = new AllActivitiesConfigData();

            /*inputActivitiesList = new List<ActivityData>();
            game_score_thresholds = new List<int>();*/

            ((Control)errorsTab).Enabled = false;
            ((Control)timeTab).Enabled = false;
            //((Control)scoreTab).Enabled = false;
            //((Control)historyTab).Enabled = false;
            ((Control)finishTab).Enabled = false;


            tabControl1.SelectedIndexChanged += new EventHandler(tabControl1_SelectedIndexChanged);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            //base.OnFormClosing(e);
            //if (e.CloseReason == CloseReason.WindowsShutDown) return;
            //metricsObject.timeMetricsObject.StartAndStopTimeCounterSinceBeginningOfGame(false);
            //MessageBox.Show(this, "Oh, don't go, Boo will miss you. :(\n Log file created (NOT)!"
            //    , "Total time:" + metricsObject.timeMetricsObject.GetStoredCountTimeSinceBeginningOfGame());
        }

        private void tabControl1_SelectedIndexChanged(Object sender, EventArgs e) 
        {

            //once the tab with the history is selected...
            if (tabControl1.SelectedTab  == tabControl1.TabPages["historyTab"])
            {

                string error_type_recall = "Error (recall)";
                string error_type_recog = "Error (recognition)";
                string error_type_class = "Error (classification)";
                string error_type_implem = "Error (implementation)";
                string time_type = "Time-on-activity";
                string game_score_type = "Game score";

                string temp_container = "";

                //clear the table, so it does not pile up with repetitive data...
                historyTable.Rows.Clear();
                historyTable.Refresh();

                //and populate it with the input data from the users 
                foreach(ActivityData activity in activitiesDataObj.inputActivitiesList)
                {

                    if (activity.recallInputThresholds.Count > 0)
                    {
                        LoopThresholds(activity.recallInputThresholds, ref temp_container);
                        historyTable.Rows.Add(activity.activity_ID, activity.recall_ID, error_type_recall, temp_container);
                        temp_container = "";
                    }
                    if (activity.recongnitionInputThresholds.Count > 0)
                    {
                        LoopThresholds(activity.recongnitionInputThresholds, ref temp_container);
                        historyTable.Rows.Add(activity.activity_ID, activity.recongnition_ID, error_type_recog, temp_container);
                        temp_container = "";
                    }
                    if (activity.classificationInputThresholds.Count > 0)
                    {
                        LoopThresholds(activity.classificationInputThresholds, ref temp_container);
                        historyTable.Rows.Add(activity.activity_ID, activity.classification_ID, error_type_class, temp_container);
                        temp_container = "";
                    }
                    if (activity.implementationInputThresholds.Count>0)
                    {
                        LoopThresholds(activity.implementationInputThresholds, ref temp_container);
                        historyTable.Rows.Add(activity.activity_ID, activity.implementation_ID, error_type_implem, temp_container);
                        temp_container = "";
                    }
                    if (activity.time_on_activity_thresholds.Count>0)
                    {
                        LoopThresholds(activity.time_on_activity_thresholds, ref temp_container);
                        historyTable.Rows.Add(activity.activity_ID, time_type, time_type, temp_container);
                        temp_container = "";
                    }
                }

                if (activitiesDataObj.game_score_thresholds.Count > 0)
                {
                    LoopThresholds(activitiesDataObj.game_score_thresholds, ref temp_container);
                    historyTable.Rows.Add("", game_score_type, game_score_type, temp_container);
                    temp_container = "";
                }


            }
        }

        //private void LoopThresholds(ActivityData activity, ref string temp_container)
        private void LoopThresholds<T>(ICollection<T> the_list, ref string temp_container)
            //ICollection<Employee> employees, Func<Employee, T> fetchProperty)
        {
            foreach (var threshold in the_list)
            {
                temp_container += threshold + ", ";
            }
        }

        private void SaveActivityButton_Click(object sender, EventArgs e)
        {
            if((string.IsNullOrWhiteSpace(inputAcitityIDTextBox.Text)))
            {
                MessageBox.Show("You need to enter the identifier of a game activity, before it can be saved!");
            }
            else
            {
                               
                ActivityData activityDataObj = new ActivityData();
                activityDataObj.activity_ID=inputAcitityIDTextBox.Text;
                //activity_IDs.Add(inputAcitityIDTextBox.Text);

                bool flag_for_adding = true;
                foreach (ActivityData activity in activitiesDataObj.inputActivitiesList)
                {
                    if(activity.activity_ID==inputAcitityIDTextBox.Text)
                    {
                        MessageBox.Show("That identifier is already in use! All identifiers must be unique!");
                        flag_for_adding = false;

                        //clear the selection of the dropdowns on the other tabs
                        errorsDropDown.SelectedIndex = -1;
                        timeDropDown.SelectedIndex = -1;

                        break;
                    }
                }
                if(flag_for_adding)
                {
                    activitiesDataObj.inputActivitiesList.Add(activityDataObj);
                    addedActivitiesLabel.Text += "\n" + inputAcitityIDTextBox.Text;

                    if (errorsDropDown.Items.Count > 0 && timeDropDown.Items.Count > 0)
                    {
                        //deselect the items on the other tabs, just in case
                        //errorsDropDown.ResetText();
                        errorsDropDown.SelectedIndex = -1;
                        timeDropDown.SelectedIndex = -1;
                    }

                    errorsDropDown.Items.Add(inputAcitityIDTextBox.Text);
                    timeDropDown.Items.Add(inputAcitityIDTextBox.Text);
                }

                inputAcitityIDTextBox.Clear();

                //"unlock" some of the tabs since at least ome activity has been added 
                ((Control)errorsTab).Enabled = true;
                ((Control)timeTab).Enabled = true;
                ((Control)scoreTab).Enabled = true;
                ((Control)finishTab).Enabled = true;
            }
        }

        private void saveDefaultErrorsButton_Click(object sender, EventArgs e)
        {
            //if an activity is selected
            if(errorsDropDown.SelectedIndex>=0)
            {
                //IF ALL EMPTY -> SEND MESSAGE, 
                //ELSE IF (IN ANY PAIR OBLY ONE IS FILLED IN ->SEND MESSAGE
                //ELSE (OK

                //check if all the fields for the default errors are empty
                if(((string.IsNullOrWhiteSpace(recallIDTextBox.Text)&&
                    string.IsNullOrWhiteSpace(recallThresholdsTextBox.Text))
                  && (string.IsNullOrWhiteSpace(recognitionIDTextBox.Text) &&
                  string.IsNullOrWhiteSpace(recognitionThresholdsTextBox.Text))
                  && (string.IsNullOrWhiteSpace(classifyingIDTextBox.Text)
                  &&string.IsNullOrWhiteSpace(classifyingThresholdsTextBox.Text))
                  && (string.IsNullOrWhiteSpace(implementationIDTextBox.Text)
                  &&string.IsNullOrWhiteSpace(implementationThresholdsTextBox.Text))))
                {
                    //and tell that to the user
                    MessageBox.Show("Please use at least one of the default 4 errors "+
                            "(recall, recognize, classify, implement)and input some data about them!");
                }
                else//in case some data is filled in
                {
                    //check if in a pair one of the elements is empty (the error identifier or the thresholds) 
                    //if both of them are empty or filled in, that is fine
                    //a problem might happen when one of the items is empty, in which case a message is shown to the user
                    bool flag1 = true;
                    bool flag2 = true;
                    bool flag3 = true;
                    bool flag4 = true;

                    if ((string.IsNullOrWhiteSpace(recallIDTextBox.Text)
                        &&string.IsNullOrWhiteSpace(recallThresholdsTextBox.Text)))
                    {
                        flag1 = true;//if both are empty, it's OK
                    }
                    else
                    {
                        if((string.IsNullOrWhiteSpace(recallIDTextBox.Text) 
                            || string.IsNullOrWhiteSpace(recallThresholdsTextBox.Text)))
                        {
                            flag1 = false;
                        }
                    }
                    if ((string.IsNullOrWhiteSpace(recognitionIDTextBox.Text)
                        && string.IsNullOrWhiteSpace(recognitionThresholdsTextBox.Text)))
                    {
                        flag2 = true;
                    }
                    else
                    {
                        if ((string.IsNullOrWhiteSpace(recognitionIDTextBox.Text)
                            || string.IsNullOrWhiteSpace(recognitionThresholdsTextBox.Text)))
                        {
                            flag2 = false;
                        }
                    }
                    if ((string.IsNullOrWhiteSpace(classifyingIDTextBox.Text)
                    && string.IsNullOrWhiteSpace(classifyingThresholdsTextBox.Text)))
                    {
                        flag3 = true;
                    }
                    else
                    {
                        if ((string.IsNullOrWhiteSpace(classifyingIDTextBox.Text)
                            || string.IsNullOrWhiteSpace(classifyingThresholdsTextBox.Text)))
                        {
                            flag3 = false;
                        }
                    }
                    if ((string.IsNullOrWhiteSpace(implementationIDTextBox.Text)
                    && string.IsNullOrWhiteSpace(implementationThresholdsTextBox.Text)))
                    {
                        flag4 = true;
                    }
                    else
                    {
                        if ((string.IsNullOrWhiteSpace(implementationIDTextBox.Text)
                            || string.IsNullOrWhiteSpace(implementationThresholdsTextBox.Text)))
                        {
                            flag4 = false;
                        }
                    }

                    if (flag1 && flag2 && flag3 && flag4)
                    {
                        MessageBox.Show("OK Default");
                    }
                    else
                    {
                        MessageBox.Show("a pair is empty!");
                    }
                }

                ActivityData temp_extract = new ActivityData();

                foreach (ActivityData activity in activitiesDataObj.inputActivitiesList)
                {
                    if (activity.activity_ID == errorsDropDown.SelectedItem.ToString())
                    {
                        char[] splitters = { ' ', ',', ';', '.', ':', '\t' };
                        //save the unique ID for the error in recall
                        activity.recall_ID = recallIDTextBox.Text;

                        //save the thresholds for the same error
                        string[] temp_holder = ((recallThresholdsTextBox.Text).ToString()).Split(splitters);
                        foreach(string threshold in temp_holder)
                        {
                            int threshold_in_int_form;
                            if(Int32.TryParse(threshold, out threshold_in_int_form))
                            {
                                activity.recallInputThresholds.Add(threshold_in_int_form);
                            }
                        }
                        //clear the array so it can be reused
                        Array.Clear(temp_holder, 0, temp_holder.Length);


                        //save the unique ID for the error in recognition
                        activity.recongnition_ID = recognitionIDTextBox.Text;
                        //save the thresholds for the same error
                        temp_holder = ((recognitionThresholdsTextBox.Text).ToString()).Split(splitters);
                        foreach(string threshold in temp_holder)
                        {
                            int threshold_in_int_form;
                            if(Int32.TryParse(threshold, out threshold_in_int_form))
                            {
                                activity.recongnitionInputThresholds.Add(threshold_in_int_form);
                            }
                        }
                        //clear the array so it can be reused
                        Array.Clear(temp_holder, 0, temp_holder.Length);


                        //save the unique ID for the error in classification
                        activity.classification_ID= classifyingIDTextBox.Text;
                        //save the thresholds for the same error
                        temp_holder = ((classifyingThresholdsTextBox.Text).ToString()).Split(splitters);
                        foreach(string threshold in temp_holder)
                        {
                            int threshold_in_int_form;
                            if(Int32.TryParse(threshold, out threshold_in_int_form))
                            {
                                activity.classificationInputThresholds.Add(threshold_in_int_form);
                            }
                        }
                        //clear the array so it can be reused
                        Array.Clear(temp_holder, 0, temp_holder.Length);

                        
                        //save the unique ID for the error in classification
                        activity.implementation_ID= implementationIDTextBox.Text;
                        //save the thresholds for the same error
                        temp_holder = ((implementationThresholdsTextBox.Text).ToString()).Split(splitters);
                        foreach(string threshold in temp_holder)
                        {
                            int threshold_in_int_form;
                            if(Int32.TryParse(threshold, out threshold_in_int_form))
                            {
                                activity.implementationInputThresholds.Add(threshold_in_int_form);
                            }
                        }
                        //clear the array so it can be reused
                        Array.Clear(temp_holder, 0, temp_holder.Length);

                        //skip the rest of the activities, since we found the one we need
                        break;
                    }
                }
                
            }
            else
            {//if no activity is selected
                MessageBox.Show("Please select one of the activities from the menu at the top, before saving the data!");
            }
        }

        private void customErrorSaveButton_Click(object sender, EventArgs e)
        {
            //if an activity is selected
            if (errorsDropDown.SelectedIndex >= 0)
            {
                if(string.IsNullOrWhiteSpace(customErrorIDTextBox.Text)
                    || string.IsNullOrWhiteSpace(customErrorThresholdsTextBox.Text))
                {
                    MessageBox.Show("Please fill in all the data for the custom error, so it can be added!");
                }
                else
                {
                    ActivityData temp_extract = new ActivityData();

                    foreach (ActivityData activity in activitiesDataObj.inputActivitiesList)
                    {
                        if (activity.activity_ID == errorsDropDown.SelectedItem.ToString())
                        {
                            if (activity.customErrorsIDs.Contains(customErrorIDTextBox.Text.ToString()))
                            {
                                MessageBox.Show("That error was already added for this activity!");
                            }
                            else
                            {
                                activity.customErrorsIDs.Add(customErrorIDTextBox.Text);
                                activity.customErrorsInputThresholds.Add(customErrorThresholdsTextBox.Text);
                                MessageBox.Show("Custom error added!");
                            }
                            //old code
                            //if (activity.customErrorData.ContainsKey(customErrorIDTextBox.Text.ToString()))
                            //{
                            //    MessageBox.Show("That error was already added for this activity!");
                            //}
                            //else
                            //{
                            //    activity.customErrorData.Add(customErrorIDTextBox.Text, customErrorThresholdsTextBox.Text);
                            //    MessageBox.Show("Custom error added!");
                            //}

                            
                            //skip the rest of the activities, since we found the one we need
                            break;
                        }

                    }

                }
            }
            else
            {//if no activity is selected
                MessageBox.Show("Please select one of the activities from the menu at the top, before saving the data!");
            }
        }

        private void saveTimeThresholdButton_Click(object sender, EventArgs e)
        {
            //if an activity is selected
            if (timeDropDown.SelectedIndex >= 0)
            {
                if(string.IsNullOrWhiteSpace(hoursTextBox.Text) && string.IsNullOrWhiteSpace(minsTextBox.Text) &&
                    string.IsNullOrWhiteSpace(secsTextBox.Text))
                {
                    MessageBox.Show("Please fill at least one of the three fields!");
                }
                else
                {
                    ActivityData temp_extract = new ActivityData();

                    foreach (ActivityData activity in activitiesDataObj.inputActivitiesList)
                    {
                        if (activity.activity_ID == timeDropDown.SelectedItem.ToString())
                        {
                            int temp_hours = 0;
                            int temp_minutes = 0;
                            int temp_seconds = 0;
                            bool hours_flag = true;
                            bool mins_flag = true;
                            bool secs_flag = true;

                            if (!string.IsNullOrWhiteSpace(hoursTextBox.Text))
                            {
                                if(Int32.TryParse(hoursTextBox.Text.ToString(), out temp_hours))
                                {
                                    hours_flag = true;
                                }
                                else
                                {
                                    hours_flag = false;
                                }
                            }
                            if (!string.IsNullOrWhiteSpace(minsTextBox.Text))
                            {
                                if(Int32.TryParse(minsTextBox.Text.ToString(), out temp_minutes))
                                {
                                    mins_flag = true;
                                }
                                else
                                {
                                    mins_flag = false;
                                }
                            }
                            if (!string.IsNullOrWhiteSpace(secsTextBox.Text))
                            {
                                if(Int32.TryParse(secsTextBox.Text.ToString(), out temp_seconds))
                                {
                                    secs_flag = true;
                                }
                                else
                                {
                                    secs_flag = false;
                                }
                            }

                            if(hours_flag && mins_flag && secs_flag)
                            {
                                if(temp_hours!=0 ||temp_minutes!=0 || temp_seconds!=0)
                                {
                                    //activity.time_on_activity_thresholds.Add(new TimeSpan(temp_hours, temp_minutes, temp_seconds));
                                    activity.time_on_activity_thresholds.Add(temp_hours+":"+temp_minutes+":"+temp_seconds);
                                    MessageBox.Show("OK!");
                                }
                                else
                                {
                                    MessageBox.Show("No relevant data added!");
                                }
                            }
                            else
                            {
                                MessageBox.Show("error!");
                            }

                            //skip the rest of the activities, since we found the one we need
                            break;
                        }

                    }

                }
            }
            else
            {//if no activity is selected
                MessageBox.Show("Please select one of the activities from the menu at the top, before saving the data!");
            }
        }

        private void gameScoreButton_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(gameScoreTextBox.Text))
            {
                int score_threshold = 0;
                if(Int32.TryParse(gameScoreTextBox.Text.ToString(), out score_threshold))
                {
                    if(score_threshold!=0)
                    {
                        activitiesDataObj.game_score_thresholds.Add(score_threshold);
                    }

                    //"clean" the input in the textbox from the user, for convenience 
                    gameScoreTextBox.Clear();

                    if (!((Control)finishTab).Enabled)
                    {
                        //"unlock" the save-the-data tab, if not done so already
                        ((Control)finishTab).Enabled = true;
                    }
                }
                else
                {
                    MessageBox.Show("Please check your input! There seems to be an error with the input!");
                }

                
            }
        }

        private void saveExitButton_Click(object sender, EventArgs e)
        {
            string path = "";

            /*System.IO.Directory.CreateDirectory(System.IO.Directory.GetParent
                (System.IO.Directory.GetCurrentDirectory()).Parent.FullName+"\\ActivityConfData\\");*/
            //path=@"..\ActivityConfData\";
            path = System.IO.Directory.GetParent
                (System.IO.Directory.GetCurrentDirectory()).Parent.FullName;
            activitiesDataObj.SaveToFile(System.IO.Path.Combine(path, "configData.xml"));


            //string startupPath = System.IO.Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName;

            ///*System.Configuration.ConfigurationManager.AppSettings["WAAAAAAAAH"] = "GREENISBEST";
            //var mySetting = System.Configuration.ConfigurationManager.AppSettings["WAAAAAAAAH"];*/
            //foreach (string key in System.Configuration.ConfigurationManager.AppSettings)
            //{
            //    string value = System.Configuration.ConfigurationManager.AppSettings[key];
            //    MessageBox.Show(String.Format("Key: {0}, Value: {1}", key, value));
            //}

            //System.Configuration.ConfigurationManager.AppSettings.Add("WAAAAAAAAH", "GREENISBEST");

            //var config = System.Configuration.ConfigurationManager.OpenExeConfiguration
            //    (System.Configuration.ConfigurationUserLevel.None);
            //config.AppSettings.Settings["WAAAAAAAAH"].Value = "text";
            //config.Save(System.Configuration.ConfigurationSaveMode.Modified);
        }




    }
}
