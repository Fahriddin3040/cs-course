using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure;
using School.Utils.Base.Models;

namespace School.Models;

public class Student : AbstractUser
{
	public Trustee Trustee { get; set; }
	public Group Group { get; set; }
}