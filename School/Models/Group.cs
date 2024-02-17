using School.Utils.Base;

namespace School.Models;

public class Group : IBaseEntity 
{
	public Guid Id { get; }
	public Teacher Curator { get; set; }
	public int CuratorId { get; set; }
	public List<Student> Students { get; set; }
	public ICollection<Schedule>? Schedules { get; set; }
	public DateTime CreatedAt { get; }
	public DateTime UpdatedAt { get; }
}

