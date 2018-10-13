using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using System.Data.OleDb;

public class Aototo
{
    public class TestParameter
    {
        public string testID;
        public string step;
        public string command;
        public string testData;
        public string element;
        public bool status;
        public string comments;
    }
    public void StepCommands(string importFilePath, string reportFilePaths)
    {
        // copy the original test file and parameter from excel file
        // Get paremeter in test parameter
        TestParameter[] myParamList = ReadExcel(importFilePath, reportFilePaths);
        TestParameter returnData = new TestParameter();
        foreach (TestParameter testParamenter in myParamList) // read each rows
        {
            #region Commands

            switch ( testParamenter.command)
            {
                case "Use_Chrome":  driver = new ChromeDriver();
                    returnData = OpenBrowser(testParamenter.testData);
                    break;
                //case "Use_IE": driver = new ChromeDriver(); OpenBrowser(testParamenter.testData); break;
                case "Verify_ID":   returnData = Verify(testParamenter.element,"");
                    break;
                case "Verify_Text": returnData = Verify("",testParamenter.element);
                    break;
                case "Enter": returnData = Enter(testParamenter.testData, testParamenter.element);
                    break;
                case "Click": returnData = Click(testParamenter.element);
                    break;
            }
            testParamenter.status = returnData.status;
            testParamenter.comments = returnData.comments;
            #endregion
            //write status and comments back each row in excel 
        }

    }

    IWebDriver driver;
    private TestParameter OpenBrowser(string url)
    {
        TestParameter results = new TestParameter();
        try
        {
            /// <summary>Call URL</summary>
            driver.Url = url;
            /// <summary>Miximize window</summary>
            Thread.Sleep(500);
            driver.Manage().Window.Maximize();
            results.status = true;
            results.comments = "Pass";
        }
        catch(Exception ex)
        {
            results.status = false;
            results.comments = ex.Message.ToString();
        }
        return results;
    }
    private TestParameter Verify(string element,string text)
    {
        TestParameter results = new TestParameter();
        try
        {
            if (element != "")
            {
                Thread.Sleep(500);
                if (IsElementPresent(By.Id(element)))
                {
                    Highlight_ID(element);
                    results.status = true;
                    results.comments = "";
                }
                else
                {
                    results.status = false;
                    results.comments = "*** NOT Found ID : " + element;
                }
            }
            else
            {
                Thread.Sleep(1000);

                IWebElement Verify = driver.FindElement(By.TagName("body"));
                if (Verify.Text.Contains(text))
                {
                    results.status = true;
                    results.comments = "";
                }
                else
                {
                    results.status = false;
                    results.comments = "*** Text NOT displayed : " + text;

                }
            }

        }
        catch (Exception ex)
        {
            results.status = false;
            results.comments = ex.Message.ToString();
        }
        return results;
    }
    private TestParameter Enter(string testData,string element)
    {
        TestParameter results = new TestParameter();
        try
        {
            ScrollDownFindId(element);
            Thread.Sleep(500);
            driver.FindElement(By.Id(element)).SendKeys(testData);
            Highlight_ID(element);
            results.status = true;
            results.comments = "";
        }
        catch (Exception ex)
        {
            results.status = false;
            results.comments = ex.Message.ToString();
        }
        return results;
    }
    private TestParameter Click(string element)
    {
        TestParameter results = new TestParameter();
        try
        {
            Thread.Sleep(500);
            ScrollDownFindId(element);
            Highlight_ID(element);
            Thread.Sleep(500);
            driver.FindElement(By.Id(element)).Click();
            results.status = true;
            results.comments = "";
        }
        catch (Exception ex)
        {
            results.status = false;
            results.comments = ex.Message.ToString();
        }
        return results;
    }

    private TestParameter[] ReadExcel(string importFilePath, string reportFilePaths)
    {
        TestParameter[] myParamList;
        string ErrorMessage = CopyFile(importFilePath, reportFilePaths);
        if (ErrorMessage != "")
        {
            Console.Write(ErrorMessage);
            Console.Read();
            myParamList = new TestParameter[1];
            myParamList[0] = new TestParameter();
            myParamList[0].status = false;
            myParamList[0].comments = ErrorMessage;
        }
        else
        {
            int i = 0;
            string con =
    @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + importFilePath + ";" +
    @"Extended Properties='Excel 12.0 Macro; HDR = YES'";
            using (OleDbConnection connection = new OleDbConnection(con))
            {
                connection.Open();
                OleDbCommand command_ = new OleDbCommand("select COUNT(*) from [Test_Case$]", connection);
                int rows = (int)command_.ExecuteScalar();
                myParamList = new TestParameter[rows];
                OleDbCommand command = new OleDbCommand("select * from [Test_Case$]", connection);
                using (OleDbDataReader dr = command.ExecuteReader())
                {

                    while (dr.Read())
                    {
                        myParamList[i] = new TestParameter();
                        myParamList[i].testID = dr[0].ToString();
                        myParamList[i].step = dr[5].ToString();
                        myParamList[i].command = dr[6].ToString();
                        myParamList[i].testData = dr[7].ToString();
                        myParamList[i].element = dr[8].ToString();
                        myParamList[i].status = false;
                        i++;
                    }
                }
            }
        }
        return myParamList;
    }
    private string CopyFile(string originalFile, string newLocation)
    {
        string newFile = newLocation + "Report" +
                        System.DateTime.Now.Day.ToString() +
                        System.DateTime.Now.Year.ToString() +
                        System.DateTime.Now.Hour.ToString() +
                        System.DateTime.Now.Minute.ToString() +
                        System.DateTime.Now.Second.ToString() +
                        ".xlsx";
        try
        {
            System.IO.File.Copy(originalFile, newFile, true);
            return "";
        }
        catch (Exception ex)
        {
            return ex.Message.ToString();
        }

    }
    private void Highlight_ID(string Find_element)
    {
        Thread.Sleep(500);
        var jsDriver = (IJavaScriptExecutor)driver;
        var element = driver.FindElement(By.Id(Find_element));
        string highlightJavascript = @"arguments[0].style.cssText = ""border-width: 2px; border-style: solid; border-color: red"";";
        jsDriver.ExecuteScript(highlightJavascript, new object[] { element });
    }
    private bool IsElementPresent(By by)
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
    private void ScrollDownFindId(string Find_Element)
    {
        Thread.Sleep(500);
        var Scrolldown = driver.FindElement(By.Id(Find_Element));
        ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", Scrolldown);
    }
}

