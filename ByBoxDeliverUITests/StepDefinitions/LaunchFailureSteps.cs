using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace ByBoxDeliverUITests.StepDefinitions
{
    [Binding]
    public class LaunchFailureSteps
    {
        [Given(@"As a user launch the bybox deliver")]
        public void GivenAsAUserLaunchTheByboxDeliver()
        {
            
        }

        
        [Then(@"Error message page is diaplayed with ""(.*)""")]
        public void ThenErrorMessagePageIsDiaplayedWith(string p0)
        {
            
        }



    }
}
