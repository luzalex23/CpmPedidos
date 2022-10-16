using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CpmPedidos.Domain.Dtos
{
    public class CidadeDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Uf { get; set; }
        public bool Ativo { get; set; }
    }
}
