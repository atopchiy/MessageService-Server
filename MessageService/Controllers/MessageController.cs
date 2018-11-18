using MessageService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MessageService.Controllers
{
    public class MessageController : ApiController
    {
        [HttpGet]
        public string Get()
        {
            return "0";
        }

        [HttpPost]
        public string Save([FromBody]MessageModel message)
        {
            return Services.MessageService.SaveMessage(message);
        }
    }
}
