using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IOC.Interface;
using IOC.Model;
using Kogel.Dapper.Extension.MsSql;

namespace IOC.Factory
{
    public class RoleService : IRoleService
    {
        public IEnumerable<project_Role> GetRoleList()
        {
            //具体的实现
            using (var conn = new SqlConnection("server=172.16.3.60;user id=sa;password=sa;database=PermissionManage"))
            {
                return conn.QuerySet<project_Role>().ToList();
            }
        }
    }
}
