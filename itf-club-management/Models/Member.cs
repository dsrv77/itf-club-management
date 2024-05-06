using System.ComponentModel.DataAnnotations;

namespace itf_club_management.Models;

public sealed class Member
{
    private Member(Guid id, string firstName, string lastName, string email, string phoneNumber, DateTime joinedDate, DateTime dateOfBirth, string grade)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        PhoneNumber = phoneNumber;
        JoinedDate = joinedDate;
        DateOfBirth = dateOfBirth;
        Grade = grade;
    }
    
    public static Member Create(Guid id, string firstName, string lastName, string email, string phoneNumber, DateTime joinedDate, DateTime dateOfBirth, string grade) =>
        new(id, firstName, lastName, email, phoneNumber, joinedDate, dateOfBirth, grade);

    [Key]
    public Guid Id { get; set; }
    public string FirstName { get; private set; } = default!;
    public string LastName { get; private set; } = default!;
    public string Email { get; private set; } = default!;
    public string PhoneNumber { get; private set; } = default!;
    public string Grade { get; private set; } = default!;
    public DateTime JoinedDate { get; private set; }
    public DateTime DateOfBirth { get; private set; }



}