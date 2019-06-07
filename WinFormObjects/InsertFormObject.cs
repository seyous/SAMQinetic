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
        WindowsElement OKButton => WinDriver.driver.FindElementById("m_btn_ok");
        WindowsElement Node1 => WinDriver.driver.FindElementByName("Node 1");
        //.item2;
        
        //WindowsElement item2 => WinDriver.driver.FindElementByName("repositoryItemButtonEdit1");
        //WindowsElement pencil => WinDriver.driver.FindElementByName("repositoryItemButtonEdit1.Buttons[0]");
        //WindowsElement row2Element => WinDriver.driver.FindElementByName("Name row 2");
        //WindowsElement cancelButton => WinDriver.driver.FindElementById("m_btn_cancel");



        //


        public void ClickPencil()
        {


                try
                {

                    var window = WinDriver.driver.FindElementsByXPath("//Window[@AutomationId=\"MainWindow\"]");

                    var insertWindow = window[0].FindElementsByXPath("//Window[@AutomationId=\"InsertObjectView\"]");

                    var grid = insertWindow[0].FindElementsByAccessibilityId("treeList");

                    //WaitForElement.Wait();

                    //grid1[0].Click();
                    //grid1[0].Click();


                    var columnCaption = "Value";
                    var rowIndex = 1;
                    var cell = grid[0].FindElementByName(String.Format("{0} row{1}", columnCaption, rowIndex));
                    cell.Click();

                    grid1[0].Click();
                    grid1[0].Click();

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

                //UIGridPattern.FindRows();

                try
                {

                    var form8 = WinDriver.driver.FindElementByXPath("//Window[@AutomationId=\"MainWindow\"]");

                    var form9 = form8.FindElementByXPath("//Window[@AutomationId=\"InsertObjectView\"]");

                    var grid1 = form9.FindElementByAccessibilityId("treeList");

                    var editor = grid1.FindElementByName("Editing control");

                    WaitForElement.Wait();
                    editor.Click();
                    WaitForElement.Wait();

                    var buttons = editor.FindElementsByTagName("Button");
                    //var buttons2 = editor.FindElementByXPath("//Button");

                }
                catch (Exception)
                {



                }
                // var item1 = WinDriver.driver.FindElements(By.Name("repositoryItemButtonEdit1"));
                // var item2 = WinDriver.driver.FindElementsByName("repositoryItemButtonEdit1");
                //var item3 = WinDriver.driver.FindElementsByXPath("//button");

                //("//UIAWindow[1]//*"

                /*
                 This will get you every element that is a direct child of the first UIAWindow:

List<MobileElement> elements = driver.findElements(MobileBy.xpath("//UIAWindow[1]/*");
And this will get you every child and sub-child and sub-sub-child etc. of the first UIAWindow:

List<MobileElement> elements = driver.findElements(MobileBy.xpath("//UIAWindow[1]//*");
An extra tip: If you're automating for iOS, I assume that means you have access to OS X, where you can install the Appium dot app and use inspector. The inspector is a great tool to test out xpath queries before putting them into your code.
                
                 */



                //var edititem1 = WinDriver.driver.FindElementByXPath("//Edit[@Name='Editing control']//*");


                /*
                var item14 = WinDriver.driver.FindElementsByName("Name row 1");
               var    itemn2 = WinDriver.driver.FindElementsByXPath("//Window[@Name=\"Insert Object\"]");

                var edititem2 = WinDriver.driver.FindElementsByXPath("//Edit[@Name='Editing control']//*");

                var edititem3 = WinDriver.driver.FindElementsByXPath("//Edit[@Name='Editing control']/*");

                var edititem4 = WinDriver.driver.FindElementsByXPath("//Button[@Name='']/*");

                var edititem5 = WinDriver.driver.FindElementsByXPath("//Button[@Name='']//*");

                //var edititem6 = WinDriver.driver.FindElementByXPath("//Button[@Name='']/*");

                var edititem7 = WinDriver.driver.FindElementsByXPath("//Button[@Name=''][0]/*");
                var  item12 = WinDriver.driver.FindElementsByXPath("//Window[@Name='Editing control']");

                var     nitem2 = WinDriver.driver.FindElementsByXPath("//Window[@Name=\"Insert Object\"]/*");

              //      var  titem2 = WinDriver.driver.FindElementsByXPath("//Window[@Name=\"Insert Object\"]//*");
                var edititem8 = WinDriver.driver.FindElementsByXPath("//Button[@Name='']");
                */
                //var edititem9 = WinDriver.driver.FindElementsByXPath("//Button");


                //var node1 = WinDriver.driver.FindElementsByXPath("//TreeItem[@Name='Node1']/*");

                //var node1a = WinDriver.driver.FindElementsByXPath("//TreeItem[@Name='Node1']//*");

                //var node1b = WinDriver.driver.FindElementsByXPath("//TreeItem[@Name='Node1']//*");
                /*

                var treeList1 = WinDriver.driver.FindElementsByXPath("//Tree[@AutomationId='treeList']//*");
                var treeList2 = WinDriver.driver.FindElementsByXPath("//Tree[@AutomationId='treeList']/*");
                var treeList3 = WinDriver.driver.FindElementsByXPath("//Tree[@AutomationId='treeList']");
                */
                int i = 0;
                /*
                
                foreach (WindowsElement element in edititem9)
                {
                    if (element.Text == "")
                    {
                        ++i;
                        try
                        {
                            element.Click();
                            WaitForElement.Wait();

                        }
                        catch { }

                    }
                }
                */
                /*
                    var item5 = WinDriver.driver.FindElementsByXPath("//Edit[@Name='Editing control']");

                //This

                var node1 = WinDriver.driver.FindElementsByXPath("//TreeItem[@Name='Node1']/*"); //4 items OK

                var node1a = WinDriver.driver.FindElementsByXPath("//TreeItem[@Name='Node1']//*"); //4 items OK

                var node1b = WinDriver.driver.FindElementsByXPath("//TreeItem[@Name='Node1']//*"); //4 items OK

                var data = WinDriver.driver.FindElementsByXPath("//DataItem[@Name='row 1']/*"); //0 items

                var node2 = WinDriver.driver.FindElementsByXPath("//Group[@Name='Data Panel']/*"); //21 items

                var data2 = WinDriver.driver.FindElementsByXPath("//DataItem[@Name='row 1']//*"); //0

                var node2a = WinDriver.driver.FindElementsByXPath("//Group[@Name='Node1']//*");

                var data3 = WinDriver.driver.FindElementsByXPath("//DataItem[@Name='row 1']//*");


                var node2b = WinDriver.driver.FindElementsByXPath("//Group[@Name='Node1']//*");

                 treeList1 = WinDriver.driver.FindElementsByXPath("//Tree[@AutomationId='treeList']//*"); //112 items
                 treeList2 = WinDriver.driver.FindElementsByXPath("//Tree[@AutomationId='treeList']/*"); //3 item
                 treeList3 = WinDriver.driver.FindElementsByXPath("//Tree[@AutomationId='treeList']");


                var item6 = WinDriver.driver.FindElementsByXPath("//Edit[@Name='Editing control']/*");

               // pencil.Click();

                var item7 = WinDriver.driver.FindElementsByXPath("//Edit[@Name='Editing control']//*");
                item6 = WinDriver.driver.FindElementsByXPath("//Edit[@Name='Editing control']/*");

                var data4 = WinDriver.driver.FindElementsByXPath("//DataItem[@Name='  row 1'][0]//*"); //0

                var data5 = WinDriver.driver.FindElementsByXPath("//DataItem[@Name='  row 1'][1]//*"); //0

                var data6 = WinDriver.driver.FindElementsByXPath("//DataItem[@Name='  row 1'][0]//*"); 

                var treeList = WinDriver.driver.FindElementsByXPath("//Window[@AutomationId='treeList']//*");

                data4 = WinDriver.driver.FindElementsByXPath("//DataItem[@Name='  row 1']//*"); //0



                }


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
