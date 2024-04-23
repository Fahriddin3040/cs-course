namespace School.Models;

public class TeachersSubjects
{
	public Guid TeacherId { get; }
	public Guid SubjectId { get; set; }
	public Teacher Teacher { get; set; }
	public Subject Subject { get; set; }
}