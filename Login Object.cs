using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace ConfigurationApp
{
    public class Login_Object
    {

        public Login_Object()

        {

            PageFactory.InitElements(Driver.driver, this);

        }


        [FindsBy(How = How.ClassName, Using = "ico-login")]
        public IWebElement Loginlink { get; set; }


        [FindsBy(How = How.Id, Using = "Email")]
        public IWebElement Email { get; set; }

        [FindsBy(How = How.Id, Using = "Password")]
        public IWebElement Password { get; set; }

        [FindsBy(How = How.XPath, Using = "/ html / body / div[6] / div[3] / div / div / div / div[2] / div[1] / div[2] / form / div[3] / input")]
        public IWebElement Button { get; set; }

        
    }
}

