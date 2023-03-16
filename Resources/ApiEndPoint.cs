using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiAutomationSession3.Resources
{
    public class ApiEndPoint
    {

        public const string baseUrl = "https://petstore.swagger.io/v2";

        public readonly string PetEndpoint = "pet";
        
        public static string GetPetById(long id) => $"{baseUrl}/pet/{id}";

        public static string PostPet() => $"{baseUrl}/pet";

        public static string DeletePetById(long id) => $"{baseUrl}/pet/{id}";

    }
}
