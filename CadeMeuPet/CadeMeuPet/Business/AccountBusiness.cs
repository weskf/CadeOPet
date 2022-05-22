using CadeMeuPet.Extensions;
using CadeMeuPet.Model;
using CadeMeuPet.ViewModel;

namespace CadeMeuPet.Business
{
    public class AccountBusiness
    {
        public Response CreateAccount(RegisterViewModel account)
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

                response.MsgReturn = "Usuário Cadastrado.";
                return response;

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
