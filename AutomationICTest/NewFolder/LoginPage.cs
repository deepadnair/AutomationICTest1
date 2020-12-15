using OpenQA.Selenium;

namespace AutomationICTest
{
    public class LoginPage
    {
        IWebDriver driver;
        public void Login()
        {
            driver.FindElement(By.CssSelector("input[Name=UserName ]")).SendKeys("hari");
            driver.FindElement(By.CssSelector("input[id=Password]")).SendKeys("123123");
            driver.FindElement(By.CssSelector("input[type=Submit]")).Click();
        }
    }
}