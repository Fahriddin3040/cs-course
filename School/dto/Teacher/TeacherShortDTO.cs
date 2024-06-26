namespace School.dto;

public class TeacherShortDTO
{
	public Guid Id { get; set; }
	public string FullName { get; set;}
	public string? PhoneNumber { get; set; }
	public string? Email { get; set; }
	public Guid? GroupId { get; set; }
}