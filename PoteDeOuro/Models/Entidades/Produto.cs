using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PoteDeOuro.Models.Entidades
{
    public class Produto
    {
        public int IdProduto { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public double Preco { get; set; }
        [Required]
        public string Categoria { get; set; }

        public Produto(int idProduto, string nome, double preco, string categoria)
        {
            IdProduto = idProduto;
            Nome = nome;
            Preco = preco;
            Categoria = categoria;
        }
    }
}
