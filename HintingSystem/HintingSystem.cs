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
    using System.Collections.Generic;
    using System.Linq;
    using AssetManagerPackage;
    using AssetPackage;


    //using System.Diagnostics;

    /// <summary>
    /// An asset that provides hints to the players.
    /// </summary>

    public class HintingAsset : BaseAsset
    {

        #region Fields
        /// <summary>
        /// Options for controlling the operation.
        /// </summary>
        private MyAssetSettings settings = null;

        /*private TimeSpan timeOfError;

        public Stopwatch stopwatch = new Stopwatch();

        public bool errorFlag = false;*/
        #endregion Fields


        #region Constructors
        /// <summary>
        /// Initializes a new instance of the MyAsset class.
        /// </summary>
        public HintingAsset() : base()
        {
            //! Create Settings and let its BaseSettings class assign Defaultvalues where it can.
            // 
            settings = new MyAssetSettings();
        }
        #endregion Constructors


        #region Properties
        /// <summary>
        /// Gets or sets options for controlling the operation.
        /// </summary>
        ///
        /// <remarks>   Besides the toXml() and fromXml() methods, we never use this property but use
        ///                it's correctly typed backing field 'settings' instead. </remarks>
        /// <remarks> This property should go into each asset having Settings of its own. </remarks>
        /// <remarks>   The actual class used should be derived from BaseSettings (and not directly from
        ///             ISetting). </remarks>
        ///
        /// <value>
        /// The settings.
        /// </value>
        public override ISettings Settings
        {
            get
            {
                return settings;
            }
            set
            {
                settings = (value as MyAssetSettings);
            }
        }


        /*//bogus setter for the time of a "mistake"
        public void SetTimeOfError(TimeSpan newValue)
        {
            timeOfError = newValue;
        }*/

        #endregion Properties


        #region Methods
        // Your code goes here. 
        // Try to keep only API code to be used by the Game-Engine here 
        // and put all other code in separate classes.
        /*public void CheckForErrors()
        {
            if(errorFlag==true)
            {

            }
        }*/

        #endregion Methods
    }
}
