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

        WindowsElement insertWindow => _driver.Current.FindElementByName("Insert Object");
        WindowsElement editingControl => _driver.Current.FindElementByName("Editing control");
        WindowsElement row1Element => _driver.Current.FindElementByName("Name row 1");
        WindowsElement OKButton => _driver.Current.FindElementById("m_btn_ok");
        WindowsElement Node1 => _driver.Current.FindElementByName("Node 1");
        //.item2;
        
        WindowsElement item2 => _driver.Current.FindElementByName("repositoryItemButtonEdit1");
        WindowsElement pencil => _driver.Current.FindElementByName("repositoryItemButtonEdit1.Buttons[0]");
        WindowsElement row2Element => _driver.Current.FindElementByName("Name row 2");
        WindowsElement cancelButton => _driver.Current.FindElementById("m_btn_cancel");


        //


        public void ClickPencil()
        {
            try
            {
                var item1 = _driver.Current.FindElements(By.Name("repositoryItemButtonEdit1"));
                var item2 = _driver.Current.FindElementsByName("repositoryItemButtonEdit1");
                var item3 = _driver.Current.FindElementsByXPath("//button");

                //("//UIAWindow[1]//*"

                /*
                 This will get you every element that is a direct child of the first UIAWindow:

List<MobileElement> elements = driver.findElements(MobileBy.xpath("//UIAWindow[1]/*");
And this will get you every child and sub-child and sub-sub-child etc. of the first UIAWindow:

List<MobileElement> elements = driver.findElements(MobileBy.xpath("//UIAWindow[1]//*");
An extra tip: If you're automating for iOS, I assume that means you have access to OS X, where you can install the Appium dot app and use inspector. The inspector is a great tool to test out xpath queries before putting them into your code.
                
                 */
                item2 = _driver.Current.FindElementsByName("Name row 1");
             //   item2 = _driver.Current.FindElementsByXPath("//Window[@Name=\"Insert Object\"]");
              //  item2 = _driver.Current.FindElementsByXPath("//Window[@Name='Editing control']");

           //     item2 = _driver.Current.FindElementsByXPath("//Window[@Name=\"Insert Object\"]/*");

          //      item2 = _driver.Current.FindElementsByXPath("//Window[@Name=\"Insert Object\"]//*");

                item3 = _driver.Current.FindElementsByXPath("//Edit[@Name='Editing control']");

                item1 = _driver.Current.FindElementsByXPath("//Edit[@Name='Editing control']/*");

                pencil.Click();

                item1 = _driver.Current.FindElementsByXPath("//Edit[@Name='Editing control']//*");

                item1 = _driver.Current.FindElementsByXPath("//Window[@AutomationId='treeList']//*");

                item1 = _driver.Current.FindElementsByXPath("//Window[@Name='Editing control']/*");

            }
            catch { }
        }


        public void ClickOKButton()
        {
            OKButton.Click();
        }

        public void ChangeObjectText(string text)
        {
            editingControl.SendKeys(text);
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


    }


}
