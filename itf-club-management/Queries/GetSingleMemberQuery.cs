using itf_club_management.Models;
using MediatR;

namespace itf_club_management.Queries;

public sealed class GetSingleMemberQuery : IRequest<Member>
{
    public Guid MemberId { get; set; }
    public GetSingleMemberQuery(Guid memberId) =>
        MemberId = memberId;
}