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
    public string Grade { get; init; } = default!;
    
    public static GetSingleMemberResponse From(Guid memberId, string firstName, string lastName, string email, string phoneNumber, DateTime dateOfBirth, DateTime joinedDate, string grade) =>
        new()
        {
            MemberId = memberId,
            FirstName = firstName,
            LastName = lastName,
            Email = email,
            PhoneNumber = phoneNumber,
            DateOfBirth = dateOfBirth,
            JoinedDate = joinedDate,
            Grade = grade
        };
}