using learning_site.Models.ViewModels;

namespace learning_site.Services.Email
{
    public interface IEmailService
    {
        string SendEmail(EmailModel emailModel);
    }
}