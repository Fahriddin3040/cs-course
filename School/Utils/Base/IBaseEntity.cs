using School.Utils.Abstracts.Models;

namespace School.Utils.Base;

public interface IBaseEntity: ITimeStampble
{
	Guid Id { get; }
}
