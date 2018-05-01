/*
 * Created by Ranorex
 * User: Dell
 * Date: 5/1/2018
 * Time: 10:00 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
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

namespace ranorexDesktopFramework.Steps
{
    /// <summary>
    /// Description of AppClose.
    /// </summary>
    [TestModule("F80F3C7D-D4F8-4369-BC72-3D93BA00CE34", ModuleType.UserCode, 1)]
    public class AppClose : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public AppClose()
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
            
            Element proc = "/form[@processname='MyAssays.Desktop.Explorer']";
            
            Host.Local.KillApplication(proc);
        }
    }
}
