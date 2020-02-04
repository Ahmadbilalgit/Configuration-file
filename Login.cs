using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConfigurationApp
{
    public static class Login
    {
     
        public  static  void Loginuser()
        {

            Login_Object abc = new Login_Object();

            abc.Loginlink.Click();
            Thread.Sleep(3000);

        }

    }
}
