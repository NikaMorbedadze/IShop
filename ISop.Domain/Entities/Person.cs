using ISop.Domain.Common;
using ISop.Domain.Enums;

namespace ISop.Domain.Entities;

public class Person : BaseDomainEntity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public GenderEnum Gender { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string PhoneNumber { get; set; }
}