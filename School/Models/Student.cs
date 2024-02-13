using School.Utils.Abstracts.Models;

namespace School.Models;

public class Student : AbstractUser
{
	public Trustee Trustee { get; set; }
	public Group? Group { get; set; }
}