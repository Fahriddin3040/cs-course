using School.Utils.Abstracts.Models;
using School.Journal.Models;

namespace School.Models.UserTypes;

public class Teacher: IBaseEntity
{
	public Guid Id { get; set; }
	public ICollection<Subject> Subjects { get; set; }
	public DateTime CreatedAt { get; }
	public DateTime UpdatedAt { get; }
}

