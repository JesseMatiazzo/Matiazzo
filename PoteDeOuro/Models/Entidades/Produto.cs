using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PoteDeOuro.Models.Entidades
{
    public class Produto
    {
        [Key]
        public int IdProduto { get; set; }
        [Required(ErrorMessage ="Campo obrigatório")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        public double Preco { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Categoria { get; set; }

        public ICollection<PedidoProduto> PedidoProdutos { get; set; } = new List<PedidoProduto>();
        public bool Promocao { get; set; }

        public Produto()
        {
        }

        public Produto(int idProduto, string nome, double preco, string categoria, bool promocao)
        {
            IdProduto = idProduto;
            Nome = nome;
            Preco = preco;
            Categoria = categoria;
            Promocao = promocao;
        }
    }
}
