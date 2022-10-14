using Homework3.DataModels;
using Homework3.Helpers;
using Homework3.Resources;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestSharp;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace Homework3.Tests
{
    [TestClass]
    public class Homework3 : APIBaseTest
    {
        private static List<PetModel> petCleanUpList = new List<PetModel>();

        [TestInitialize]
        public async Task TestInitialize()
        {
            PetDetails = await PetHelper.AddNewPet(RestClient);
        }

        [TestMethod]
        public async Task DemoGetUser()
        {
            //Arrange
            var demoGetRequest = new RestRequest(Endpoints.GetByPetID(PetDetails.Id));
            petCleanUpList.Add(PetDetails);

            //Act
            var demoResponse = await RestClient.ExecuteGetAsync<PetModel>(demoGetRequest);

            //Assert
            Assert.AreEqual(HttpStatusCode.OK, demoResponse.StatusCode, "Failed due to wrong status code.");
            Assert.AreEqual(PetDetails.Name, demoResponse.Data.Name, "Name did not match.");
            Assert.AreEqual(PetDetails.Status, demoResponse.Data.Status, "Status did not match.");
            Assert.AreEqual(PetDetails.PhotoUrls[0], demoResponse.Data.PhotoUrls[0], "PhotoUrls did not match.");
            Assert.AreEqual(PetDetails.Category.Id, demoResponse.Data.Category.Id, "Category ID did not match.");
            Assert.AreEqual(PetDetails.Category.Name, demoResponse.Data.Category.Name, "Category Name did not match.");
            Assert.AreEqual(PetDetails.Tags[0].Id, demoResponse.Data.Tags[0].Id, "Tags ID did not match.");
            Assert.AreEqual(PetDetails.Tags[0].Name, demoResponse.Data.Tags[0].Name, "Tags Name did not match.");
        }

        [TestCleanup]
        public async Task TestCleanUp()
        {
            foreach (var data in petCleanUpList)
            {
                var deletePetRequest = new RestRequest(Endpoints.GetByPetID(data.Id));
                var deletePetResponse = await RestClient.DeleteAsync(deletePetRequest);
            }
        }
    }
}
