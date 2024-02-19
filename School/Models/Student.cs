using School.Utils.Abstracts.Models;

namespace School.Models;

public class Student : AbstractUser
{
	public Guid? GroupId { get; set; }
	public Guid? TrusteeId { get; set; }
	public Trustee? Trustee { get; set; }
	public Group? Group { get; set; }
}