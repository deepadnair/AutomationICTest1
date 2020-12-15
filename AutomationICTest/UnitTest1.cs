using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace AutomationICTest
{
    public class Tests
    {
        IWebDriver driver;
        //Login
        LoginPage login = new LoginPage();
        //Profile
        ProfilePage profile = new ProfilePage();
        //Customer Create
        CustomerPage customer = new CustomerPage();
        //Jobs
        JobsPage jobs = new JobsPage();
        //JobsCalender
        JobscalPage jobscal = new JobscalPage();

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/");
            driver.Manage().Window.Maximize();
        }
        [TearDown]
        public void TearDown()
        {
            driver.Close();
            driver.Dispose();
        }

        [Test]
        public void Test1()
        {

            login.Login(driver);
    //Asserting for Profile Name.
            profile.Profile(driver);
     //Creating Customer
             customer.Customer(driver);
     //Creating Jobs
            jobs.Jobs(driver);
      //      driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(100);
     //jobs Calender
            jobscal.Jobscal(driver);


        }
                  
    }
  
}