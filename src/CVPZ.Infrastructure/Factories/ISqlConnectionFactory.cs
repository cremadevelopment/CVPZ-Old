using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace CVPZ.Infrastructure.Factories
{
    public interface ISqlConnectionFactory
    {
        SqlConnection SqlConnection();
    }
}
