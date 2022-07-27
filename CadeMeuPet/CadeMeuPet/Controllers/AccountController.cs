using CadeMeuPet.Business;
using CadeMeuPet.Data;
using CadeMeuPet.Extensions;
using CadeMeuPet.Model;
using CadeMeuPet.Services;
using CadeMeuPet.ViewModel;
using CadeMeuPet.ViewModel.Account;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CadeMeuPet.Controllers
{
    [ApiController]
    [Route("v1")]
    public class AccountController : ControllerBase
    {
        [HttpPost("accounts")]
        public async Task<IActionResult> CreateAccount([FromBody] RegisterViewModel model,
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
                    return Ok(response);   
            }
            catch (Exception ex)
            {
                response.HasError = true;
                response.MsgReturn = "Houve um erro ao tentar realizar a chamada na API Accounts. Msg: " + ex.Message;
                return BadRequest(response.MsgReturn);
            }
        }

        [Authorize]
        [HttpPatch("accounts/{id:int}")]
        public async Task<IActionResult> UpdateAccount([FromBody] RegisterViewModel model, int id,
            [FromServices] DataContext context)
        {
            if (!ModelState.IsValid)
                return BadRequest(new ResultViewModel<string>(ModelState.GetErros()));

            Response response = new();

            try
            {
                AccountBusiness oAccountBusiness = new(context);
                response = await oAccountBusiness.UpdateAccount(id, model);

                if (response.HasError)
                    return BadRequest(response);

                else
                    return Ok(response);
            }
            catch (Exception ex)
            {
                response.HasError = true;
                response.MsgReturn = "Houve um erro ao tentar realizar a chamada na API Accounts. Msg: " + ex.Message;
                return BadRequest(response);
            }
        }

        [HttpPost("accounts/login")]
        public async Task<IActionResult> Login([FromBody] LoginViewModel model,
                                               [FromServices] DataContext context, 
                                               [FromServices] TokenService tokenService)
        {
            Response response = new();

            try
            {
                if(!ModelState.IsValid)
                    return BadRequest(new ResultViewModel<string>(ModelState.GetErros()));

                AccountBusiness oAccountBusiness = new(context);
                response = await oAccountBusiness.Login(model);

                if (response.HasError)
                    return BadRequest(response.MsgReturn);

                var token = tokenService.GenerateToken((Account)response.Dados);
                return Ok(new ResultViewModel<string>(token, null));
                
            }
            catch (Exception ex)
            {
                response.HasError = true;
                response.MsgReturn = "Houve um erro ao tentar realizar o login. Msg: " + ex.Message;
                return BadRequest(response.MsgReturn);
            }
        }
    }
}
