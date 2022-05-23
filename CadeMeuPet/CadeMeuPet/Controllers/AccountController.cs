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

            Response response = new();

            try
            {
                AccountBusiness oAccountBusiness = new(context);
                response = await oAccountBusiness.CreateAccount(model);

                if(response.HasError)
                    return BadRequest(response.MsgReturn);

                else
                    return Ok(response.MsgReturn.ToString());   
            }
            catch (Exception ex)
            {
                response.HasError = true;
                response.MsgReturn = "Houve um erro ao tentar realizar a chamada na API Accounts. Msg: " + ex.Message;
                return BadRequest(response.MsgReturn);
            }
        }
    }
}
