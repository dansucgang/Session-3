using System;
using System.Collections.Generic;
using System.Text;

namespace Homework3.Resources
{
    /// <summary>
    /// Class containing all endpoints used in API tests
    /// </summary>
    public class Endpoints
    {
        //Base URL
        public const string baseURL = "https://petstore.swagger.io/v2";

        public static string GetByPetID(long petId) => $"{baseURL}/pet/{petId}";

        public static string PostPet() => $"{baseURL}/pet";

        public static string DeleteByPetId(long petId) => $"{baseURL}/user/{petId}";
    }
}
