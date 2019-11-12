using PoteDeOuro.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PoteDeOuro.Models.Entidades
{
    public class Pedidos
    {
        public int PedidosId { get; set; }
        public Cliente Cliente { get; set; }
        public Endereco Endereco { get; set; }
        public double ValorPedido { get; set; }
        public List<Produto> Produtos { get; set; } = new List<Produto>();
        public SituacaoPedido Situacao { get; set; }

        public Pedidos(int pedidosId, Cliente cliente, Endereco endereco, double valorPedido, SituacaoPedido situacao)
        {
            PedidosId = pedidosId;
            Cliente = cliente;
            Endereco = endereco;
            ValorPedido = valorPedido;
            Situacao = situacao;
        }
    }
}
