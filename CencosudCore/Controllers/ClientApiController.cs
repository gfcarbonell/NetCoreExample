using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.Interfaces;

namespace CencosudCore.Controllers
{
    [Route("api/clients")]
    [ApiController]
    public class ClientApiController : ControllerBase
    {
        public IClientService IClientService;
        public ClientApiController(IClientService IClientService)
        {
            this.IClientService = IClientService;
        }

        [HttpGet]
        [Route("")]
        public ActionResult<Client> Get()
        {
            var obj = IClientService.Get();

            if (obj == null)
            {
                return NotFound();
            }

            return Ok(obj);
        }
    }
}