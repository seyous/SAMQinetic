using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using TechTalk.SpecFlow;

namespace SAM.Steps
{
    [Binding]
    public class XMLParserSteps
    {
        public static Dictionary<string, string> dataDictionary;

        [Given(@"the user uses ""(.*)"" from ""(.*)"" xml")]
        public void GivenTheUserUsesFromXml(string testCase, string file)
        {
            XMLDataParser(testCase, file);
        }

        public void XMLDataParser(string testCase, string file)
        {
            XDocument doc = XDocument.Load(@"C:\SAMAutomation\SAM2\TestData\" + file + ".xml");

            dataDictionary = new Dictionary<string, string>();

            foreach (XElement element in doc.Descendants().Where(p => p.HasElements == false))
            {
                int keyInt = 0;
                string keyName = element.Name.LocalName;

                var parent = element.Parent;
                while (parent != null)
                {
                    keyName = parent.Name.LocalName + "." + keyName;

                    parent = parent.Parent;
                }

                while (dataDictionary.ContainsKey(keyName))
                {
                    keyName = keyName + "_" + keyInt++;
                }

                dataDictionary.Add(keyName, element.Value);
            }

            if (dataDictionary.Count > 0)
            {
                ScenarioContext.Current["UseXML"] = true;
                ScenarioContext.Current["Element"] = dataDictionary["TestCases." + testCase + ".Object"];
                ScenarioContext.Current["Text"] = dataDictionary["TestCases." + testCase + ".Text"];

            }
            else
            {
                ScenarioContext.Current["UseXML"] = false;

            }
        }
    }
}
