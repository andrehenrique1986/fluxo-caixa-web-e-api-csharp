using AutoMapper;
using FluxoCaixa.DTO;
using FluxoCaixa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FluxoCaixa.Profiles
{
    public class FormaDePagamentoProfile : Profile
    {
        public FormaDePagamentoProfile()
        {
            CreateMap<FormaDePagamento, ReadFormaDePagamentoDTO>();


            CreateMap<FormaDePagamento, ReadFormaDePagamentoDTO>().
                ForMember(formaDePagamentoDto => formaDePagamentoDto.Registros,
                opt => opt.MapFrom(formaDePagamento => formaDePagamento.Registros));
        }
    }
    }

