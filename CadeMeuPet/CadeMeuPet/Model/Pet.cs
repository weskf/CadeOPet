using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CadeMeuPet.Model
{
    public class Pet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int BreedId { get; set; }
        public virtual Breed PetBreed { get; set; }
        public int ColorId { get; set; }
        public virtual Color Color { get; set; }
        public int SizeId { get; set; }
        public virtual Size Size { get; set; }
        public int StatusId { get; set; }
        public virtual Status Status { get; set; }
        public int ImageId { get; set; }
        public virtual IList<Image> Images { get; set; }
        public int AddressId { get; set; }
        public virtual Address Address { get; set; }

    }

    public class Breed
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public virtual Pet Pet { get; set; }
    }

    public class Color
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public virtual Pet Pet { get; set; }
    }

    public class Size
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public virtual Pet Pet { get; set; }

    }

    public class Status
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public virtual Pet Pet { get; set; }
    }

    public class Image
    {
        public int Id { get; set; }
        public string Base64 { get; set; }
        public virtual Pet Pet { get; set; }
    }
}
