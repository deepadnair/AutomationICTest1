using OpenQA.Selenium;


namespace AutomationICTest
{
    public class JobsPage
    {
        
       public void Jobs(IWebDriver driver)
    {
      driver.FindElement(By.XPath("//a[contains(text(),'Jobs')]")).Click();
       // driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[2]/a")).Click();
       //driver.FindElement(By.ClassName("btn")).Click();
        
    }
}
}