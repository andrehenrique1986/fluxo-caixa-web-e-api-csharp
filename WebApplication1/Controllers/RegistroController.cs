using AutoMapper;
using FluxoCaixa.Context;
using FluxoCaixa.DTO;
using FluxoCaixa.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FluxoCaixa.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RegistroController : ControllerBase
    {
        private readonly FluxoContext _context;
        private readonly IMapper _mapper;

        public RegistroController(FluxoContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // Adiciona um novo Registro
        [HttpPost]
        public IActionResult AdicionarRegistro([FromBody] CreateRegistroDTO registroDTO)
        {
            Registro registro = _mapper.Map<Registro>(registroDTO);
            _context.Registros.Add(registro);
            _context.SaveChanges();
            return CreatedAtAction(nameof(RecuperarRegistrosPorId),
                new { id = registro.IdRegistro },
                registro);

        }

        // Recupera todos os Registros
        [HttpGet]
        public IActionResult RecuperaRegistro()
        {
            var registros = _context.Registros
                .Select(r =>
                new
                {
                    Id = r.IdRegistro,
                    DataRegistro = r.DtRegistro,
                    CategoriaId = r.IdCategoria,
                    SubcategoriaId = r.IdSubcategoria,
                    CustoId = r.IdCusto,
                    FluxoId = r.IdFluxo,
                    FormaDePagamento = r.IdFormaDePagamento,
                    Valor = r.ValorRegistro
                }).ToList();
            if (registros == null) return NotFound();
            return Ok(registros);
        }

        // Recupera todas as Categorias pelo Id
        [HttpGet("{id}")]
        public IActionResult RecuperarRegistrosPorId(int id)
        {
            var registros = _context.Registros
                .Where(r => r.IdRegistro == id)
                .Select(r =>
                new
                {
                    Id = r.IdRegistro,
                    DataRegistro = r.DtRegistro,
                    CategoriaId = r.IdCategoria,
                    SubcategoriaId = r.IdSubcategoria,
                    CustoId = r.IdCusto,
                    FluxoId = r.IdFluxo,
                    FormaDePagamentoId = r.IdFormaDePagamento,
                    Valor = r.ValorRegistro
                }).ToList();
            if (registros == null) return NotFound();
            return Ok(registros);
        }

        // Realiza a Alteração dos Registros
        [HttpPut("{id}")]
        public IActionResult AtualizarRegistro(int id, [FromBody] UpdateRegistroDTO registroDto)
        {
            Registro registro = _context.Registros.FirstOrDefault(registro => registro.IdRegistro == id);
            if (registro == null)
            {
                return NotFound();
            }

            _context.Entry<Registro>(registro).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _mapper.Map(registroDto, registro);
            _context.SaveChanges();
            return NoContent();
        }

        // Exclui os Registros
        [HttpDelete("{id}")]
        public IActionResult ExcluirRegistro(int id)
        {
            Registro registro = _context.Registros.FirstOrDefault(r => r.IdRegistro == id);
            if (registro == null)
            {
                return NotFound();
            }
            _context.Remove(registro);
            _context.SaveChanges();
            return NoContent();
        }

    }
}
