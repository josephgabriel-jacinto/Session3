using ApiAutomationSession3.DataModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiAutomationSession3.Tests.GenerateTestData
{
    public class GeneratePet
    {
        public static Pet CreateNewPetData()
        {
            return new Pet
            {
                Id = 50009 + long.Parse(DateTime.Now.ToString("yyyyMMdd")),
                Category = GenerateCategory.NewCategoryData(),
                Name = "Rocky",
                PhotoUrls = new List<string> {"www.sample.url.1"},
                Tags = GenerateTag.NewTagsData(),
                Status = "Available"
            };
        }
    }
}
