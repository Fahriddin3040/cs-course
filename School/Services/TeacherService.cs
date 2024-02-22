using School.DataBase;
using School.Models;
using School.Utils.Abstracts.Repositories;
using School.Utils.Abstracts.Services;
using School.Utils.Base;

namespace School.Services;

public class TeacherService : BaseService<Teacher>
{
    public TeacherService(ISqlRepository<Teacher> sqlRepository) : base(sqlRepository){}
}