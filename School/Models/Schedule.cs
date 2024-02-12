using System.Security.Cryptography;
using Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure;
using School.Utils.Base.Models;

namespace School.Models;

public class Schedule : IBaseEntity
{
	public Guid Id { get; }
	public Group Group { get; set; }
	public Teacher? Teacher { get; set; }
	public Subject Subject { get; set; }
	public DayOfWeek DayOfWeek { get; set; }
	public TimeSpan StartsAt { get; set; }
	public TimeSpan FinishesAt { get; set; }
	public DateTime CreatedAt { get; }
	public DateTime UpdatedAt { get; }
}