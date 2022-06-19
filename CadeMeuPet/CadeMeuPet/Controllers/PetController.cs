
using CadeMeuPet.Business;
using CadeMeuPet.Data;
using CadeMeuPet.Extensions;
using CadeMeuPet.ViewModel;
using CadeMeuPet.ViewModel.Pet;
using Microsoft.AspNetCore.Mvc;

namespace CadeMeuPet.Controllers
{
    [ApiController]
    [Route("v1")]
    public class PetController : Controller
    {
        [HttpPost("Pet")]
        public async Task<IActionResult> CreatePet([FromBody] RegisterPetViewModel model,
            [FromServices] DataContext context)
        {
            if (!ModelState.IsValid)
                return BadRequest(new ResultViewModel<string>(ModelState.GetErros()));

            Response response = new();

            try
            {
                PetBusiness oPetBusiness = new PetBusiness(context);
                response = await oPetBusiness.CreatePet(model);

                if (response.HasError)
                    return BadRequest(response.MsgReturn);

                else
                    return Ok(response);

            }
            catch (Exception ex)
            {
                response.HasError = true;
                response.MsgReturn = "Houve um erro ao tentar realizar a chamada na API Pet. Msg: " + ex.Message;
                return BadRequest(response.MsgReturn);
            }
        }
    }
}
