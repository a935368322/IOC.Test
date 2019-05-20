﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IOC.Model;

namespace IOC.Interface
{
   public interface IRoleService
    {
        IEnumerable<project_Role> GetRoleList();
    }
}
