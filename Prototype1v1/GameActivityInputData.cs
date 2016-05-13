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
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace Prototype1v1
{
    public class ActivityData
    {
        [XmlAttribute("activity_ID")]
        //the ID of the game activity
        public string activity_ID
        {
            get;
            set;
        }

        [XmlAttribute("recall_ID")]
        public string recall_ID
        {
            get;
            set;
        }

        [XmlAttribute("recallInputThresholds")]
        public List<int> recallInputThresholds
        {
            get;
            set;
        }

        [XmlAttribute("recongnition_ID")]
        public string recongnition_ID
        {
            get;
            set;
        }

        [XmlAttribute("recongnitionInputThresholds")]
        public List<int> recongnitionInputThresholds
        {
            get;
            set;
        }

        [XmlAttribute("classification_ID")]
        public string classification_ID
        {
            get;
            set;
        }
        [XmlAttribute("classificationInputThresholds")]
        public List<int> classificationInputThresholds
        {
            get;
            set;
        }

        [XmlAttribute("implementation_ID")]
        public string implementation_ID
        {
            get;
            set;
        }
        [XmlAttribute("implementationInputThresholds")]
        public List<int> implementationInputThresholds
        {
            get;
            set;
        }


        [XmlAttribute("customErrorsIDs")]
        public List<string> customErrorsIDs
        {
            get;
            set;
        }

        [XmlAttribute("customErrorsInputThresholds")]
        public List<string> customErrorsInputThresholds
        {
            get;
            set;
        }

        /*[XmlAttribute("customErrorData")]
        public Dictionary<string, string> customErrorData
        {
            get;
            set;
        }*/

        /*[XmlAttribute("time_on_activity_thresholds")]
        public List<TimeSpan> time_on_activity_thresholds
        {
            get;
            set;
        }*/
        [XmlAttribute("time_on_activity_thresholds")]
        public List<string> time_on_activity_thresholds
        {
            get;
            set;
        }

        

        public ActivityData()
        {
            activity_ID ="";
            recall_ID ="";
            recallInputThresholds = new List<int>();
            recongnition_ID ="";
            recongnitionInputThresholds= new List<int>();
            classification_ID ="";
            classificationInputThresholds = new List<int>();
            implementation_ID ="";
            implementationInputThresholds = new List<int>();

            //time_on_activity_thresholds = new List<TimeSpan>();
            time_on_activity_thresholds = new List<string>();

            customErrorsIDs = new List<string>();
            customErrorsInputThresholds = new List<string>();
            //customErrorData = new Dictionary<string, string>();
        }

        


    }


    [XmlRoot]
    public class AllActivitiesConfigData
    {
        [XmlArray("Activities"), XmlArrayItem("ActivityData")]
        public List<ActivityData> inputActivitiesList// = new List<ActivityData>();
        {
            get;
            set;
        }
        /*public List<ActivityData> inputActivitiesList
        {
            get;
            set;
        }*/

        [XmlArray("game_score_thresholds")]
        //this has to be here since it does not belong to a game activity but to the game
        //so it cannot be in an object of the inputActivitiesList
        public List<int> game_score_thresholds
        {
            get;
            set;
        }


        public AllActivitiesConfigData()
        {
            inputActivitiesList = new List<ActivityData>();
            game_score_thresholds = new List<int>();
        }

        public void SaveToFile(string path)
        {
            var serializer = new XmlSerializer(typeof(AllActivitiesConfigData));
            using (var stream = new FileStream(path, FileMode.Create))
            {
                serializer.Serialize(stream, this);
            }
        }

        public AllActivitiesConfigData LoadFromFile(string path)
        {
            try
            {
                var serializer = new XmlSerializer(typeof(AllActivitiesConfigData));
                using (var stream = new FileStream(path, FileMode.Open))
                {
                    return serializer.Deserialize(stream) as AllActivitiesConfigData;
                }
            }
            catch (Exception e)
            {
                throw e;
                //return null;
            }
        }

        

    }
    
        
}
