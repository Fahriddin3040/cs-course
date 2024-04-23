using School.Utils.Base;

namespace School.dto;

public class StudentUpdateDTO: AbstractUserCreateDto
{
	public Guid? GroupId { get; set; }
	public Guid? TrusteeId { get; set; }
}