using ApiAutomationSession3.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiAutomationSession3.Tests.GenerateTestData
{
    public class GenerateTag
    {
        public static List<Tag> Tags = new List<Tag>();

        public static List<Tag> NewTagsData()
        {
            Tag tag = new Tag
            {
                Id = 1,
                Name = "Cute"
            };

            Tags.Add(tag);

            return Tags;
        }

    }
}
