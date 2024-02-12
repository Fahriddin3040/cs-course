namespace School.Utils.Base.Models;

public interface ITimeStampble
{
	DateTime CreatedAt { get; }
	DateTime UpdatedAt { get; }
}