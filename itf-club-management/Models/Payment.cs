using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace itf_club_management.Models;

public sealed class Payment
{
    private Payment(Guid id, Guid memberId, DateTime paymentDate, int month)
    {
        Id = id;
        MemberId = memberId;
        PaymentDate = paymentDate;
        Month = month;
    }
    
    public static Payment Create(Guid id, Guid memberId, DateTime paymentDate, int month) =>
        new(id, memberId, paymentDate, month);

    [Key]
    public Guid Id { get; set; }
    [ForeignKey("Member")]
    public Guid MemberId { get; private set; }
    public DateTime PaymentDate { get; private set; }
    public int Month { get; private set; }

    
}