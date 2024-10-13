namespace Identity.BAL.IService;

public interface IEmailService
{
    Task<bool> SendAsync(EmailMetadata emailMetadata);
}
