using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumCSharp.Pages;

namespace SeleniumCSharp.Tests
{
	public class LoginTestPOM
	{
        IWebDriver driver;
        [SetUp]
		public void Setup()
		{
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://eaapp.somee.com/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

        }

		[Test]
		public void LoginTest()
		{
			string actualMsg = new LandingPage(driver).ClickLoginLink()
				.LoginToPortal("admin", "password").GetGreetingMessage();

			Assert.AreEqual("Hello admin!", actualMsg);

		}

		[TearDown]
		public void TearDown()
		{
			driver.Close();
			driver.Quit();

		}
	}
}

