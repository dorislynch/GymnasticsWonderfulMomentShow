using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Gymnastics.Wonderful.Moment.Show.RNGymnasticsWonderfulMomentShow
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNGymnasticsWonderfulMomentShowModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNGymnasticsWonderfulMomentShowModule"/>.
        /// </summary>
        internal RNGymnasticsWonderfulMomentShowModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNGymnasticsWonderfulMomentShow";
            }
        }
    }
}
