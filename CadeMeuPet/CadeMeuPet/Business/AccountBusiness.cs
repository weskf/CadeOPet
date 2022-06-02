using CadeMeuPet.Data;
using CadeMeuPet.Extensions;
using CadeMeuPet.Interface;
using CadeMeuPet.Model;
using CadeMeuPet.ViewModel;
using CadeMeuPet.ViewModel.Account;
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
                var oAccount = new Account
                {
                    Name = account.Name,
                    FullName = account.FullName,
                    CPF = account.CPF,
                    Email = account.Email,
                    Telefone = account.Telefone,
                    User = account.User,
                    Password = account.Password,
                    ConfirmPassword = account.ConfirmPassword
                };

                response = await Validate(oAccount);

                if (response.HasError)
                {
                    return response;
                }

                await _context.Accounts.AddAsync(oAccount);
                await _context.SaveChangesAsync();

                response.MsgReturn = "Usuário Cadastrado.";
                response.Dados = oAccount;
                return response;

            }
            catch (Exception ex)
            {
                response.HasError = true;
                response.MsgReturn = "Houve um erro ao tentar realizar o cadastro do usuário. Msg: " + ex.Message;
                return response;
            }
        }

        public async Task<Response> UpdateAccount(RegisterViewModel account)
        {
            Response response = new();

            try
            {
                var user = await _context.Accounts.FirstOrDefaultAsync(x => x.Id == account.Id);
                if (user == null)
                {
                    response.HasError = true;
                    response.MsgReturn = "Usuário não encontrado.";
                    return response;
                }

                var oAccount = new Account
                {
                    Id = account.Id,
                    Name = account.Name,
                    FullName = account.FullName,
                    Email = account.Email,
                    CPF = account.CPF,
                    Telefone = account.Telefone,
                    User = account.User,
                    Password = account.Password,
                    ConfirmPassword = account.ConfirmPassword
                };

                response = ValidatePassword(oAccount);
                if (response.HasError)
                    return response;

                _context.Accounts.Update(oAccount);
                await _context.SaveChangesAsync();

                response.HasError = false;
                response.MsgReturn = "Usuário atualizado com sucesso.";
                response.Dados = oAccount;
                return response;

            }
            catch (Exception ex)
            {
                response.HasError = true;
                response.MsgReturn = "Houve um erro ao tentar realizar a atualização do usuário. Msg: " + ex.Message;
                return response;
            }
        }

        private Response ValidatePassword(Account account)
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
                else
                    response.HasError = false;

                return response;
            }
            catch (Exception ex)
            {
                response.HasError = true;
                response.MsgReturn = "Houve um erro ao validar a senha. Msg: " + ex.Message;
                return response;
            }
        }
        
        private async Task<Response> Validate(Account account)
        {
            Response response = new Response();

            try
            {
                response = ValidatePassword(account);
                if (response.HasError)
                    return response;

                var user = await _context.Accounts.FirstOrDefaultAsync(x => x.User == account.User);
                if (user != null)
                {
                    response.HasError = true;
                    response.MsgReturn = "Usuário já está cadastrado";
                }
                else
                    response.HasError = false;

                return response;
            }
            catch (Exception ex)
            {
                response.HasError = true;
                response.MsgReturn = "Houve um erro ao tentar fazer as validações do usuário. Msg: " + ex.Message;
                return response;
            }
        }
        
        public async Task<Response> Login(LoginViewModel account)
        {
            Response response = new();

            try
            {
                var user = await _context.Accounts.FirstOrDefaultAsync(x => x.User == account.User && x.Password == account.Password);
                if (user == null)
                {
                    response.HasError = true;
                    response.MsgReturn = "Usuário ou senha inválidos";
                    return response;
                }

                response.Dados = user;
                response.HasError = false;
                return response;

            }
            catch (Exception ex)
            {
                response.HasError = true;
                response.MsgReturn = "Houve um erro ao tentar realizar o login do usuário. Msg: " + ex.Message;
                return response;
            }
        }
    }
}
