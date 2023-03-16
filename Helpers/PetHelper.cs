using ApiAutomationSession3.DataModels;
using ApiAutomationSession3.Resources;
using ApiAutomationSession3.Tests.GenerateTestData;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiAutomationSession3.Helpers
{
    public class PetHelper
    {
        public static async Task<Pet> AddNewPet(RestClient restClient)
        {
            var newPetData = GeneratePet.CreateNewPetData();
            var postRequest = new RestRequest(ApiEndPoint.PostPet());

            postRequest.AddJsonBody(newPetData);

            var postResponse = await restClient.ExecutePostAsync<Pet>(postRequest);

            var createdPetData = newPetData;

            return createdPetData;
        }

    }
}
