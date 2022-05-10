using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CpmPedidos.Domain.Entities
{
    public class BaseDomain
    {
        public int Id { get; set; }
        public DateTime DtCriacao { get; set; }
    }
}
