using School.Models.UserTypes;
using School.Utils.Abstracts.Models;


namespace School.Accounts.Models;

public class User: IBaseEntity
{
	public Guid Id { get; set; }
	public string Username { get; set; }
	public string FirstName { get; set; }
	public string LastName { get; set; }
	public string PhoneNumber { get; set; }
	public string Address { get; set; }
	public int Age { get; set; }
	public DateTime CreatedAt { get; }
	public DateTime UpdatedAt { get; }
	public bool IsAdmin = false;
    public enum userType
    {
		Admin = 1, 
		Teacher = 2,
		Student = 3,
		Trustee = 4
	}
}