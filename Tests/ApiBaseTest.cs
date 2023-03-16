using ApiAutomationSession3.DataModels;
using ApiAutomationSession3.Helpers;
using ApiAutomationSession3.Tests.GenerateTestData;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiAutomationSession3.Tests
{
    
    public class ApiBaseTest
    {
        public RestClient restClient { get; set; }

        public Pet pet { get; set; }

        [TestInitialize]
        public void Initialize() { 
            restClient = new RestClient();
        }

    }
}
