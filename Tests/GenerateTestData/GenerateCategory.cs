using ApiAutomationSession3.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiAutomationSession3.Tests.GenerateTestData
{
    public class GenerateCategory
    {
        public static Category NewCategoryData()
        {
            return new Category
            {
                Id = 1,
                Name = "Dog"
            };
        }
    }
}
