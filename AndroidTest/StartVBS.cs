﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace AndroidTest
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The StartVBS recording.
    /// </summary>
    [TestModule("ec9fbe99-1523-4e2f-a0b2-da49e9019521", ModuleType.Recording, 1)]
    public partial class StartVBS : ITestModule
    {
        /// <summary>
        /// Holds an instance of the AndroidTestRepository repository.
        /// </summary>
        public static AndroidTestRepository repo = AndroidTestRepository.Instance;

        static StartVBS instance = new StartVBS();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public StartVBS()
        {
            varMobileDevice = "USB-8BFY0YN86";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static StartVBS Instance
        {
            get { return instance; }
        }

#region Variables

        string _varMobileDevice;

        /// <summary>
        /// Gets or sets the value of variable varMobileDevice.
        /// </summary>
        [TestVariable("45a6f65b-113d-435d-9662-ab20f4d8343f")]
        public string varMobileDevice
        {
            get { return _varMobileDevice; }
            set { _varMobileDevice = value; }
        }

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Application", "Run mobile app 'com.vodafone.viewer' on device 'USB-8BFY0YN86'.", new RecordItemIndex(0));
            Host.Local.RunMobileApp("USB-8BFY0YN86", "com.vodafone.viewer", true);
            Delay.Milliseconds(3500);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
