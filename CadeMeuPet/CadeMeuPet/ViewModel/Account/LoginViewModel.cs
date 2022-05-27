using System.ComponentModel.DataAnnotations;

namespace CadeMeuPet.ViewModel.Account
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Campo usuário é obrigatório")]
        public string User { get; set; }

        [Required(ErrorMessage = "Campo Senha é obrigatório")]
        public string Password { get; set; }
    }
}
