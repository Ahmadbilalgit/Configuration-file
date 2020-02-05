using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Configuration;

namespace ConfigurationApp
{
    public static class Login
    {
     
        public  static  void Loginuser()
        {

            Login_Object abc = new Login_Object();

            abc.Loginlink.Click();
            Thread.Sleep(3000);

            abc.Email.SendKeys(ConfigurationManager.AppSettings.Get("login"));
            abc.Password.SendKeys(ConfigurationManager.AppSettings.Get("password"));

            abc.Button.Click();

            Thread.Sleep(3000);
        }

    }
}
