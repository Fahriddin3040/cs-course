using School.DataBase;
using School.Models;
using School.Utils.Abstracts.Repositories;
using School.Utils.Base;

namespace School.Services;

public class SubjectService : BaseService<Subject>
{
	public SubjectService(ISqlRepository<Subject> sqlRepository) : base(sqlRepository){}
}