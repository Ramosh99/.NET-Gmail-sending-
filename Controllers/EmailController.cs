using Email_Test.DTOs;
using Email_Test.EmailService;
using Microsoft.AspNetCore.Mvc;


namespace Email_Test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        private readonly IEmailService emailService;

        public EmailController(IEmailService emailService)
        {
            this.emailService = emailService;
        }

        [HttpPost("SendEmails")]
        public ActionResult SendEmail(RequestDTO request)
        {
            var result = emailService.SendEmail(request);
            
            return Ok("mail sent !");
        }
    }
    
    
}
