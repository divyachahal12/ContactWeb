using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactWeb.Data
{
    public interface IUserRolesService
    {
        Task EnsureAdminUserRole();
    }
}
