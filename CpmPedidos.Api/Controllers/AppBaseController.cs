using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CpmPedidos.Api.Controllers
{

    public class AppBaseController : ControllerBase
    {
        protected readonly IServiceProvider ServiceProvider;

        public AppBaseController(IServiceProvider serviceProvider)
        {

        }
    }
}
