﻿using System;
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


            string text = "";
            var elem2 = AutomationElement.RootElement.FindAll(TreeScope.Descendants, new PropertyCondition(AutomationElement.LocalizedControlTypeProperty, "edit"));


            int i = 0;
            var elem3 = AutomationElement.RootElement.FindAll(TreeScope.Descendants, new PropertyCondition(AutomationElement.LocalizedControlTypeProperty, "button"));
            foreach (AutomationElement el in elem3)
            {
                ++i;
                var name = el.Current.Name;
                var type = el.Current.LocalizedControlType;
                Console.WriteLine(i);

                Console.WriteLine(type.ToString());
                Console.WriteLine(name.ToString());
                text += " \n name: " + name.ToString() + " type: " + type.ToString();

                //el.SetFocus();

            }
            Console.WriteLine(text);
        }
    }
    
}

