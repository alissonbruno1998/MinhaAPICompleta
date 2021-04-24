using DevIO.Business.Intefaces;
using DevIOApi.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevIOApi.V2.Controllers
{
    [ApiVersion("2.0")]
    [Route("api/v{version:apiVersion}/Teste")]
    public class TesteController : MainController
    {
        private readonly ILogger _logger;

        public TesteController(INotificador notificador, IUser appUser
            , ILogger<TesteController> logger)
            : base(notificador, appUser)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Valor()
        {
            _logger.LogTrace("Log de Trace");
            _logger.LogDebug("Log de Debug");
            _logger.LogInformation("Log de Informação");
            _logger.LogError("Log de Aviso");
            _logger.LogCritical("Log de Problema Critico");

            return "Sou a V2";
        }
    }
}
