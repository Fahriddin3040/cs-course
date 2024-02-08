using School.Accounts.Models;

namespace School.utils.Abstracts.Models;

public interface IAuditable
{
	AbstractUser CreatedBy { get; set; }
	AbstractUser UpdatedBy {get; set;}
}
