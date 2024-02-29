using School.Utils.Base;
using System;

namespace School.Utils.Abstracts.Models
{
	public abstract class AbstractUser : IBaseEntity
	{
		public Guid Id { get; }
		public string? Username { get; set; }
		public string? FirstName { get; set; }
		public string? LastName { get; set; }
		public string? PhoneNumber { get; set; }
		public string? Address { get; set; }
		public int Age { get; set; }
		public string? Email { get; set; }
		public DateTime? CreatedAt { get; }
		public DateTime? UpdatedAt { get; }

		public void ShowInfo()
		{
			string fullName = $"{FirstName} {LastName}";
			string auditable = $"Created at: {CreatedAt} Updated at: {UpdatedAt}";

			Console.WriteLine($"{fullName}\n{auditable}");
		}
	}
}
