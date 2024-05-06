using FastEndpoints;
using itf_club_management.Commands;
using MediatR;

namespace itf_club_management.Endpoints.AddMember;

public sealed class AddMemberEndpoint : Endpoint<AddMemberRequest>
{
    private readonly IMediator _mediator;
    
    public AddMemberEndpoint(IMediator mediator) =>
        _mediator = mediator;

    public override void Configure()
    {
        Post("/member");
        AllowAnonymous();
    }
    
    public override async Task HandleAsync(AddMemberRequest request, CancellationToken c)
    {
        var member = await _mediator.Send(new AddMemberCommand(request.FirstName, request.LastName, request.Email, request.PhoneNumber, request.DateOfBirth, request.JoinedDate, request.Grade), c);
        await SendOkAsync(member,c);
    }
}