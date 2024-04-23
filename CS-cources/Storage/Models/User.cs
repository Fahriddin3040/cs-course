using System.Runtime.InteropServices.JavaScript;
using Storage.Utils.Abstractions.Models;


namespace Storage.Models;

public class User : BaseEntity
{
    public required string Username { get; set; }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public string? PhoneNumber { get; set; }
    public required string EmailAddress { get; set; }
    public required string Password { get; set; }
    public int Type { get; set; }
    public enum UserType
    {
        User = 0,
        Client = 1,
        StaffMember = 2,
        Admin = 3
    }
    
    public void ShowAttrs()
    {
        Console.WriteLine($"Id: {Id}");
        Console.WriteLine($"FirstName: {FirstName}");
        Console.WriteLine($"LastName: {LastName}");
        Console.WriteLine($"PhoneNumber: {PhoneNumber}");
        Console.WriteLine($"Type: {Type}");
        Console.WriteLine($"EmailAddress: {EmailAddress}");
        Console.WriteLine($"Password: {Password}");
    }

    public override string ToString()
    {
        return $"{this.FirstName} {this.LastName}";
    }
    
}