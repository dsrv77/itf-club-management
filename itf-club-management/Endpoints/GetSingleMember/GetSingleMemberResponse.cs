namespace itf_club_management.Endpoints.GetSingleMember;

public sealed record GetSingleMemberResponse
{
    public Guid MemberId { get; set; }
    public string FirstName { get; init; } = default!;
    public string LastName { get; init; } = default!;
    public string Email { get; init; } = default!;
    public string PhoneNumber { get; init; } = default!;
    public DateTime DateOfBirth { get; init; }
    public DateTime JoinedDate { get; init; }
}