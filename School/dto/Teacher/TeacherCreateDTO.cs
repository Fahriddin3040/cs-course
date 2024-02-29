using System.Text.RegularExpressions;
using School.Utils.Base;

namespace School.dto;

public class TeacherCreateDTO : BaseAbstractUserCreateDTO
{
	public Guid? GroupId { get; set; }
}