using CadeMeuPet.Business;
using CadeMeuPet.Data;
using CadeMeuPet.Extensions;
using CadeMeuPet.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace CadeMeuPet.Controllers
{
    [ApiController]
    [Route("v1")]
    public class AccountController : ControllerBase
    {
        [HttpPost("accounts")]
        public async Task<IActionResult> Create([FromBody] RegisterViewModel model,
            [FromServices] DataContext context)
        {
            if (!ModelState.IsValid)
                return BadRequest(new ResultViewModel<string>(ModelState.GetErros()));

            try
            {
                AccountBusiness oAccountBusiness = new AccountBusiness();
                oAccountBusiness.CreateAccount(model);
            }
            catch (Exception)
            {

                throw;
            }
            return Ok();
        }
    }
}
