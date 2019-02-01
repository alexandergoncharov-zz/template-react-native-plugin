using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Test.Package.RNTestPackage
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNTestPackageModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNTestPackageModule"/>.
        /// </summary>
        internal RNTestPackageModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNTestPackage";
            }
        }
    }
}
