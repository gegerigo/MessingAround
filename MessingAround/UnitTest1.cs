using MessingAround.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace MessingAround
{
	public class Tests : DriverHelper
	{

		[SetUp]
		public void Setup()
		{
			ChromeOptions option = new ChromeOptions();
			option.AddArguments("start-maximized");
			option.AddArguments("--disable-gpu");
			option.AddArguments("--headless");

			new DriverManager().SetUpDriver(new ChromeConfig());
			Console.WriteLine("Setup");
			Driver = new ChromeDriver(option);
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

		[Test]
		public void LoginTest()
		{
			Driver.Navigate().GoToUrl("http://eaapp.somee.com/");

			HomePage homePage = new HomePage();
			LoginPage loginPage = new LoginPage();

			homePage.ClickLogin();
			loginPage.EnterUserNameAndPassword("admin", "password");
			loginPage.ClickLogin();

			Assert.That(homePage.IsLogOffExists(), Is.True, "Log off button does not exist.");
		}
	}
}