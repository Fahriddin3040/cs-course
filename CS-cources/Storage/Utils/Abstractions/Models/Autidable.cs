using Storage.Models;

namespace Storage.Utils.Abstractions.Models;

public abstract class Auditable
{
	public User CreatedBy {get; set;}
	public User UpdatedBy {get; set;}
	public DateTime CreatedAt {get; set;}
	public DateTime UpdatedAt { get; set; }

}
