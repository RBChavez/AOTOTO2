using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
namespace AOTOTO
{
    class Test
    {
        private string user = "Pepita.Spadlin.14027172@test.com";

        public void Summary()
        {
            IWebDriver driver = new ChromeDriver(); //use Chrome
            
            Page(driver);
        }
        public void Page(IWebDriver driver)
        {

            Main_Functions Functions = new Main_Functions();
            Functions REI_Fn = new Functions();

            /// <summary>Call URL</summary>
            Functions.Web_URL(driver, Test_Parameters.Environment);

            /// <summary>Miximize window</summary>
            REI_Fn.Maximize(driver);

            //Verify page Title
            REI_Fn.Verify_Title(driver, PageConstants.LoginPageTitle);

            //Enter user name and password
            Thread.Sleep(PageConstants.Delay3);
            if (Functions.IsElementPresent(driver, By.Id(PageConstants.OverlayOKButton)))
            {
                Console.WriteLine("Page has overlay");

                //Click 'OK' button at overlay
                REI_Fn.Click_ID(driver, PageConstants.OverlayOKButton);

                //Enter username
                REI_Fn.Enter_ID(driver, PageConstants.UserNameTextBox, user);

                //Enter password
                REI_Fn.Enter_ID(driver, PageConstants.PasswordTextBox, Test_Parameters.Password);

                //Click login
                REI_Fn.Click_ID(driver, PageConstants.LoginButton);

            }
            else
            {
                Console.WriteLine("Page does not have overlay");

                //Find and Enter Username
                REI_Fn.Enter_ID(driver, PageConstants.UserNameTextBox, user);

                //Find and Enter Password
                REI_Fn.Enter_ID(driver, PageConstants.PasswordTextBox, Test_Parameters.Password);

                //Click on 'Login' button
                REI_Fn.Click_ID(driver, PageConstants.Login_ID);

            }
        

        }

    }
}
