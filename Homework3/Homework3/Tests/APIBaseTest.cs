using Homework3.DataModels;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestSharp;

namespace Homework3.Tests
{
    public class APIBaseTest
    {
        public RestClient RestClient { get; set; }

        public PetModel PetDetails { get; set; }

        [TestInitialize]
        public void Initilize()
        {
            RestClient = new RestClient();
        }

        [TestCleanup]
        public void CleanUp()
        {

        }

    }
}
