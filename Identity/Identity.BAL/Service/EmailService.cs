using FluentEmail.Core;
using Identity.BAL.IService;

namespace Identity.BAL.Service;

public class EmailService(IFluentEmail fluentEmail) : IEmailService
{
    public async Task<bool> SendAsync(EmailMetadata emailMetadata)
    {
        var respone = await fluentEmail.To(emailMetadata.ToAddress)
            .Subject(emailMetadata.Subject)
            .Body(emailMetadata.Body)
            .SendAsync();

        return respone.Successful;
    }
}
