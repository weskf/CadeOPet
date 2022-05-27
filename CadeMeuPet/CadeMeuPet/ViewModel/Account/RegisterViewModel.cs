using System.ComponentModel.DataAnnotations;

namespace CadeMeuPet.ViewModel
{
    public class RegisterViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Nome é obrigatório")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Nome é obrigatório")]
        public string FullName { get; set; }
        
        public string CPF { get; set; }

        [Required(ErrorMessage = "Usuário é obrigatório")]
        public string User { get; set; }

        [Required(ErrorMessage = "E-mail é obrigatório")]
        [DataType(DataType.EmailAddress, ErrorMessage = "E-mail em formato inválido.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Telefone é obrigatório")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "Senha é obrigatório")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Senha é obrigatório")]
        public string ConfirmPassword { get; set; }
    }
}
