using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PoteDeOuro.Models.Entidades
{
    public class PedidoProduto
    {
        public int PedidoId { get; set; }
        public Pedidos Pedidos { get; set; }

        public int ProdutoId { get; set; }
        public Produto Produto { get; set; }
    }
}
