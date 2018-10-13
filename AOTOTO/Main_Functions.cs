using System;
using OpenQA.Selenium;
using System.Threading;

namespace AOTOTO
{
    public class Main_Functions
    {
        /// <summary>Function to open web browser</summary>
        public void Web_URL(IWebDriver driver, string data)
        {
            if (Test_Parameters.Environment == "QA")
            {
                driver.Url = PageConstants.QA_URL;
                Console.WriteLine("This test perform using " + Test_Parameters.Environment);
            }
            else if (Test_Parameters.Environment == "REI-INT")
            {
                driver.Url = PageConstants.REI_INT_URL;
                Console.WriteLine("This test perform using " + Test_Parameters.Environment);
            }
            else if (Test_Parameters.Environment == "HRSA-INT")
            {
                driver.Url = PageConstants.HRSA_INT_URL;
                Console.WriteLine("This test perform using " + Test_Parameters.Environment);
            }
            else if (Test_Parameters.Environment == "perf")
            {
                driver.Url = PageConstants.Perf_URL;
                Console.WriteLine("This test perform using " + Test_Parameters.Environment + Test_Parameters.Environment_Number);
            }
            else if (Test_Parameters.Environment == "UAT")
            {
                driver.Url = PageConstants.UAT_URL;
                Console.WriteLine("This test perform using " + Test_Parameters.Environment + Test_Parameters.Environment_Number);
            }
            else if (Test_Parameters.Environment == "UTL")
            {
                driver.Url = PageConstants.UTL_URL;
                Console.WriteLine("This test perform using " + Test_Parameters.Environment + Test_Parameters.Environment_Number);
            }
            else
                Console.WriteLine("Please provide correct URL");
        }

        /// <summary>Function to highlight element which has ID</summary>
        public void Highlight_ID(IWebDriver driver, string Find_element)
        {
            Thread.Sleep(PageConstants.Delay1);
            var jsDriver = (IJavaScriptExecutor)driver;
            var element = driver.FindElement(By.Id(Find_element));
            string highlightJavascript = @"arguments[0].style.cssText = ""border-width: 2px; border-style: solid; border-color: red"";";
            jsDriver.ExecuteScript(highlightJavascript, new object[] { element });
        }
        /// <summary>Function to highlight element which has Xpath</summary>
        public void Highlight_Xpath(IWebDriver driver, string Find_element)
        {
            var jsDriver = (IJavaScriptExecutor)driver;
            var element = driver.FindElement(By.XPath(Find_element));
            string highlightJavascript = @"arguments[0].style.cssText = ""border-width: 2px; border-style: solid; border-color: red"";";
            jsDriver.ExecuteScript(highlightJavascript, new object[] { element });
        }
        /// <summary>Function to highlight element which has class</summary>
        public void Highlight_Class(IWebDriver driver, string Find_element)
        {
            Thread.Sleep(PageConstants.Delay2);
            var jsDriver = (IJavaScriptExecutor)driver;
            var element = driver.FindElement(By.ClassName(Find_element));
            string highlightJavascript = @"arguments[0].style.cssText = ""border-width: 2px; border-style: solid; border-color: red"";";
            jsDriver.ExecuteScript(highlightJavascript, new object[] { element });
        }

        /// <summary>Function to scroll to find Xpath</summary>
        public void ScrollDownFindXpath(IWebDriver driver, string Find_Element)
        {
            Thread.Sleep(PageConstants.Delay2);
            var Scrolldown = driver.FindElement(By.XPath(Find_Element));
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", Scrolldown);
        }
        /// <summary>Function to scroll to find ID</summary>
        public void ScrollDownFindId(IWebDriver driver, string Find_Element)
        {
            Thread.Sleep(PageConstants.Delay1);
            var Scrolldown = driver.FindElement(By.Id(Find_Element));
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", Scrolldown);
        }

        /// <summary>Function to check if an element is present or not</summary>
        public bool IsElementPresent(IWebDriver driver, By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
    }
}
