using FastEndpoints;
using itf_club_management.Queries;
using MediatR;

namespace itf_club_management.Endpoints.GetSingleMember;

public sealed class GetSingleMemberEndpoint: Endpoint<GetSingleMemberRequest>
{

    private readonly IMediator _mediator;
    
    public GetSingleMemberEndpoint(IMediator mediator) =>
        _mediator = mediator;
    public override void Configure()
    {
        Get("/member/{MemberId}");
        AllowAnonymous();
    }
    
    public override async Task HandleAsync(GetSingleMemberRequest request, CancellationToken c)
    {
        var member = await _mediator.Send(new GetSingleMemberQuery(request.MemberId), c);
    
        await SendAsync(GetSingleMemberResponse.From(member.Id, member.FirstName, member.LastName, member.Email, 
            member.PhoneNumber, member.JoinedDate, member.DateOfBirth, member.Grade), cancellation: c);
    }
}