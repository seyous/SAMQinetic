using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Windows;
using SAM.Base;
using SAM.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SAM.WinFormObjects
{
    public class InsertFormObject : BasePage
    {
        WindowsElement insertWindow;
        WindowsElement editingControl;
        WindowsElement row1Element => WinDriver.driver.FindElementByName("Name row 1");
        WindowsElement OKButton;
        WindowsElement Node1;

        public InsertFormObject(Driver driver) : base(driver)
        {
            _driver = driver;
            try
            {

                insertWindow = WinDriver.driver.FindElementByName("Insert Object");
                editingControl = WinDriver.driver.FindElementByName("Editing control");
                OKButton = WinDriver.driver.FindElementByAccessibilityId("m_btn_ok");
                Node1 = WinDriver.driver.FindElementByName("Node 1");
            }
            catch (Exception)
            {

            }

        }

        string geomplaceholder => "geom placeholder";
       
		


        public void ClickPencil()
        {
            var formNew = WinDriver.driver.FindElementByAccessibilityId("InsertObjectView");
            var gridNew = formNew.FindElementByAccessibilityId("treeList");
            var group = gridNew.FindElementByName("Data Panel");
            var node = group.FindElementByName("Node1");

            var cell = node.FindElementByName("  row 1");

            WaitForElement.WaitForElementToLoad(cell);
            cell.Click();

            Thread.Sleep(10000);

            var editor = gridNew.FindElementByName("Editing control");

            var buttons = editor.FindElementsByTagName("Button");

            WaitForElement.WaitForElementToLoad(buttons[6]);

            OpenQA.Selenium.Interactions.Actions element = new OpenQA.Selenium.Interactions.Actions(WinDriver.driver);
            element.Click(buttons[6]).Perform();

            Thread.Sleep(10000);

        }

        internal void ClickPlayButton()
        {
            int i= 0;
            bool playbuttonseen = false;
            do
            {
                try
                {
                    OpenQA.Selenium.Interactions.Actions element = new OpenQA.Selenium.Interactions.Actions(WinDriver.driver);


                    WaitForElement.Wait();
                    var formNew = WinDriver.driver.FindElementByAccessibilityId("InsertObjectView");
                    var gridNew = formNew.FindElementByAccessibilityId("treeList");
                    element.MoveToElement(gridNew).Perform();
                    var group = gridNew.FindElementByName("Data Panel");
                    var node = group.FindElementByName("Node1");

                    var cell = node.FindElementByName("  row 1");
                    WaitForElement.Wait();
                    WaitForElement.Wait();

                    WaitForElement.WaitForElementToLoad(cell);
                    cell.Click();

                    Thread.Sleep(10000);

                    var editor = gridNew.FindElementByName("Editing control");

                    var buttons = editor.FindElementsByTagName("Button");


                   // WaitForElement.WaitForElementToLoad(buttons[0]);


                    element.Click(buttons[0]).Perform();

                    playbuttonseen = true;

                    Thread.Sleep(10000);
                }
                catch (Exception)
                {

                }
                ++i;
            } while (i <= 20 & !playbuttonseen);

            
        }

        public void ClickOKButton()
        {
            WinDriver.driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));
            WaitForElement.WaitForElementToLoad(OKButton);
            OKButton.Click();
        }

        public void ChangeObjectText(string text)
        {
            editingControl = WinDriver.driver.FindElementByName("Editing control");

            editingControl.SendKeys(text);
        }

        public void ChangeObjectTextOnKeyPress()
        {
            row1Element.SendKeys(Keys.F2);
        }

        public void PressEscapeKeyOnKeyboard()
        {
            row1Element.SendKeys(Keys.Escape);
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

        public bool IsTextRevertedCorectly(string TextOnInsertObject)
        {
            TextOnInsertObject = GetTextOnInsertObject();

            if(TextOnInsertObject  =="geom placeholder")

            try
            {
                    return true;
            }
            catch (Exception e)
            {

                    return false;
            }
            return false;
        }

        public bool IserrorMessage(string errorMessage)
        {
            WindowsElement errormessageName = WinDriver.driver.FindElementByAccessibilityId("labelControl_nameErrorsFound");

            if (errormessageName.Text == errorMessage)
            {
                return true;
            }
            else
            {
                return false;
            }
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
