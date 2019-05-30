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
        
        //WindowsElement item2 => _driver.Current.FindElementByName("repositoryItemButtonEdit1");
        //WindowsElement pencil => _driver.Current.FindElementByName("repositoryItemButtonEdit1.Buttons[0]");
        //WindowsElement row2Element => _driver.Current.FindElementByName("Name row 2");
        //WindowsElement cancelButton => _driver.Current.FindElementById("m_btn_cancel");



        //


        public void ClickPencil()
        {
            try
            {




                try
                {

                    var form8 = _driver.Current.FindElementByXPath("//Window[@AutomationId=\"MainWindow\"]");

                    var form9 = form8.FindElementByXPath("//Window[@AutomationId=\"InsertObjectView\"]");

                    var grid1 = form9.FindElementByAccessibilityId("treeList");

                    var editor = grid1.FindElementByName("Editing control");
                    var buttons = editor.FindElementsByTagName("Button");

                }
                catch (Exception)
                {



                }

                try
                {

                    var form8 = _driver.Current.FindElementByXPath("//Window[@AutomationId=\"MainWindow\"]");

                    var form9 = form8.FindElementByXPath("//Window[@AutomationId=\"InsertObjectView\"]");

                    var grid1 = form9.FindElementByAccessibilityId("treeList");

                    var editor = grid1.FindElementByName("Editing control");
                    //var buttons = editor.FindElementsByTagName("Button");
                    var buttons2 = editor.FindElementByXPath("//Button");

                }
                catch (Exception)
                {



                }


                try
                {

                    var form8 = _driver.Current.FindElementByXPath("//Window[@AutomationId=\"MainWindow\"]");

                    var form9 = form8.FindElementByXPath("//Window[@AutomationId=\"InsertObjectView\"]");

                    var grid1 = form9.FindElementByAccessibilityId("treeList");

                    var editor = grid1.FindElementByName("Editing control");
                    var buttons = editor.FindElementsByTagName("Button");
                    var buttons2 = editor.FindElementByXPath("//Button");

                }
                catch (Exception)
                {



                }

                UIGridPattern.FindRows();


                // var item1 = _driver.Current.FindElements(By.Name("repositoryItemButtonEdit1"));
                // var item2 = _driver.Current.FindElementsByName("repositoryItemButtonEdit1");
                //var item3 = _driver.Current.FindElementsByXPath("//button");

                //("//UIAWindow[1]//*"

                /*
                 This will get you every element that is a direct child of the first UIAWindow:

List<MobileElement> elements = driver.findElements(MobileBy.xpath("//UIAWindow[1]/*");
And this will get you every child and sub-child and sub-sub-child etc. of the first UIAWindow:

List<MobileElement> elements = driver.findElements(MobileBy.xpath("//UIAWindow[1]//*");
An extra tip: If you're automating for iOS, I assume that means you have access to OS X, where you can install the Appium dot app and use inspector. The inspector is a great tool to test out xpath queries before putting them into your code.
                
                 */



                //var edititem1 = _driver.Current.FindElementByXPath("//Edit[@Name='Editing control']//*");


                /*
                var item14 = _driver.Current.FindElementsByName("Name row 1");
               var    itemn2 = _driver.Current.FindElementsByXPath("//Window[@Name=\"Insert Object\"]");

                var edititem2 = _driver.Current.FindElementsByXPath("//Edit[@Name='Editing control']//*");

                var edititem3 = _driver.Current.FindElementsByXPath("//Edit[@Name='Editing control']/*");

                var edititem4 = _driver.Current.FindElementsByXPath("//Button[@Name='']/*");

                var edititem5 = _driver.Current.FindElementsByXPath("//Button[@Name='']//*");

                //var edititem6 = _driver.Current.FindElementByXPath("//Button[@Name='']/*");

                var edititem7 = _driver.Current.FindElementsByXPath("//Button[@Name=''][0]/*");
                var  item12 = _driver.Current.FindElementsByXPath("//Window[@Name='Editing control']");

                var     nitem2 = _driver.Current.FindElementsByXPath("//Window[@Name=\"Insert Object\"]/*");

              //      var  titem2 = _driver.Current.FindElementsByXPath("//Window[@Name=\"Insert Object\"]//*");
                var edititem8 = _driver.Current.FindElementsByXPath("//Button[@Name='']");
                */
                var edititem9 = _driver.Current.FindElementsByXPath("//Button");


                //var node1 = _driver.Current.FindElementsByXPath("//TreeItem[@Name='Node1']/*");

                //var node1a = _driver.Current.FindElementsByXPath("//TreeItem[@Name='Node1']//*");

                //var node1b = _driver.Current.FindElementsByXPath("//TreeItem[@Name='Node1']//*");
                /*

                var treeList1 = _driver.Current.FindElementsByXPath("//Tree[@AutomationId='treeList']//*");
                var treeList2 = _driver.Current.FindElementsByXPath("//Tree[@AutomationId='treeList']/*");
                var treeList3 = _driver.Current.FindElementsByXPath("//Tree[@AutomationId='treeList']");
                */
                int i = 0;
                
                
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

                /*
                    var item5 = _driver.Current.FindElementsByXPath("//Edit[@Name='Editing control']");

                //This

                var node1 = _driver.Current.FindElementsByXPath("//TreeItem[@Name='Node1']/*"); //4 items OK

                var node1a = _driver.Current.FindElementsByXPath("//TreeItem[@Name='Node1']//*"); //4 items OK

                var node1b = _driver.Current.FindElementsByXPath("//TreeItem[@Name='Node1']//*"); //4 items OK

                var data = _driver.Current.FindElementsByXPath("//DataItem[@Name='row 1']/*"); //0 items

                var node2 = _driver.Current.FindElementsByXPath("//Group[@Name='Data Panel']/*"); //21 items

                var data2 = _driver.Current.FindElementsByXPath("//DataItem[@Name='row 1']//*"); //0

                var node2a = _driver.Current.FindElementsByXPath("//Group[@Name='Node1']//*");

                var data3 = _driver.Current.FindElementsByXPath("//DataItem[@Name='row 1']//*");


                var node2b = _driver.Current.FindElementsByXPath("//Group[@Name='Node1']//*");

                 treeList1 = _driver.Current.FindElementsByXPath("//Tree[@AutomationId='treeList']//*"); //112 items
                 treeList2 = _driver.Current.FindElementsByXPath("//Tree[@AutomationId='treeList']/*"); //3 item
                 treeList3 = _driver.Current.FindElementsByXPath("//Tree[@AutomationId='treeList']");


                var item6 = _driver.Current.FindElementsByXPath("//Edit[@Name='Editing control']/*");

               // pencil.Click();

                var item7 = _driver.Current.FindElementsByXPath("//Edit[@Name='Editing control']//*");
                item6 = _driver.Current.FindElementsByXPath("//Edit[@Name='Editing control']/*");

                var data4 = _driver.Current.FindElementsByXPath("//DataItem[@Name='  row 1'][0]//*"); //0

                var data5 = _driver.Current.FindElementsByXPath("//DataItem[@Name='  row 1'][1]//*"); //0

                var data6 = _driver.Current.FindElementsByXPath("//DataItem[@Name='  row 1'][0]//*"); 

                var treeList = _driver.Current.FindElementsByXPath("//Window[@AutomationId='treeList']//*");

                data4 = _driver.Current.FindElementsByXPath("//DataItem[@Name='  row 1']//*"); //0

                data5 = _driver.Current.FindElementsByXPath("//DataItem[@Name='  row 1']/*"); //0


                data4 = _driver.Current.FindElementsByXPath("//DataItem[@Name='  row 1'][0]//*"); //0

                data5 = _driver.Current.FindElementsByXPath("//DataItem[@Name='  row 1'][1]//*"); //0

                data6 = _driver.Current.FindElementsByXPath("//DataItem[@Name='  row 1'][0]//*");


                var item9 = _driver.Current.FindElementsByXPath("//Window[@Name='Editing control']/*");
                //Node1

                var treeList4 = _driver.Current.FindElementByXPath("//tree[@AutomationId='treeList']");
                var treeList5 = _driver.Current.FindElementsByXPath("//tree[@AutomationId='treeList']");
                var treeList6 = _driver.Current.FindElementByXPath("//tree[@AutomationId='treeList']/*");
                var treeList7 = _driver.Current.FindElementByXPath("//tree[@AutomationId='treeList']/*");
                */



            }
            catch (Exception ex) {


            }
            try
            {
                var form1 = _driver.Current.FindElementByXPath("/Pane[@Name=\"Desktop 1\"]/Window[@AutomationId=\"MainWindow\"]");
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

                    element = _driver.Current.FindElementByName(nameOfObject);
                    if (element.Text == objectText)
                    {
                        bool test = _driver.Current.SessionId != null;

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
