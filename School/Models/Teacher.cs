using School.Utils.Abstracts.Models;

namespace School.Models;

public class Teacher : AbstractUser
{
	public Guid GroupId { get; set; }
	public Group? Group { get; set; }
	public List<Subject>? Subjects { get; set; }
}