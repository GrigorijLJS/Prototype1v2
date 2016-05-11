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
namespace Prototype1v1
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Xml.Serialization;
    using AssetPackage;
    /// <summary>
    /// An asset settings.
    /// 
    /// BaseSettings contains the (de-)serialization methods.
    /// </summary>
    public class MyAssetSettings : BaseSettings
    {
        /// <summary>
        /// Initializes a new instance of the MyAssetSettings class.
        /// </summary>
        public MyAssetSettings()
            : base()
        {
            //
        }
        /// <summary>
        /// Gets or sets the test property.
        /// </summary>
        ///
        /// <value>
        /// The test property.
        /// </value>
        [DefaultValue("Hello Default World")]
        [XmlElement()]
        public String TestProperty
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the color of the test.
        /// </summary>
        ///
        /// <value>
        /// The color of the test.
        /// </value>
        



        /*Issues with this one [DefaultValue(typeof(Color), "Red")]
        public Color TestColor
        {
            get;
            set;
        }*/




        /// <summary>
        /// Gets the string[].
        /// </summary>
        ///
        /// <value>
        /// .
        /// </value>
        [XmlArray()]
        [XmlArrayItem("ListItem")]
        [DefaultValue(new String[] { "Hello", "List", "World" })]
        public String[] TestList
        {
            get;
            set;
        }
        /// <summary>
        /// Gets a value indicating whether the test read only.
        /// </summary>
        ///
        /// <value>
        /// true if test read only, false if not.
        /// </value>
        public Boolean TestReadOnly
        {
            get
            {
                return true;
            }
        }
    }
}
