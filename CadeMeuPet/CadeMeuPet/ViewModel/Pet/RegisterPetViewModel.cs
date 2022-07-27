using System.ComponentModel.DataAnnotations;

namespace CadeMeuPet.ViewModel.Pet
{
    public class RegisterPetViewModel
    {
        public string Name { get; set; }

        [Required(ErrorMessage = "Necessário informar o Id do usuário")]
        public int AccountId { get; set; }
        public int BreedId { get; set; }

        [Required(ErrorMessage = "Necessário informar a cor")]
        public int ColorId { get; set; }

        [Required(ErrorMessage = "Necessário informar o tamanho")]
        public int SizeId { get; set; }

        [Required(ErrorMessage = "Necessário informar o Logradouro")]
        public string Street { get; set; }

        [Required(ErrorMessage = "Necessário informar o número")]
        public string Number { get; set; }

        [Required(ErrorMessage = "Necessário informar o CEP")]
        public string CEP { get; set; }
        public string District { get; set; }
        public string Complement { get; set; }

        [Required(ErrorMessage = "Necessário informar a cidade")]
        public int CityId { get; set; }

        [Required(ErrorMessage = "Necessário informar a situação do Pet")]
        public int StatusId { get; set; }

    }
}
