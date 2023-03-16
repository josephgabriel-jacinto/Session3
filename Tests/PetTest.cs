using ApiAutomationSession3.DataModels;
using ApiAutomationSession3.Helpers;
using ApiAutomationSession3.Resources;
using ApiAutomationSession3.Tests.GenerateTestData;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ApiAutomationSession3.Tests
{
    [TestClass]
    public class PetTest : ApiBaseTest
    {
        public static List<Pet> petCleanUpList = new List<Pet>();
        
        [TestInitialize]
        public async Task TestInitialize() {
            pet = await PetHelper.AddNewPet(restClient);
        }

        [TestCleanup]
        public async Task TestCleanup() {
            foreach (var data in petCleanUpList)
            {
                var restDeleteResponse = await restClient.DeleteAsync(new RestRequest(ApiEndPoint.DeletePetById(data.Id)));
            }
        }

        [TestMethod]
        public async Task GetPetbByIdMethod()
        {
            //Arrange
            var getRequest = new RestRequest(ApiEndPoint.GetPetById(pet.Id));
            petCleanUpList.Add(pet);

            //Act
            var getPetResponse = await restClient.ExecuteGetAsync<Pet>(getRequest);

            //Assert
            Assert.AreEqual(HttpStatusCode.OK, getPetResponse.StatusCode, "Status Code is not equal to 200");
            Assert.IsTrue(pet.Name?.Equals(getPetResponse.Data?.Name), "Name is not the same");
            Assert.IsTrue(pet.Category?.Name?.Equals(getPetResponse.Data?.Category?.Name), "Category Name is not the same");
            Assert.AreEqual(pet.PhotoUrls?.ToList().Count(), getPetResponse.Data?.PhotoUrls?.ToList().Count(), "PhotoUrls are not the same");
            Assert.AreEqual(pet.Tags?.ToList().Count(), getPetResponse.Data?.Tags?.ToList().Count(), "Tags are not the same");
            Assert.IsTrue(pet.Status?.Equals(getPetResponse.Data?.Status), "Status is not the same");

            for (int ctr = 0; ctr < getPetResponse.Data?.PhotoUrls?.Count; ctr++)
                Assert.IsTrue(pet.PhotoUrls?[ctr].Equals(getPetResponse.Data?.PhotoUrls?[ctr]), "PhotoUrl value is not the same");

            for (int ctr = 0; ctr < pet.Tags?.Count; ctr++)
                Assert.IsTrue(pet.Tags?[ctr].Name?.Equals(getPetResponse.Data?.Tags?[ctr].Name), "Tag name is not the same");
        }


    }
}
