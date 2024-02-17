using School.Utils.Abstracts.Models;

namespace School.Models;

public class Student : AbstractUser
{
	public int GroupId { get; set; }
	public int TrusteeId { get; set; }
	public Trustee Trustee { get; set; }
	public Group Group { get; set; }
}