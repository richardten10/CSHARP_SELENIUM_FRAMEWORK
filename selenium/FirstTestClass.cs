using NUnit.Framework;
using OpenQA.Selenium;
using System;

namespace selenium
{
    class FirstTestClass
    {
        static DriverFactory driverFactory = new DriverFactory();
        static IWebDriver driver = driverFactory.getDriver();
        FirstPage firstpage = new FirstPage(driver);

        [SetUp]
        public void Initialize()
        {
            firstpage.goTo(); 
            Console.WriteLine("Opened URL");
        }


        [Test]
        public void ExecuteTest()
        {
            firstpage.searchForTrainline();
            Console.WriteLine("searched");

            firstpage.clickOnSite();
            Console.WriteLine("clicked on site");

            Assert.AreEqual("Trainline | Buy Cheap Train Tickets | Live Train Times & Fares", driver.Title);
            Console.WriteLine("Page title is correct");
        }

        [Test]
        public void NextTest()
        {
            Console.WriteLine("Next method started");
        }

        [TearDown]
        public void CleanUp()
        {
           
            driver.Close();
            Console.WriteLine("Closed the browser");
        }
    }
}
