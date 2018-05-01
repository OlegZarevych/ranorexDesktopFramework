/*
 * Created by Ranorex
 * User: Dell
 * Date: 5/1/2018
 * Time: 12:02 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using Ranorex;
using Ranorex.Core;

namespace ranorexDesktopFramework.Steps
{
	/// <summary>
	/// Description of Actions.
	/// </summary>
	public static class Actions
	{		
		public static void ClickOnElement(Element element)
		{
			Mouse.Click(element);
		}
	}
}
