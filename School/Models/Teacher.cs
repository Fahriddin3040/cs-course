using School.Utils.Base.Models;

namespace School.Models;

public class Teacher : AbstractUser
{
	public Group? Group { get; set; }
	public ICollection<Subject>? Subjects { get; set; }
	public ICollection<Schedule>? Schedules { get; set; }
}