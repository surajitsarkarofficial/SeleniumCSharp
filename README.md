Selenium C#

Nuget manager is used to manage the packages.



//Selenium <br>
IWebDriver driver = new ChromeDriver();<br>
driver.Manage().Window.Maximize();<br><br>

//Launch URL<br>
driver.Navigate().GoToUrl("url");<br><br>

//Store Locator<br>
IWebElement element = By.Id("locator");<br><br>

//Type<br>
driver.FindElement(element).SendKeys("Hello");<br><br>

//Click<br>
driver.FindElement(element).Click();<br><br>

//Dropdown<br>
SelectElement dd = new SelectElement(driver.FindElement(By.Xpath("sdf")));<br>
dd.SelectByText("ABC");<br>
dd.SelectByValue("abc");<br>
dd.SelectByIndex(2);<br>
dd.SelectedOption.Text;<br>
dd.AllSelectedOptions<br>
dd.DeselectByText("ac");<br>
dd.DeselectByValue();<br>
dd.DeselectByIndex();<br>
dd.DeselectAll();<br>
<br>
