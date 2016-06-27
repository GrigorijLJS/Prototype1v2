﻿/*Copyright 2016 OUNL

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
using System.Linq;
using System.Text;

//using System.Threading.Tasks;


//for getting keyboard input
//using System.Windows.Input;

namespace Prototype1v1
{
    // the "main" class for storing the player metrics 

    public class PlayerMetrics
    {
        public AllActivitiesConfigData configDataObj
        {
            get;
            set;
        }

        

        //objects for the "subordinate" classes that contain their metrics by type
        public TimeMetrics timeMetricsObject
        {
            get;
            set;
        }

        public ActivityMetrics activityMetricsObject
        {
            get;
            set;
        }

        public DiagnosticRules rulesObject
        {
            get;
            set;
        }
        /*public ErrorMetrics errorMetricsObject
        {
            get;
            set;
        }

        public HintMetrics hintMetricsObject
        {
            get;
            set;
        }*/


        // TODO nothing


        /// <summary>
        /// fields 
        /// </summary>

        /*//used to store the errors (by type), # of times encountered and the timestamps when they occured
        // private Dictionary<string, ErrorMetrics> encouteredErrorsList;
		public Dictionary<string, ErrorMetrics> EncouteredErrorsList
		{
			// return encouteredErrorsList;
			get;
			set;
		}

        //used to store the hints given to the players (by type), # of times they were given 
        //and the timestamps when they were given
        //private Dictionary<string, HintMetrics> givenHintsList;
		public Dictionary<string, HintMetrics> givenHintsList
		{
			get;
			set;
		}*/

        //used to store the learning activities (in the game (by id/name), 
        //along with other activity related data
        public Dictionary<string, ActivityMetrics> gameActivitiesList
        {
            get;
            set;
        }

        /////////
        /////////the following fields require input from the users (not the players) or the games
        /////////

        /*//player name/nickname
        //used to identify the players
        private string player_name = "";*/
        public string player_name
        {
            get;
            private set;
        }

        //gender of the player
        //might be usefull for personalization; could be left empty and then it will not be used
        private string player_gender = "";

        //the player's score - based on the game (requires input from the users (or games) of the hintning system)
        //this could include score based on various terms such as: game points, correct actions performed, etc.
        //if left to be 0, it will not be used 
        //private int game_score = 0;
        public int game_score
        {
            get;
            set;
        }


        public int game_score_previous_state
        {
            get;
            set;
        }

        public List<int> game_score_triggers
        {
            get;
            set;
        }

        public List<int> game_score_default_triggers
        {
            get;
            set;
        }

        //may not be needed
        public List<bool> game_score_thresholds_compared
        {
            get;
            set;
        }

        public int max_game_score
        {
            get;
            set;
        }

        public int min_game_score
        {
            get;
            set;
        }



        public PlayerMetrics()
        {
            /*EncouteredErrorsList = new Dictionary<string, ErrorMetrics>();
            givenHintsList = new Dictionary<string, HintMetrics>();*/
            gameActivitiesList = new Dictionary<string, ActivityMetrics>();

            timeMetricsObject = new TimeMetrics();
            activityMetricsObject = new ActivityMetrics();
            //rulesObject = new DiagnosticRules();

            game_score = 0;
            game_score_previous_state = 0;
            max_game_score = 0;
            min_game_score = 0;
            game_score_triggers = new List<int>();
            game_score_default_triggers = new List<int>();
            game_score_thresholds_compared = new List<bool>();

            game_score_default_triggers.Add(3);
            game_score_default_triggers.Add(23);

            configDataObj = new AllActivitiesConfigData();

            //the path is hardcoded, for now
            //this might work: AppDomain.CurrentDomain.BaseDirectory;
            //once these files are made into dlls
            configDataObj.LoadFromFile(@"D:\Visual Studio 2013 Projects\Prototype1v2\Prototype1v1");
            StoreConfigDataOfActivitiesForUseDuringRuntime();
            
        }


        private void StoreConfigDataOfActivitiesForUseDuringRuntime()
        {

            foreach(int score_threshold in configDataObj.game_score_thresholds)
            {
                game_score_triggers.Add(score_threshold);
            }

            foreach(ActivityData activity_config_data in configDataObj.inputActivitiesList)
            {
                ActivityMetrics new_activity = new ActivityMetrics();
                if(activity_config_data.recall_ID!=null && activity_config_data.recallInputThresholds.Count>0)
                {
                    ErrorMetrics recall_err = new ErrorMetrics();
                    LoopThroughAndSaveConfigThresholdData(activity_config_data.recallInputThresholds,
                        recall_err.error_number_thresholds);
                    new_activity.EncouteredErrorsList.Add(activity_config_data.recall_ID, recall_err);
                }
                if(activity_config_data.recongnition_ID!=null && activity_config_data.recongnitionInputThresholds.Count>0)
                {
                    ErrorMetrics recognition_err = new ErrorMetrics();
                    LoopThroughAndSaveConfigThresholdData(activity_config_data.recongnitionInputThresholds,
                        recognition_err.error_number_thresholds);
                    new_activity.EncouteredErrorsList.Add(activity_config_data.recongnition_ID, recognition_err);
                }
                if(activity_config_data.classification_ID!=null && activity_config_data.classificationInputThresholds.Count>0)
                {
                    ErrorMetrics classification_err = new ErrorMetrics();
                    LoopThroughAndSaveConfigThresholdData(activity_config_data.classificationInputThresholds,
                        classification_err.error_number_thresholds);
                    new_activity.EncouteredErrorsList.Add(activity_config_data.classification_ID, classification_err);
                }
                if(activity_config_data.implementation_ID!=null && activity_config_data.implementationInputThresholds.Count>0)
                {
                    ErrorMetrics implementation_err = new ErrorMetrics();
                    LoopThroughAndSaveConfigThresholdData(activity_config_data.implementationInputThresholds,
                        implementation_err.error_number_thresholds);
                    new_activity.EncouteredErrorsList.Add(activity_config_data.implementation_ID, implementation_err);
                }

                
                if((activity_config_data.customErrorsIDs.Count>0 && activity_config_data.customErrorsInputThresholds.Count>0)&&
                    (activity_config_data.customErrorsIDs.Count==activity_config_data.customErrorsInputThresholds.Count))
                {

                    for(int i=0;i<activity_config_data.customErrorsIDs.Count;i++)
                    {
                        ErrorMetrics custom_err = new ErrorMetrics();
                        string[] split_thresholds = activity_config_data.customErrorsInputThresholds.ElementAt(i).Split(
                            ' ', ',', ';', '.', ':', '\t');
                        for (int j = 0; j < split_thresholds.Count();j++)
                        {
                            custom_err.error_number_thresholds.Add(Int32.Parse(split_thresholds.ElementAt(j)));
                        }
                            new_activity.EncouteredErrorsList.Add(activity_config_data.customErrorsIDs.ElementAt(i), custom_err);
                    }
                }

                if(activity_config_data.time_on_activity_thresholds.Count>0)
                {
                    foreach(string time_threshold in activity_config_data.time_on_activity_thresholds)
                    {
                        string[] split_threshold = time_threshold.Split(':');
                        new_activity.list_of_times_on_activity.Add(new TimeSpan(Int32.Parse(split_threshold.ElementAt(0)),
                            Int32.Parse(split_threshold.ElementAt(1)),Int32.Parse(split_threshold.ElementAt(2))));
                    }
                }


                gameActivitiesList.Add(activity_config_data.activity_ID, new_activity);
            }
        }

        private void LoopThroughAndSaveConfigThresholdData(List<int> list_of_thresholds, List<int> empty_list_of_thresholds)
        {
            foreach(int threshold in list_of_thresholds)
            {
                empty_list_of_thresholds.Add(threshold);
            }
        }

        /*public int GetGameScore()
        {
            return game_score;
        }

        private void SetGameScore(int input_value)
        {
            game_score = input_value;
        }*/



        //public string PlayerNameEx
        //{
        //    get
        //    {
        //        return "mySelf";
        //    }
        //    private set
        //    {
        //        player_name = value;
        //    }
        //}
        /*public string GetPlayerName()
        {
            return player_name;
        }

        public void SetPlayerName(string input_value)
        {
            player_name = input_value;
        }*/

        public string GetPlayerGender()
        {
            return player_gender;
        }

        public void SetPlayerGender(string input_value)
        {
            player_gender = input_value;
        }



        /*public Dictionary<string, HintMetrics> GetGivenHintsList()
        {
            return givenHintsList;
        }

        public Dictionary<string, ActivityMetrics> GetTasksList()
        {
            return tasksList;
        }*/


        public void StoreInputThresholdsToGameScore(int limit)
        {
            game_score_triggers.Add(limit);
            game_score_thresholds_compared.Add(false);
        }

        /*public ErrorMetrics NewErrorMetricsObject()
        {
            return new ErrorMetrics();
        }*/




        //function to be used with GUI, gets strings and converts them to integer
        //get the input for the score from the game/user and store it
        public void CheckAndStoreInputScore(string input_score)
        {
            Utilities utilityObject = new Utilities();

            //if the input is not empty and contains only a number
            //if (!string.IsNullOrWhiteSpace(input_score) && utilityObject.IncludesDigitsOnly(input_score))
            //does not work in Unity
            if (!utilityObject.ConsistsOfWhiteSpace(input_score) && utilityObject.IncludesDigitsOnly(input_score))
            {
                //store the previous state of the score so it can be checked in the rules
                game_score_previous_state = game_score;
                game_score = Int32.Parse(input_score);
                //SetGameScore(Int32.Parse(input_score));//store it
            }
        }

        //overload for the function above, this one gets integers
        //get the input for the score from the game/user and store it
        public void CheckAndStoreInputScore(int input_score)
        {
            //store the previous state of the score so it can be checked in the rules
            game_score_previous_state = game_score;
            game_score = input_score;
            //SetGameScore(input_score);//store it
        }


        public string TrackAndStoreErrorForThisActivity(string current_activity_ID, string error_ID)
        {
            ActivityMetrics current_activity = null;
            ErrorMetrics temp_error_for_first = null;
            string would_be_hint = "";

            gameActivitiesList.TryGetValue(current_activity_ID, out current_activity);

            current_activity.EncouteredErrorsList
                                        .TryGetValue(error_ID, out temp_error_for_first);
            temp_error_for_first.ErrorMade(current_activity.time_on_activity.Elapsed);

            string errorInfo = error_ID + " timestamps: "
                + temp_error_for_first.error_time_stamps.Count + "#  ";

            for (int i = 0; i < temp_error_for_first.error_time_stamps.Count; i++)
            {
                errorInfo += temp_error_for_first.error_time_stamps[i] + "  ";
            }

            //rulesObject.CheckRulesForErrors(ref current_activity, ref would_be_hint);

            return ("Hint: " + would_be_hint + " info for errors " + errorInfo);
        }


    }


}



///////////////////////old code "Metrics"
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;


////for getting keyboard input
//using System.Windows.Input;

//namespace Prototype1v1
//{
//    // the "main" class for storing the player metrics 

//    public class Metrics
//    {

//        //objects for the "subordinate" classes that contain their metrics by type
//        public TimeMetrics timeMetricsObject
//        {
//            get;
//            set;
//        }

//        public ActivityMetrics taskMetricsObject
//        {
//            get;
//            set;
//        }

//        public ErrorMetrics errorMetricsObject
//        {
//            get;
//            set;
//        }

//        public HintMetrics hintMetricsObject
//        {
//            get;
//            set;
//        }

//        /// <summary>
//        /// fields 
//        /// </summary>

//        //used to store the errors (by type), # of times encountered and the timestamps when they occured
//        private Dictionary<string, ErrorMetrics> encouteredErrorsList;

//        //used to store the hints given to the players (by type), # of times they were given 
//        //and the timestamps when they were given
//        private Dictionary<string, HintMetrics> givenHintsList;



//        /////////
//        /////////the following fields require input from the users (not the players) or the games
//        /////////

//        //player name/nickname
//        //used to identify the players
//        private string player_name = "";

//        //gender of the player
//        //might be usefull for personalization; could be left empty and then it will not be used

//        private string player_gender = "";

//        //the player's score - based on the game (requires input from the users of the hintning system)
//        //this could include terms such as: game points, correct actions performed, etc.
//        //if left to be 0 - it will not be used 
//        private int game_score = 0;



//        /// <summary>
//        /// constructors
//        /// </summary>

//        public Metrics()
//        {
//            encouteredErrorsList = new Dictionary<string, ErrorMetrics>();
//            givenHintsList = new Dictionary<string, HintMetrics>();
//            timeMetricsObject = new TimeMetrics();
//            taskMetricsObject = new ActivityMetrics();
//        }


//        /// <summary>
//        /// getters/setters
//        /// </summary>
//        public int GetGameScore()
//        {
//            return game_score;
//        }

//        private void SetGameScore(int input_value)
//        {
//            game_score = input_value;
//        }

//        public string GetPlayerName()
//        {
//            return player_name;
//        }

//        public void SetPlayerName(string input_value)
//        {
//            player_name = input_value;
//        }

//        public string GetPlayerGender()
//        {
//            return player_gender;
//        }

//        public void SetPlayerGender(string input_value)
//        {
//            player_gender = input_value;
//        }

//        public Dictionary<string, ErrorMetrics> GetEncouteredErrorsList()
//        {
//            return encouteredErrorsList;
//        }

//        public Dictionary<string, HintMetrics> GetGivenHintsList()
//        {
//            return givenHintsList;
//        }

//        /// <summary>
//        /// methods
//        /// </summary>


//        //a function used for writing all the data from the metrics to a .txt file
//        //used as a log file
//        //!!!!!!!!!!!!!!!!!!!!!!!!change the path to one that makes actual sense or serialization
//        //!!!!!!!!!!!!!!!!!!!!maybe should be in the utility class
//        public void WriteToLogFile()
//        {
//            //using (System.IO.StreamWriter output_file =
//            //new System.IO.StreamWriter(@"C:\test.txt"))
//            //{
//            //    //foreach (string line in lines)
//            //    //{
//            //    //    output_file.WriteLine(line);
//            //    //}
//            //    output_file.WriteLine("Log of the metrics:\n\n");
//            //}
//        }


//        //function to be used with GUI, gets strings and converts them to integer
//        //get the input for the score from the game/user and store it
//        public void CheckAndStoreInputScore(string input_score)
//        {
//            Utilities utilityObject = new Utilities();

//            //if the input is not empty and contains only a number
//            if (!string.IsNullOrWhiteSpace(input_score) && utilityObject.IncludesDigitsOnly(input_score))
//            {
//                SetGameScore(Int32.Parse(input_score));//store it
//            }
//        }

//        //overload for the function above, this one gets integers
//        //get the input for the score from the game/user and store it
//        public void CheckAndStoreInputScore(int input_score)
//        {

//            SetGameScore(input_score);//store it
//        }




//    }


//}
