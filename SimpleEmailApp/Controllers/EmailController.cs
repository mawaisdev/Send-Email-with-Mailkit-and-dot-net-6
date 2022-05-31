using Microsoft.AspNetCore.Mvc;

namespace SimpleEmailApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        private readonly IEmailService _emailService;

        public EmailController(IEmailService emailService)
        {
            _emailService = emailService;
        }

        [HttpPost]
        public IActionResult SendMail(EmailDto request)
        {
            _emailService.SendMail(request);
            return Ok();
        }
    }
}
