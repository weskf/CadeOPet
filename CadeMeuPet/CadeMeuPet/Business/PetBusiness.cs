using CadeMeuPet.Data;
using CadeMeuPet.Extensions;
using CadeMeuPet.Interface;
using CadeMeuPet.Model;
using CadeMeuPet.ViewModel.Pet;

namespace CadeMeuPet.Business
{
    public class PetBusiness : IPetBusiness
    {
        DataContext _context;
        public PetBusiness(DataContext context)
        {
            this._context = context;
        }

        public async Task<Response> CreatePet(RegisterPetViewModel ViewModel)
        {
            Response response = new Response();

            try
            {

                response = await InsertAddress(ViewModel);

                if(response.HasError)
                    return response;

                var Address = (Address)response.Dados;

                var oPet = new Pet
                {
                    Name = ViewModel.Name,
                    AccountId = ViewModel.AccountId,
                    BreedId = ViewModel.BreedId,
                    ColorId = ViewModel.ColorId,
                    SizeId = ViewModel.SizeId,
                    StatusId = ViewModel.StatusId,
                    AddressId = Address.Id
                };

                await _context.AddAsync(oPet);
                await _context.SaveChangesAsync();

                response.MsgReturn = "Pet cadastrado com sucesso.";
                return response;
            }
            catch (Exception ex)
            {
                response.HasError = true;
                response.MsgReturn = "Houve um erro ao tentar realizar o cadastro do Pet. Msg: " + ex.Message;
                return response;
            }
        }

        private async Task<Response> InsertAddress(RegisterPetViewModel address)
        {
            Response response = new Response();

            try
            {
                var oAddress = new Address
                {
                    Street = address.Street,
                    Number = address.Number,
                    District = address.District,
                    Complement = address.Complement,
                    Cep = address.CEP,
                    CityId = address.CityId
                };

                await _context.AddAsync(oAddress);
                await _context.SaveChangesAsync();

                response.Dados = oAddress;
                response.MsgReturn = "Endereço cadastrdo com sucesso.";
                return response;

            }
            catch (Exception ex)
            {
                response.HasError = true;
                response.MsgReturn = "Houve um erro ao tentar realizar o cadastro do Endereço. Msg: " + ex.Message;
                return response;
            }
        }
    }
}
