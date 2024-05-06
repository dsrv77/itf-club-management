using itf_club_management.Commands;
using itf_club_management.Data;
using itf_club_management.Models;
using MediatR;

namespace itf_club_management.Handlers;

public class AddMemberCommandHandler: IRequestHandler<AddMemberCommand, Member>
{
    private ApplicationDbContext _context;
    public AddMemberCommandHandler(ApplicationDbContext context) =>
        _context = context;

    public async Task<Member> Handle(AddMemberCommand request, CancellationToken cancellationToken)
    {
        var member = Member.Create(Guid.NewGuid(), request.FirstName, request.LastName,  request.Email, request.PhoneNumber,
            request.JoinedDate, request.DateOfBirth, request.Grade);
        _context.Members.Add(member);
        await _context.SaveChangesAsync(cancellationToken);
        return member;
    }
}