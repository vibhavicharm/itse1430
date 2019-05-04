using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nile.Stores.Sql
{
    public class SqlNileStores :IProductDatabase
    {
        public SqlNileStores( string connectionString )
        {
            _connectionString = connectionString;
        }

        private readonly string _connectionString;
    }
}
