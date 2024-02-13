using School.Models;

namespace School.Utils.Abstracts.Models;

public interface IAuditable
{
	AbstractUser CreatedBy { get; }
    AbstractUser UpdatedBy { get; }

}
