using Enums;
using FluxoCaixa.Enums;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FluxoCaixa.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FormaDePagamentoController : ControllerBase
    {
        public FormaDePagamentoController()
        {
        }
            // Recupera os Tipos de Forma de pagamento
            [HttpGet]
            public IActionResult RecuperaFormaDePagamento()
            {
                var formaDePagamento = Enum.GetValues(typeof(EnTipoFormaDePagamento))
                    .Cast<EnTipoFormaDePagamento>()
                    .Select(f => new { Id = (int)f, Nome = f.GetDisplayName() })
                    .ToList();
                return Ok(formaDePagamento);

            }

            // Recupera os Fluxos pelo id
            [HttpGet("{id}")]
            public IActionResult RecuperarFormasDePagamentoPorId(int id)
            {
                var formaDePagamento = Enum.GetValues(typeof(EnTipoFormaDePagamento))
                    .Cast<EnTipoFormaDePagamento>()
                    .Select(f => new { Id = (int)f, Nome = f.GetDisplayName() })
                    .Where(f => f.Id == id)
                    .ToList();

                if (formaDePagamento == null || formaDePagamento.Count == 0)
                {
                    return NotFound("Nenhum custo encontrado para o tipo especificado.");
                }
                return Ok(formaDePagamento);
            }
        }
    }

