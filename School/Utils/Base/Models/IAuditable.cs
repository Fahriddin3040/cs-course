using School.Models;

namespace School.Utils.Base.Models;

public interface IAuditable
{
	AbstractUser CreatedBy { get; }
    AbstractUser UpdatedBy { get; }

}
