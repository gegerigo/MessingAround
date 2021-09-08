using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace MessingAround
{
	public class Tests : DriverHelper
	{

		[SetUp]
		public void Setup()
		{
			Console.WriteLine("Setup");
			Driver = new ChromeDriver();
		}

		[Test]
		public void Test1()
		{
			Driver.Navigate().GoToUrl("https://demowf.aspnetawesome.com");

			//CustomControl.EnterText(Driver.FindElement(By.Id("ContentPlaceHolder1_Meal")),"Mango");
			//CustomControl.Click(Driver.FindElement(By.XPath("//input[@name='ctl00$ContentPlaceHolder1$ChildMeal1']/following-sibling::div[text()='Celery']")));

			CustomControl.SelectByText(Driver.FindElement(By.Id("ContentPlaceHolder1_Add1-awed")), "Cauliflower");
			
			CustomControl.ComboBox("ContentPlaceHolder1_AllMealsCombo", "Almond");

			Assert.Pass();
		}
	}
}