namespace School.Utils.Abstracts.Models;

public interface ITimeStampble
{
	DateTime CreatedAt { get; }
	DateTime UpdatedAt { get; }
}