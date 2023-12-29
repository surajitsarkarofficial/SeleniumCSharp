Selenium C#

Nuget manager is used to manage the packages.



//Selenium 
IWebDriver driver = new ChromeDriver();
driver.Manage().Window.Maximize();

//Launch URL
driver.Navigate().GoToUrl("url");

//Store Locator
IWebElement element = By.Id("locator");

//Type
driver.FindElement(element).SendKeys("Hello");

//Click
driver.FindElement(element).Click();

//Dropdown
SelectElement dd = new SelectElement(driver.FindElement(By.Xpath("sdf")));
dd.SelectByText("ABC");
dd.SelectByValue("abc");
dd.SelectByIndex(2);
dd.SelectedOption.Text;
dd.AllSelectedOptions
dd.DeselectByText("ac");
dd.DeselectByValue();
dd.DeselectByIndex();
dd.DeselectAll();
