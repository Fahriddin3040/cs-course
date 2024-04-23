using School.Models;
using School.Utils.Abstracts.Repositories;
using School.Utils.Base;

namespace School.Services;

public class StudentService : BaseService<Student>
{
	public StudentService(ISqlRepository<Student> sqlRepository) : base(sqlRepository){}
}