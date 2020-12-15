using OpenQA.Selenium;

namespace AutomationICTest
{
    public class LoginPage
    {

        public void Login(IWebDriver driver)
        {
            driver.FindElement(By.CssSelector("input[Name=UserName ]")).SendKeys("hari");
            driver.FindElement(By.CssSelector("input[id=Password]")).SendKeys("123123");
            driver.FindElement(By.CssSelector("input[type=Submit]")).Click();
        }
    }
}