namespace School.Utils.Base;

public abstract class AbstractUserUpdateDto
{
	public string? Username { get; set; }
	public string? FirstName { get; set; }
	public string? LastName { get; set; }
	public string? Email { get; set; }
	public string? Address { get; set; }
	public string? PhoneNumber { get; set; }
	public int? Age { get; set; }
}