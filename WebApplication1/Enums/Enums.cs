using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Enums
{
    
    public enum EnTipoFluxo
    {
        [Display(Name = "Entrada")]
        ENTRADA = 0,

        [Display(Name = "Saída")]
        SAIDA = 1

    }

    public enum EnTipoCusto
    {
        [Display(Name = "Fixo")]
        FIXO = 0,

        [Display(Name = "Variável")]
        VARIAVEL = 1
    }

    public enum EnTipoFormaDePagamento
    {
        [Display(Name = "Cartão de Crédito")]
        CARTAO_DE_CREDITO = 0,

        [Display(Name = "Pix")]
        PIX = 1,

        [Display(Name = "Boleto")]
        BOLETO = 2,

        [Display(Name = "Débito")]
        DEBITO = 3

    }
}


