using itf_club_management.Data;
using itf_club_management.Models;
using itf_club_management.Queries;
using MediatR;

namespace itf_club_management.Handlers;

public sealed class GetMemberByIdHandler : IRequestHandler<GetSingleMemberQuery, Member>
{
    private ApplicationDbContext _context;
    public GetMemberByIdHandler(ApplicationDbContext context) =>
        _context = context;
    
    public async Task<Member> Handle(GetSingleMemberQuery request, CancellationToken cancellationToken)
    {
        return await _context.Members.FindAsync(request.MemberId);
    }
}