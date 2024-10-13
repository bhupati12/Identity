namespace Identity.BAL.Features.Account.Commands.Registration;

public class RegistrationCommandHandler() : IRequestHandler<RegistrationCommand, RegistrationCommandResponse>
{
    public Task<RegistrationCommandResponse> Handle(RegistrationCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
