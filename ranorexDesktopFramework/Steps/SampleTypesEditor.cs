/*
 * Created by Ranorex
 * User: Dell
 * Date: 5/1/2018
 * Time: 8:14 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ranorexDesktopFramework.Steps
{
	/// <summary>
	/// Description of SampleTypesEditor.
	/// </summary>
	public class SampleTypesEditor : BaseStep
	{
		public void AddSampleDefaultType()
		{
			Actions.ClickOnElement(repo.MyAssaysApp.SampleTypesEditor.AddSampleTypeButton);	
			Actions.ClickOnElement(repo.MyAssaysApp.SampleTypesEditor.SampleTypesEditorOkButton);
		}
	}
}
