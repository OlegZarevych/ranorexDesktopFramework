/*
 * Created by Ranorex
 * User: Dell
 * Date: 5/1/2018
 * Time: 12:48 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ranorexDesktopFramework.Steps
{
	/// <summary>
	/// Description of Steps.
	/// </summary>
	public static class MainWindow
	{
    	public static ranorexDesktopFrameworkRepository repo = ranorexDesktopFrameworkRepository.Instance;
    	
    	
		public static void CreateNewProtocol()
		{
			Actions.ClickOnElement(repo.MyAssaysApp.ProtocolsButton);
			Actions.ClickOnElement(repo.MyAssaysApp.HomeNewButton);
		}
	}
}
