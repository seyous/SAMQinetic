using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Windows;
using SAM.Base;
using SAM.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAM.WinFormObjects
{
    public class InsertFormObject : BasePage
    {
        public InsertFormObject(Driver driver) : base(driver)
        {
            _driver = driver;

        }

        string geomplaceholder => "geom placeholder";

        WindowsElement insertWindow => WinDriver.driver.FindElementByName("Insert Object");
        WindowsElement editingControl => WinDriver.driver.FindElementByName("Editing control");
        WindowsElement row1Element => WinDriver.driver.FindElementByName("Name row 1");
        WindowsElement OKButton => WinDriver.driver.FindElementByAccessibilityId("m_btn_ok");
        WindowsElement Node1 => WinDriver.driver.FindElementByName("Node 1");

        public void ClickPencil()
        {
            try
            {

                var window = WinDriver.driver.FindElementsByXPath("//Window[@AutomationId=\"MainWindow\"]");
                var insertWindow = window[0].FindElementsByXPath("//Window[@AutomationId=\"InsertObjectView\"]");

                var grid = insertWindow[0].FindElementsByAccessibilityId("treeList");
                var columnCaption = "Value";
                var rowIndex = 1;
                var cell = grid[0].FindElementByName(String.Format("{0} row{1}", columnCaption, rowIndex));
                cell.Click();

                var editor = grid[0].FindElementsByName("Editing control");

                WaitForElement.Wait();
                //editor[0].Click();
                WaitForElement.Wait();

                var buttons = editor[0].FindElementsByTagName("Button");
                //var buttons2 = editor.FindElementByXPath("//Button");

                buttons[0].Click();
                buttons[1].Click();
                buttons[2].Click();


            }
            catch (Exception)
            {



            }

        }


        public void ClickOKButton()
        {
            WinDriver.driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));
            OKButton.Click();
        }

        public void ChangeObjectText(string text)
        {
            WinDriver.driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));
            editingControl.SendKeys(text);
        }

        public void ChangeObjectTextOnKeyPress()
        {
            row1Element.SendKeys(Keys.F2);
        }

        public void ClearText()
        {
            editingControl.Clear();
        }

        public bool IsInsertWindows()
        {
            return insertWindow.Displayed;
        }


        public string GetTextOnInsertObject()
        {
            return row1Element.Text;
        }

        public bool IsTextDisplayedForGeomCorrect()
        {
            return GetTextOnInsertObject() == geomplaceholder;
        }

        public void ClickOnObject(string objectText)
        {
            row1Element.Click();
        }

        public bool DesignObjectIsDisplayed(string objectText)
        {
            for (int i = 0; i < 50; i++)
            {
                string objectTextRenamed = "treeListColumn1 row " + i.ToString();
                try
                {
                    WindowsElement element = WinDriver.driver.FindElementByName(objectTextRenamed);
                    if (element.Text == objectText)
                    {
                        bool displayedObject = element.Displayed;
                        return true;
                    }

                }
                catch (Exception e)
                {

                    return false;
                }
            }
            return false;
        }

        public bool InsertObjectIsDisplayed(string objectText)
        {
            bool objectIsDisplayed = false;
            WindowsElement element;
            string nameOfObject = ""; 
            for (int i=0; i<10; i++)
            {
                
                nameOfObject = "Name row " + i.ToString();
                try
                {

                    element = WinDriver.driver.FindElementByName(nameOfObject);
                    if (element.Text == objectText)
                    {
                        bool test = WinDriver.driver.SessionId != null;

                        return true;
                    }
                }
                catch
                {
                    
                }

            }
            return false;

        }
    }


}
