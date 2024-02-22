using School.Models;
using School.Utils.Abstracts.Repositories;
using School.Utils.Base;

namespace School.Services;

public class TrusteeService : BaseService<Trustee>
{
	public TrusteeService(ISqlRepository<Trustee> sqlRepository): base(sqlRepository ?? throw new ArgumentNullException()){}
}
