using System;
using System.Collections.Generic;
using System.Linq;

namespace PetOwners
{
    class Program
    {
        static void Main(string[] args)
        {
            PetOwner[] petOwners = 
                {
                new PetOwner { Name = "Higa", Pets = new List<string> { "Scruffy", "Sam" } },
                new PetOwner { Name = "Ashkenazi", Pets = new List<string> { "Walker", "Sugar" } },
                new PetOwner { Name = "Price", Pets = new List<string> { "Scratches", "Diesel" } },
                new PetOwner { Name = "Hines", Pets = new List<string> { "Dusty"}
                }
            };

            var petNamesOnly = petOwners.SelectMany(x => x.Pets);

            var query = petOwners
                .SelectMany(petOwner => petOwner.Pets, (petOwner, petName) => new { petOwner, petName })
                .Select(ownerAndPet =>
                new
                {
                    Owner = ownerAndPet.petOwner.Name,
                    Pet = ownerAndPet.petName
                });

            foreach (var obj in query)
            {
                Console.WriteLine($"{obj.Owner} {obj.Pet}");
            }
        }
    }
}
