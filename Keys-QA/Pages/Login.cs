using Keys_QA.Global;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keys_QA.Pages
{
    internal class Login
    {
        public Login()
        {
            PageFactory.InitElements(Driver.driver, this);

        }
        #region  Initialize Web Elements 
        // Finding the Email Field
        [FindsBy(How = How.XPath, Using = "//*[@id='UserName']")]
        private IWebElement Email { get; set; }

        // Finding the Password Field
        [FindsBy(How = How.XPath, Using = "//*[@id='Password']")]
        private IWebElement PassWord { get; set; }

        // Finding the Login Button
        [FindsBy(How = How.XPath, Using = "//*[@id='sign_in']/div[3]/button[1]")]
        private IWebElement loginButton { get; set; }

        #endregion

        internal void Successfull()
        {
            // Populating the data from Excel

            // Navigating to Login page using value from Excel

            // Sending the username 

            // Sending the password

            // Clicking on the login button
        }
    }

}
