using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using System.Threading.Tasks;

namespace ConfigurationApp
{
    public  class Nunit
    {
   

        [SetUp]
        public  void Initialize()
        {
          

            Driver.driver.Manage().Window.Maximize();
            Driver.driver.Navigate().GoToUrl("https://demo.nopcommerce.com");           
           
        }

        [Test]
        public  void OpenWebsite()
        {    
                     
                     
            Thread.Sleep(3000);
            Login.Loginuser();
        }

        [TearDown]
        public void EndTest()
        {
            Driver.driver.Close();
        }

    }
}