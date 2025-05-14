using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parnada_Appsdev.Repository
{
    public class ConnectionString
    {
        public static string GetConnectionString()
        {
            return "Data Source=LAPTOP-T6036KOA\\SQLEXPRESS;Initial Catalog=Enrollment;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
        }
    }
}
