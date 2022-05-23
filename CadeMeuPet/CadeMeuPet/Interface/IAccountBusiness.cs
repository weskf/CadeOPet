using CadeMeuPet.Data;
using CadeMeuPet.Extensions;
using CadeMeuPet.ViewModel;

namespace CadeMeuPet.Interface
{
    public interface IAccountBusiness
    {
        public Task<Response> CreateAccount(RegisterViewModel account);
    }
}
