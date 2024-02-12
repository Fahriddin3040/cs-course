using School.Utils.Base.Models;

namespace School.Models;

public class Group : IBaseEntity 
{
	public Guid Id { get; }
	public Teacher? Curator { get; set; }
	public ICollection<Student> Students { get; set; }
	public ICollection<Schedule>? Schedules { get; set; }
	public DateTime CreatedAt { get; }
	public DateTime UpdatedAt { get; }
}
