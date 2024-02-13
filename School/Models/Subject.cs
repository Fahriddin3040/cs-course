namespace School.Models;

public class Subject
{
	public Guid Id { get; }
	public string Title { get; set; }
	public string? Description { get; set; }
	public ICollection<Teacher>? Teachers { get; set; }
	public string? HomeTasks { get; set; }
}