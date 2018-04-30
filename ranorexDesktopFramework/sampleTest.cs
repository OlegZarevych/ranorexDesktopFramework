/*
 * Created by Ranorex
 * User: Dell
 * Date: 5/1/2018
 * Time: 1:03 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using WinForms = System.Windows.Forms;

using ranorexDesktopFramework.Steps;

namespace ranorexDesktopFramework
{
    /// <summary>
    /// Description of sampleTest.
    /// </summary>
    [TestModule("EA00A79E-5774-44F1-945D-6F1575AB17D3", ModuleType.UserCode, 1)]
    public class sampleTest : ITestModule
    {
    	private App app;
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public sampleTest()
        {
            // Do not delete - a parameterless constructor is required!
        }

        /// <summary>
        /// Performs the playback of actions in this module.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;
            
            app = new App();
            
            app.Run();
        }
    }
}
