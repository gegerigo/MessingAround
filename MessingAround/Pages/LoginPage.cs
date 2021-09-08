using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessingAround.Pages
{
	public class LoginPage : DriverHelper
	{
		IWebElement lnkLogin => Driver.FindElement(By.LinkText("Login"));

		public void ClickLogin() => lnkLogin.Click();
	}
}
