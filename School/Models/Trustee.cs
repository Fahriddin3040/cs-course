using School.Utils.Base.Models;

namespace School.Models;

public class Trustee : AbstractUser
{
	public ICollection<Student> Students { get; set; }
	public string? Comment { get; set; }
}