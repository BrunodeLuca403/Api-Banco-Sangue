using DoacaoSangue.Application.Command.AlterarDoador;
using DoacaoSangue.Application.Command.CadastrarDoador;
using DoacaoSangue.Application.InputModel;
using DoacaoSangue.Application.Query.ListarDoadorPorId;
using DoacaoSangue.Application.Query.ListarTodosDoadores;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;

namespace DoacaoSangue.API.Controllers
{
    [ApiController]
    [Route("v1/[Controller]")]
    public class DoadorController : ControllerBase
    {
        private readonly IMediator _mediator;

        public DoadorController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("lista-Doadores")]
        public async Task<IActionResult> ListarDoadores() 
        {
            try
            {
                var doadorQuery = new ListarTodosDoadoresQuery();
                var doadorViewModel = await _mediator.Send(doadorQuery);

                return Ok(doadorViewModel);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);  
            }         
        }

        [HttpGet("detalhes-doador")]
        public async Task<IActionResult> BuscarDoadorId(int id)
        {
            try
            {
                var doadorId = new ListarDoadorPorIdQuery(id);

                var DoadorViewMode = await _mediator.Send(doadorId);

                return Ok(DoadorViewMode);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("cadastrar-doador")]
        public async Task<IActionResult> CadastrarDoador([FromBody] AdicionarDoadorCommand doador)
        {
            try
            {
                var cadastro = await _mediator.Send(doador);

                return CreatedAtAction(nameof(BuscarDoadorId), new { id = cadastro }, doador);

            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> AlterarDoador([FromBody] AlterarDoadorCommand doador)
        {
            try
            {
                var id = await _mediator.Send(doador);
                return Ok(id);

            }catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
