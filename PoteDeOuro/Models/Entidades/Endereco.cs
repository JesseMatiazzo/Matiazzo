using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PoteDeOuro.Models.Entidades
{
    public class Endereco
    {
        [Key]
        public int EnderecoId { get; set; }
        public int Cep { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string PontoReferencia { get; set; }
        public List<Cliente> Clientes { get; set; } = new List<Cliente>();

        public Endereco()
        {
        }

        public Endereco(int enderecoId, string estado, int cep, string cidade, string bairro, string rua, string numero, string pontoReferencia)
        {
            EnderecoId = enderecoId;
            Estado = estado;
            Cidade = cidade;
            Bairro = bairro;
            Rua = rua;
            Numero = numero;
            PontoReferencia = pontoReferencia;
            Cep = cep;
        }
    }
}
