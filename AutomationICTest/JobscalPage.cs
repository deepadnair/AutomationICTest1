using OpenQA.Selenium;

namespace AutomationICTest
{
    public class JobscalPage
    {
        
        public void Jobscal(IWebDriver driver)
        {

            driver.FindElement(By.XPath("//a[contains(text(),'Jobs Calendar')]")).Click();

            /*var mySelectElm = driver.FindElement(By.Id("CompanyClientDropDown"));
             var mySelect = new SelectElement(mySelectElm);
             mySelect.SelectByValue("All");*/

            driver.FindElement(By.ClassName("k-input")).Click();
            

            //var mySelectElmm = driver.FindElement(By.Id("StatusDropDown"));
            // var mySelectt = new SelectElement(mySelectElmm);
            //mySelectt.SelectByText("All");//var mySelectElm = driver.FindElement(By.ClassName("k-select"));
            //var mySelect = new SelectElement(mySelectElm);
            // mySelect.SelectByText("All");
            //var mySelectElmm = driver.FindElement(By.Id("StatusDropDown"));
            // var mySelectt = new SelectElement(mySelectElmm);
            //mySelectt.SelectByText("All");

        }
    }
}