using CadeMeuPet.Data;
using CadeMeuPet.Extensions;
using CadeMeuPet.ViewModel;
using CadeMeuPet.ViewModel.Account;

namespace CadeMeuPet.Interface
{
    public interface IAccountBusiness
    {
        public Task<Response> CreateAccount(RegisterViewModel account);
        public Task<Response> UpdateAccount(int id, RegisterViewModel account);
        public Task<Response> Login(LoginViewModel account);
    }
}
