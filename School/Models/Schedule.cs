using School.Utils.Base;
using School.Utils.Abstracts.Models;

namespace School.Models;

public class Schedule : IBaseEntity
{
	public Guid Id { get; }
	public int GroupId { get; set; }
	public int TeacherId { get; set; }
	public int SubjectId { get; set; }
	public Group Group { get; set; }
	public Teacher? Teacher { get; set; }
	public Subject Subject { get; set; }
	public DayOfWeek DayOfWeek { get; set; }
	public TimeSpan StartsAt { get; set; }
	public TimeSpan FinishesAt { get; set; }
	public DateTime CreatedAt { get; }
	public DateTime UpdatedAt { get; }
}