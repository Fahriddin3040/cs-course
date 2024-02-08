namespace School.Utils.Abstracts.Models;

public interface IBaseEntity: ITimeStampble
{
	public Guid Id { get; }
}
