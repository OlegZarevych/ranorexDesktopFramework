/*
 * Created by Ranorex
 * User: Dell
 * Date: 5/1/2018
 * Time: 1:05 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ranorexDesktopFramework.Steps
{
	/// <summary>
	/// Description of NewProtocolWizzard.
	/// </summary>
	public static class NewProtocolWizzard
	{
		public static ranorexDesktopFrameworkRepository repo = ranorexDesktopFrameworkRepository.Instance;
    	
		public static void WillEnterInMyData()
		{
			Actions.ClickOnElement(repo.MyAssaysApp.IwillEnterInMyDataRadio);
			Actions.ClickOnElement(repo.MyAssaysApp.NextButton);
		}
		
	}
}
