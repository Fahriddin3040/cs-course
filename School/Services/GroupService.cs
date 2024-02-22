using School.DataBase;
using School.Models;
using School.Utils.Abstracts.Repositories;
using School.Utils.Abstracts.Services;
using School.Utils.Base;

namespace School.Services;

public class GroupService : BaseService<Group>
{
    public GroupService(ISqlRepository<Group> sqlRepository) : base(sqlRepository){}
}