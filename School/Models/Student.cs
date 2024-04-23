using System.Text.Json.Serialization;
using School.Utils.Abstracts.Models;

namespace School.Models;

public class Student : AbstractUser
{
	public Guid? GroupId { get; set; }
	public Guid? TrusteeId { get; set; }
	[JsonIgnore]
	public Trustee? Trustee { get; set; }
	[JsonIgnore]
	public Group? Group { get; set; }
}