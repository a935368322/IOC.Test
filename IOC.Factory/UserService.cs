using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

using IOC.Interface;
using IOC.Model;

using Kogel.Dapper.Extension.MsSql;
using Kogel.Dapper.Extension.MsSql.Extension;

namespace IOC.Factory
{
    public class UserService : IUserService
    {
        public IEnumerable<users> GetUsersList()
        {
            //具体的实现
            using (var conn = new SqlConnection("server=172.16.3.60;user id=sa;password=sa;database=PermissionManage"))
            {
                return conn.QuerySet<users>().ToList();
            }
        }
    }
}
