using Email_Test.DTOs;

namespace Email_Test.EmailService
{
    public interface IEmailService
    {
        string SendEmail(RequestDTO request);
    }
}
