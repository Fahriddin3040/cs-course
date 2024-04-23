using School.Utils.Abstracts.Models;

namespace School.Models;

public class Trustee : AbstractUser
{
	public List<Student> Students { get; set; }
	public string? Comment { get; set; }
}