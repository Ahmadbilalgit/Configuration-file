using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Configuration;
using System.Threading;
using System.Threading.Tasks;

namespace ConfigurationApp
{
    public  class Nunit
    {
   

        [SetUp]
        public  void Initialize()
        {

            //String Saf = System.Configuration.ConfigurationManager.AppSettings["U1"];
            Driver.driver.Manage().Window.Maximize();
            // Driver.driver.Navigate().GoToUrl(System.Configuration.ConfigurationManager.AppSettings["U1"]);

            
            Driver.driver.Navigate().GoToUrl(ConfigurationManager.AppSettings.Get("URL"));
            //System.Console.WriteLine(ConfigurationManager.AppSettings.Get("U1"));
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