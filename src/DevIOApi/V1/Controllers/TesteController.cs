using DevIO.Business.Intefaces;
using DevIOApi.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevIOApi.V1.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/Teste")]
    public class TesteController : MainController
    {
        public TesteController(INotificador notificador, IUser appUser)
            : base(notificador, appUser)
        {

        }

        [HttpGet]
        public string Valor()
        {
            return "Sou a V1";
        }
         
    }
}
