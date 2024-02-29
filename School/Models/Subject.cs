using School.Utils.Base;

namespace School.Models;

public class Subject : IBaseEntity
{
	public Guid Id { get; }
	public string Title { get; set; }
	public string? Description { get; set; }
	public List<TeachersSubjects>? Teachers { get; set; }
	public string? HomeTask { get; set; }
	public DateTime? CreatedAt { get; set; }
	public DateTime? UpdatedAt { get; set; }
}