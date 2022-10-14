using DemoLearning3.Tests.TestData;
using Homework3.DataModels;
using Homework3.Resources;
using RestSharp;
using System.Threading.Tasks;

namespace Homework3.Helpers
{
    public class PetHelper
    {
        /// <summary>
        /// Send POST request to add new user
        /// </summary>
        ///

        public static async Task<PetModel> AddNewPet(RestClient client)
        {
            var newPetData = GeneratePet.petModel();
            var postRequest = new RestRequest(Endpoints.PostPet());

            //Send Post Request to add new user
            postRequest.AddJsonBody(newPetData);
            var postResponse = await client.ExecutePostAsync<PetModel>(postRequest);

            var createdPetData = newPetData;
            return createdPetData;
        }
    }
}
