using System.Text.Json.Serialization;
using School.Utils.Abstracts.Models;

namespace School.Models;

public class Teacher : AbstractUser
{
	public Guid? GroupId { get; set; }

	[JsonIgnore]
	public Group? Group { get; set; }
	
	[JsonIgnore]
	public List<TeachersSubjects>? Subjects { get; set; }
}