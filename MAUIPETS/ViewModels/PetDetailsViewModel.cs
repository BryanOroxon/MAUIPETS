using System;
using MAUIPETS.Models;

namespace MAUIPETS.ViewModels
{
    public class PetDetailsViewModel : BaseViewModel
    {

        public Pet Pets { get; set; }

        public PetDetailsViewModel(Pet pet)
        {
            Title = $"Scroll {pet.Name} Details";

            Pets = pet;
        }

    }
}

