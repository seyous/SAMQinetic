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
    public class InsertFormObject
    {
        WindowsElement insertWindow;
        WindowsElement editingControl;// = WinDriver.driver.FindElementByName("Editing control");
        WindowsElement row1Element => WinDriver.driver.FindElementByName("Name row 1");
        string strOKButtonID = "m_btn_ok";

        WindowsElement OKButton;

        WindowsElement cancelButton;
        WindowsElement Node1;
        string geomplaceholder => "geom placeholder";


        public InsertFormObject()
        {
            try
            {

                insertWindow = WinDriver.driver.FindElementByName("Insert Object");
                editingControl = WinDriver.driver.FindElementByName("Editing control");
                OKButton = WinDriver.driver.FindElementByAccessibilityId(strOKButtonID);
                Node1 = WinDriver.driver.FindElementByName("Node 1");
                cancelButton = WinDriver.driver.FindElementByAccessibilityId("m_btn_cancel");
            }
            catch (Exception)
            {

            }

        }

       
		


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

        internal void CloseInsertWindow()
        {
            WaitForElement.WaitForElementToLoad(insertWindow);
            insertWindow.SendKeys(Keys.Escape);
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
            OKButton = WinDriver.driver.FindElementByAccessibilityId(strOKButtonID);

            WaitForElement.WaitForElementToLoad(OKButton);
            OKButton.Click();
        }

        public void ChangeObjectText(string text)
        {
            editingControl = WinDriver.driver.FindElementByName("Editing control");

            editingControl.SendKeys(text);
        }

        public void MakeInsertObjectEditableByPressingF2()
        {
            row1Element.SendKeys(Keys.F2);
        }

        public void PressEscapeKeyOnKeyboard()
        {
            row1Element.SendKeys(Keys.Escape);
        }
        public void ClearText()
        {
            WaitForElement.WaitForElementToLoad(editingControl);

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
            //row1Element.Click();
            if (objectText == "Object")
            {
                objectText = "";
            }

            for (int i = 1; i <=19; i++)
            {
                WindowsElement element = WinDriver.driver.FindElementByName("Name row " + i);
                if (element.Text == objectText)
                {
                    element.Click();
                    break;
                }

            }
        }

        public bool DesignObjectIsDisplayed(string objectText)
        {
            for (int i = 0; i < 50; i++)
            {
                string RenamedObjectText = "treeListColumn1 row " + i.ToString();
                try
                {
                    WindowsElement element = WinDriver.driver.FindElementByName(RenamedObjectText);
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
