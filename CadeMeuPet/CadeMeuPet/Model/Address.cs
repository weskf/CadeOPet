using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CadeMeuPet.Model
{
    public class Address
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
        public string Cep { get; set; }
        public string District { get; set; }
        public string Complement { get; set; }
        public int CityId { get; set; }
        public virtual City City { get; set; }
        //public int StateId { get; set; }
        //public virtual State State { get; set; }
    }

    public class City
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int StateId { get; set; }
        public virtual List<State> States { get; set; }
        public virtual Address Address { get; set; }
    }

    public class State
    {
        public int Id { get; set; }
        public string UF { get; set; }
        public string Description { get; set; }
        public virtual City City { get; set; }
       // public virtual Address Address { get; set; }
    }
}
