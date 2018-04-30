/*
 * Created by Ranorex
 * User: Dell
 * Date: 5/1/2018
 * Time: 1:10 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

using Ranorex;
using Ranorex.Core;

namespace ranorexDesktopFramework.Steps
{
	/// <summary>
	/// Description of App.
	/// </summary>
	public class App
	{
		public void Run()
		{
			Report.Log(ReportLevel.Info, "Application", "Run application 'C:\\Program Files (x86)\\MyAssays\\MyAssays Desktop\\MyAssays.Desktop.Explorer.exe' with arguments '' in normal mode.", new RecordItemIndex(0));
            Host.Local.RunApplication(Const.APP_EXEC_PATH, "", Const.APP_PATH, false);
            Delay.Milliseconds(10000);
		}
	}
}
