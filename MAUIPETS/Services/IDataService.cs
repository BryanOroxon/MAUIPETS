using System;
using MAUIPETS.Models;

namespace MAUIPETS.Services
{
	public interface IDataService
	{
        Task<IEnumerable<Pet>> GetPetsAsync();
    }
}

