using CadeMeuPet.Data;
using CadeMeuPet.Extensions;
using CadeMeuPet.Interface;
using CadeMeuPet.Model;
using CadeMeuPet.ViewModel;
using Microsoft.EntityFrameworkCore;

namespace CadeMeuPet.Business
{
    public class AccountBusiness : IAccountBusiness
    {
        DataContext _context;
        public AccountBusiness(DataContext context)
        {
           this._context = context;
        }

        public async Task<Response> CreateAccount(RegisterViewModel account)
        {
            Response response = new Response();

            try
            {
                var user = new Account
                {
                    Name = account.Name,
                    FullName = account.FullName,
                    CPF = account.CPF,
                    Email = account.Email,
                    User = account.User,
                    Password = account.Password,
                    ConfirmPassword = account.ConfirmPassword
                };

                response = await Validate(user);

                if (response.HasError)
                {
                    return response;
                }

                await _context.Accounts.AddAsync(user);
                await _context.SaveChangesAsync();

                response.MsgReturn = "Usuário Cadastrado.";
                return response;

            }
            catch (Exception ex)
            {
                response.HasError = true;
                response.MsgReturn = "Houve um erro ao tentar realizar o cadastro do usuário. Msg: " + ex.Message;
                return response;
            }
        }

        private async Task<Response> Validate(Account account)
        {
            Response response = new Response();

            try
            {
                if (account.Password != account.ConfirmPassword)
                {
                    response.HasError = true;
                    response.MsgReturn = "Senhas devem coincidir";
                    return response;
                }

                var user = await _context.Accounts.FirstOrDefaultAsync(x => x.User == account.User);
                if (user != null)
                {
                    response.HasError= true;
                    response.MsgReturn = "Usuário já está cadastrado";
                }
                else
                   response.HasError= false;

                return response;
            }
            catch (Exception ex)
            {
                response.HasError = true;
                response.MsgReturn = "Houve um erro ao tentar fazer as validações do usuário. Msg: " + ex.Message;
                return response;
            }
        }
    }
}
