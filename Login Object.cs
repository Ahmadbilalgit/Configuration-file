using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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


        

    }
}

