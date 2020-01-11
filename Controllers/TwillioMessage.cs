using System;
using System.IO;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;
using PuneCarRideApi.Data;
using Twilio;

namespace PuneCarRideApi.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class TwillioMessage:ControllerBase
    {
        [HttpPost("SendMessage")]
        public IActionResult SendMessage([FromBody] Message recievedMessage){
            const string accountSid = "AC1a265ad2c861e381beeefc207c45a831";
            const string authToken = "d3c017b912d89985170dfa6535a00caa";

            TwilioClient.Init(accountSid, authToken);

            var message =  MessageResource.Create(
                body: recievedMessage.Text,
                from: new Twilio.Types.PhoneNumber("+12532998306"),
                to: new Twilio.Types.PhoneNumber(recievedMessage.ToPhoneNumber)
            );

           return Ok(message); 
          
        }
    }
}