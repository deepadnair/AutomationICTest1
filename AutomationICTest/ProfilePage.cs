using NUnit.Framework;
using OpenQA.Selenium;

namespace AutomationICTest
{
   public class ProfilePage
    {

        public void Profile(IWebDriver driver)
        {
            var username = driver.FindElements(By.CssSelector("a[data-toggle=dropdown]"))[1].Text;
            Assert.AreEqual(username, "Hello hari!");
        }
    }
}