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

        [Given(@"the user uses ""(.*)"" from ""(.*)"" xml")]
        public void GivenTheUserUsesFromXml(string testCase, string file)
        {
            XDocument doc = XDocument.Load(@"C:\SAMAutomation\TestData\" + file + ".xml");
            Dictionary<string, string> dataDictionary = new Dictionary<string, string>();
            foreach (XElement element in doc.Descendants().Where(p => p.HasElements == false))
            {
                string keyName = element.Name.LocalName;
                dataDictionary.Add(keyName, element.Value);
            }

            string data1 = dataDictionary["ObjectData1"];
            string testNo = testCase.Substring(testCase.Length - 1);

            if (dataDictionary.Count > 0)
            {
                ScenarioContext.Current["UseXML"] = true;
                ScenarioContext.Current["ObjectData"] = dataDictionary["ObjectData" + testNo];
            }
            else
            {
                ScenarioContext.Current["UseXML"] = true;

            }
        }
        
    }
}
