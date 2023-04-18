using MarsQA_1.Helpers;
using MarsQA_1.Pages;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;
using static MarsQA_1.Helpers.ConstantHelpers;
using static MarsQA_1.Helpers.CommonMethods;

namespace MarsQA_1.Utils
{
    [Binding]
    public class Start : Driver
    {

        [BeforeScenario]
        public void Setup()
        {
            //launch the browser
            Initialize();

            //Extract log-in credentials
            ExcelLibHelper.PopulateInCollection(@"C:\Users\Sheila\source\repos\Advanced-Task-Specflow\MarsQA-1\SpecflowTests\Data\Mars.xlsx", "Credentials");

            //call the SignIn class
            SignIn.SigninStep();
        }               

        [AfterScenario]
        public void TearDown()
        {

            // Screenshot
            string img = SaveScreenShotClass.SaveScreenshot(Driver.driver, "Report");

            //Close the browser
            Close();                  
           
        }        
       
    }
}
