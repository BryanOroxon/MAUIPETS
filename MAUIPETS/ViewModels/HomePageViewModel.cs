using System;
using System.Collections.ObjectModel;
using MAUIPETS.Services;
using MAUIPETS.Models;


namespace MAUIPETS.ViewModels
{
	public class HomePageViewModel : BindableObject
    {
        ObservableCollection<Pet> _pets;


        public HomePageViewModel()
		{
            string Title="HOla Bryan!!";
			LoadPetsList();
		}

        public ObservableCollection<Pet> Pets
        {
            get { return _pets; }
            set
            {
                _pets = value;
                OnPropertyChanged();
            }
        }

        void LoadPetsList()
        {
            var items = PetService.PetsData;
            Pets = new ObservableCollection<Pet>(items);
        }
    }
}

