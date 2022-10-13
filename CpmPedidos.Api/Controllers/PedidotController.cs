using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CpmPedidos.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PedidotController : AppBaseController
    {
        public PedidotController(IServiceProvider serviceProvider) : base(serviceProvider)
        {

        }
    }
}
