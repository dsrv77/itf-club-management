using itf_club_management.Models;
using MediatR;

namespace itf_club_management.Commands;

public class AddMemberCommand: IRequest<Member>
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public DateTime DateOfBirth { get; set; }
    public DateTime JoinedDate { get; set; }
    public string Grade { get; set; }

    public AddMemberCommand(string firstName, string lastName, string email, string phoneNumber, DateTime dateOfBirth, DateTime joinedDate, string grade)
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        PhoneNumber = phoneNumber;
        DateOfBirth = dateOfBirth;
        JoinedDate = joinedDate;
        Grade = grade;
    }
    
}