using School.Accounts.Models;

namespace School.utils.Abstracts.Models;

public interface IAuditable
{
	User CreatedBy { get; set; }
	User UpdatedBy {get; set;}
}
