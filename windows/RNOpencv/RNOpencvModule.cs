using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Com.Reactlibrary.RNOpencv
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNOpencvModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNOpencvModule"/>.
        /// </summary>
        internal RNOpencvModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNOpencv";
            }
        }
    }
}
