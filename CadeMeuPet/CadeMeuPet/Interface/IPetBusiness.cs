using CadeMeuPet.Extensions;
using CadeMeuPet.ViewModel.Pet;

namespace CadeMeuPet.Interface
{
    public interface IPetBusiness
    {
        public Task<Response> CreatePet(RegisterPetViewModel pet);
    }
}
