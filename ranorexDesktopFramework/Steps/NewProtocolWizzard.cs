/*
 * Created by Ranorex
 * User: Dell
 * Date: 5/1/2018
 * Time: 1:05 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using Ranorex;

namespace ranorexDesktopFramework.Steps
{
	/// <summary>
	/// Description of NewProtocolWizzard.
	/// </summary>
	public class NewProtocolWizzard : BaseStep
	{
		public void WillEnterInMyData()
		{
			Actions.ClickOnElement(repo.MyAssaysApp.NewProtocolWizzard.IwillEnterInMyDataRadio);
			Actions.ClickOnElement(repo.MyAssaysApp.NewProtocolWizzard.NextButton);
		}
		
		public void NextButton()
		{
			Actions.ClickOnElement(repo.MyAssaysApp.NewProtocolWizzard.NextButton);
		}
		
		public SampleTypesEditor OpenManageTypes()
		{
			Actions.ClickOnElement(repo.MyAssaysApp.NewProtocolWizzard.ManageTypesButton);
			return new SampleTypesEditor();
		}
		
		public void MaximizeWindow()
		{
			Actions.ClickOnElement(repo.MyAssaysApp.NewProtocolWizzard.MaximizeWindowButton);
		}
		
		public void CheckNewDefaultTypeExist()
		{
			Validate.Attribute(repo.MyAssaysApp.NewProtocolWizzard.ExpectedNewDefaultTypeByNameInfo, "Visible", "True");
			Validate.Attribute(repo.MyAssaysApp.NewProtocolWizzard.ExpectedNewDefaultTypeByNameInfo, "Enabled", "True");
		}
	}
}
