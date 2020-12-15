using OpenQA.Selenium;

namespace AutomationICTest
{
    public class CustomerPage
    {

        public void Customer(IWebDriver driver)
        {
        driver.FindElements(By.CssSelector("a[data-toggle]"))[0].Click();
            driver.FindElement(By.XPath("//a[contains(text(),'Customers')]")).Click();
          //  driver.FindElement(By.CssSelector("p a[class=btn btn-primary]")).Click();
            driver.FindElement(By.XPath("//a[contains(text(),'Create New')]")).Click();
            driver.FindElement(By.CssSelector("input [id=Name]")).SendKeys("HariK");
            // driver.FindElements(By.XPath("//input[@id='Name']"));
            driver.FindElement(By.CssSelector("button [id=EditContactButton]")).Click();
            driver.FindElement(By.CssSelector("input [id=FirstName]")).SendKeys("Hari");
            driver.FindElement(By.CssSelector("input [id=LastName]")).SendKeys("kumar");
            driver.FindElement(By.CssSelector("input [id=phone]")).SendKeys("345432");
            driver.FindElement(By.CssSelector("input [id=email]")).SendKeys("harikumar@gmail.com");
            driver.FindElement(By.CssSelector("input [value=save]")).Click();

    }
    }
}
