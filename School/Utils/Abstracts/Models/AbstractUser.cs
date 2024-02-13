using School.Utils.Base;
using System.ComponentModel.DataAnnotations;

namespace School.Utils.Abstracts.Models;

public abstract class AbstractUser: IBaseEntity
{
	public Guid Id { get; }
	public string Username { get; set; }
	public string FirstName { get; set; }
	public string LastName { get; set; }
	public string PhoneNumber { get; set; }
	public string Address { get; set; }
	public int Age { get; set; }
	public EmailAddressAttribute? Email { get; set; }
	public DateTime CreatedAt { get; }
	public DateTime UpdatedAt { get; }
	public void ShowInfo()
	{
		string fullName = $"{this.FirstName} {this.LastName}";
		string auditable = $"Created at: {this.CreatedAt} Updated at: {this.UpdatedAt}";

		Console.WriteLine($"{fullName}\n{auditable}");
	}
}
