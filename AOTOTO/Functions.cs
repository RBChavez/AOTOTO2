using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace AOTOTO
{
    public class Functions
    {
        Main_Functions Main_Fn = new Main_Functions();

        /// <summary>Function to click element using ID/// </summary>
        public void Click_ID(IWebDriver driver, string ID)
        {
            Thread.Sleep(PageConstants.Delay3);
            Main_Fn.ScrollDownFindId(driver, ID);
            Main_Fn.Highlight_ID(driver, ID);
            Thread.Sleep(PageConstants.Delay3);
            driver.FindElement(By.Id(ID)).Click();
            Console.WriteLine("Click : " + ID);
        }
        /// <summary>Function to click element using Xpath</summary>
        public void Click_Xpath(IWebDriver driver, string Xpath)
        {
            Thread.Sleep(PageConstants.Delay3);
            Main_Fn.ScrollDownFindXpath(driver, Xpath);
            Main_Fn.Highlight_Xpath(driver, Xpath);
            Thread.Sleep(PageConstants.Delay3);
            driver.FindElement(By.XPath(Xpath)).Click();
            Console.WriteLine("Click : " + Xpath);
        }
        /// <summary>Function to click element using Class</summary>
        public void Click_Class(IWebDriver driver, string Class)
        {
            Thread.Sleep(PageConstants.Delay3);
            Main_Fn.ScrollDownFindXpath(driver, Class);
            Main_Fn.Highlight_Class(driver, Class);
            Thread.Sleep(PageConstants.Delay3);
            driver.FindElement(By.ClassName(Class)).Click();
            Console.WriteLine("Click : " + Class);
        }
        /// <summary>Function to enter in text box which has ID</summary>
        public void Enter_ID(IWebDriver driver, string ID, string Value)
        {
            Main_Fn.ScrollDownFindId(driver, ID);
            Thread.Sleep(PageConstants.Delay3);
            //driver.FindElement(By.Id(ID)).Clear();
            driver.FindElement(By.Id(ID)).SendKeys(Value);
            Main_Fn.Highlight_ID(driver, ID);
            Console.WriteLine("Entered : " + Value);
        }
        /// <summary>Function to enter in text box which has Xpath</summary>
        public void Enter_Xpath(IWebDriver driver, string Xpath, string Value)
        {
            Main_Fn.ScrollDownFindXpath(driver, Xpath);
            Thread.Sleep(PageConstants.Delay3);
            driver.FindElement(By.XPath(Xpath)).Clear();
            driver.FindElement(By.XPath(Xpath)).SendKeys(Value);
            Main_Fn.Highlight_ID(driver, Xpath);
            Console.WriteLine("Entered : " + Value);
        }
        /// <summary>Function to Maximize window</summary>
        public void Maximize(IWebDriver driver)
        {
            Thread.Sleep(PageConstants.Delay1);
            driver.Manage().Window.Maximize();
            Console.WriteLine("Maximize window");
        }
        /// <summary>Function to verify page title</summary>
        public void Verify_Title(IWebDriver driver, string Title)
        {
            Thread.Sleep(PageConstants.Delay2);
            if (Title == driver.Title.Trim())
            {
                Console.WriteLine(">>Found page title : " + Title);

            }
            else
            {
                Console.WriteLine("*** NOT Found page title : " + Title);
            }
        }
        /// <summary>Function to verify Xpath is present</summary>
        public void Verify_Xpath(IWebDriver driver, string Xpath)
        {
            Thread.Sleep(PageConstants.Delay1);
            if (Main_Fn.IsElementPresent(driver, By.XPath(Xpath)))
            {
                Main_Fn.Highlight_Xpath(driver, Xpath);
                Console.WriteLine(">> Found : " + Xpath);
            }
            else
            {
                Console.WriteLine("*** NOT Found : " + Xpath);
            }
        }
        /// <summary>Function to verify ID is present</summary>
        public void Verify_ID(IWebDriver driver, string ID)
        {
            Thread.Sleep(PageConstants.Delay1);
            if (Main_Fn.IsElementPresent(driver, By.Id(ID)))
            {
                Main_Fn.Highlight_ID(driver, ID);
                Console.WriteLine(">> Found ID : " + ID);
            }
            else
            {
                Console.WriteLine("*** NOT Found ID : " + ID);
            }
        }
        /// <summary>Function to verify text present</summary>
        public void Verify_Text(IWebDriver driver, string Text)
        {
            Thread.Sleep(PageConstants.Delay5);

            IWebElement Verify = driver.FindElement(By.TagName(PageConstants.BodyTagName));
            if (Verify.Text.Contains(Text))
            {
                Console.WriteLine(">> Text displayed : " + Text);
            }
            else
            {
                Console.WriteLine("*** Text NOT displayed : " + Text);

            }
        }
        /// <summary>Function to verify class present</summary>
        public void Verify_Class(IWebDriver driver, string Class)
        {
            Thread.Sleep(PageConstants.Delay5);
            Main_Fn.Highlight_Class(driver, Class);
            IWebElement Verify = driver.FindElement(By.ClassName(PageConstants.BodyTagName));
            if (Verify.Text.Contains(Class))
            {
                Console.WriteLine(">> Found class : " + Class);
            }
            else
            {
                Console.WriteLine("*** NOT Found class : " + Class);

            }
        }
        /// <summary>Function to swtich to pop-up page</summary>
        public void SwitchToPopup_Xpath(IWebDriver driver, string Xpath)
        {
            Thread.Sleep(PageConstants.Delay3);
            PopupWindowFinder finder = new PopupWindowFinder(driver);
            driver.SwitchTo().Window(finder.Click(driver.FindElement(By.XPath(Xpath))));
        }
        /// <summary>Function to swtich to main page</summary>
        public void SwitchToMain_Window(IWebDriver driver)
        {
            driver.SwitchTo().Window(driver.WindowHandles[0]);
        }
        /// <summary>Function to store data by ID</summary>
        public void Store_ID(IWebDriver driver, string id)
        {
            Thread.Sleep(PageConstants.Delay7);
            By ID = By.Id(id);
            Main_Fn.ScrollDownFindId(driver, id);
            string element = driver.FindElement(ID).Text;
            Console.WriteLine("Selected ---> " + element);
        }
        /// <summary>Function to store data by Xpath</summary>
        //public Test_Data AnnouncementNumber1(IWebDriver driver, string Xpath)
        //{
        //    Thread.Sleep(PageConstants.Delay7);
        //    By XP = By.XPath(Xpath);
        //    Main_Fn.ScrollDownFindXpath(driver, Xpath);
        //    string element = driver.FindElement(XP).Text;
        //    Console.WriteLine("Selected ---> " + element);
        //    return new Test_Data
        //    {
        //        AnnouncementNumber1 = element,
        //    };
        //}
        ///// <summary>Function to store data by Xpath</summary>
        //public Test_Data TrackingNumber1(IWebDriver driver, string Xpath)
        //{
        //    Thread.Sleep(PageConstants.Delay7);
        //    By XP = By.XPath(Xpath);
        //    Main_Fn.ScrollDownFindXpath(driver, Xpath);
        //    string element = driver.FindElement(XP).Text;
        //    Console.WriteLine("Selected ---> " + element);
        //    return new Test_Data
        //    {
        //        TrackingNum = element,
        //    };
        //}
        /// <summary>Function to store data by Xpath</summary>
        public void Enter_Comment(IWebDriver driver, string Frame_ID,string CommentBox_Xpath, string Comment_Text)
        {
            Thread.Sleep(PageConstants.Delay3);
            var ScrollToCommentsTextbox = driver.FindElement(By.Id(Frame_ID));
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", ScrollToCommentsTextbox);
            Console.WriteLine("Scroll down to find 'Comments' text box");

            Thread.Sleep(PageConstants.Delay3);
            driver.SwitchTo().Frame(Frame_ID);
            Console.WriteLine("Switch to frame for enter comment");

            Thread.Sleep(PageConstants.Delay3);
            driver.FindElement(By.XPath(CommentBox_Xpath)).SendKeys(Comment_Text);
            Console.WriteLine("Entered text: " + Comment_Text);

            Thread.Sleep(PageConstants.Delay3);
            driver.SwitchTo().ParentFrame();
            Console.WriteLine("Switch back to pParentFrame");
        }
    }
}
