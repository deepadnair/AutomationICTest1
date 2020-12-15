using NUnit.Framework;
using OpenQA.Selenium;

namespace AutomationICTest
{
   public class ProfilePage
    {
        IWebDriver driver;
        public void Profile()
        {
            var username = driver.FindElements(By.CssSelector("a[data-toggle=dropdown]"))[1].Text;
            Assert.AreEqual(username, "Hello hari!");
        }
    }
}