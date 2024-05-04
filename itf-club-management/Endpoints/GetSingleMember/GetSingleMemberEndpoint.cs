using FastEndpoints;

namespace itf_club_management.Endpoints.GetSingleMember;

public sealed class GetSingleMemberEndpoint: Endpoint<GetSingleMemberRequest, GetSingleMemberResponse>
{

    public override void Configure()
    {
        Get("/member/{MemberId}");
        AllowAnonymous();
    }
    
    public override async Task HandleAsync(GetSingleMemberRequest request, CancellationToken c)
    {
        // here we need to construct a query and pass it to the handler
        // something like query = GetSingleMemberQuery.From(request.MemberId)
        // then pass it to queryResult = QueryHandler.Handle(query)
        // we need to map the queryResult to GetSingleMemberResponse
        await SendAsync(new GetSingleMemberResponse
        {
            MemberId = Guid.NewGuid(),
            FirstName = "John",
            LastName = "Doe",
            DateOfBirth = DateTime.Now,
            JoinedDate = DateTime.Now,
            Email = "jd@gmail.com",
            PhoneNumber = "123123"
        }, cancellation: c);
    }
}