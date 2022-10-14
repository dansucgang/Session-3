using Homework3.DataModels;
using System;
using System.Collections.Generic;

namespace DemoLearning3.Tests.TestData
{
    public class GeneratePet
    {
        public static PetModel petModel()
        {

            List<Tags> tags = new List<Tags>();
            tags.Add(new Tags()
            {
                Id = 2005,
                Name = "Animal"
            });

            return new PetModel
            {

                Id = 2005,
                Name = "Sea Turtle",
                PhotoUrls = new List<string> { "Photo_String" },
                Category = new Category()
                {
                    Id = 2005,
                    Name = "Sea"
                },
                Tags = tags,
                Status = "available"
            };
        }
    }
}
