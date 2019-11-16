using PoteDeOuro.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PoteDeOuro.Models.Entidades
{
    public class Pedidos
    {
        [Key]
        public int PedidosId { get; set; }

        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public double ValorPedido { get; set; }
        public ICollection<PedidoProduto> PedidoProdutos { get; set; } = new List<PedidoProduto>();
        public SituacaoPedido Situacao { get; set; }

        public Pedidos()
        {
        }

        public Pedidos(int pedidosId, int clienteId, Cliente cliente, double valorPedido, SituacaoPedido situacao)
        {
            PedidosId = pedidosId;
            ClienteId = clienteId;
            Cliente = cliente;
            ValorPedido = valorPedido;
            Situacao = situacao;
        }
    }
}
