namespace School.Utils.Base.Models;

public interface IBaseEntity: ITimeStampble
{
	Guid Id { get; }
}
