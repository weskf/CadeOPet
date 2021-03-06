namespace CadeMeuPet.Model
{
    public class Account
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FullName { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public virtual Pet Pet { get; set; }
    }
}
