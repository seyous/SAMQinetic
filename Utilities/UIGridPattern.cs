using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Automation;

namespace SAM.Utilities
{
    public static class UIGridPattern
    {
        public static void FindRows()
        {
            AutomationElement gridElem = AutomationElement.RootElement.FindFirst(TreeScope.Descendants, new PropertyCondition(AutomationElement.LocalizedControlTypeProperty, "edit"));
            var elem = AutomationElement.RootElement.FindAll(TreeScope.Descendants, new PropertyCondition(AutomationElement.LocalizedControlTypeProperty, "edit"));


            //GridPattern gridPattern = (GridPattern)gridElem.GetCurrentPattern(GridPattern.Pattern);
            //for (int i = 0; i < gridPattern.Current.RowCount; i++)
            //{
            //    var item = gridPattern.GetItem(i, 0);
            //    var a = item.GetSupportedPatterns();

            //}
            string text = "";
            int i = 0;
            foreach (AutomationElement el in elem)
            {
                ++i;
                var name = el.Current.Name;
                var type = el.Current.LocalizedControlType;
                Console.WriteLine(i);

                Console.WriteLine(type.ToString());
                Console.WriteLine(name.ToString());
                text += " \n name: " + name.ToString() + " type: " + type.ToString();

                //el.SetFocus();
             //   System.Threading.Thread.Sleep(10000);

            }
            Console.WriteLine(text);
        }
    }
    
}

