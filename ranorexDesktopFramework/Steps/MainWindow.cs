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
	public class MainWindow : BaseStep
	{
		public NewProtocolWizzard CreateNewProtocol()
		{
			Actions.ClickOnElement(repo.MyAssaysApp.ProtocolsButton);
			Actions.ClickOnElement(repo.MyAssaysApp.HomeNewButton);
			return new NewProtocolWizzard();
		}
	}
}
