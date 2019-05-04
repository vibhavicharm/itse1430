using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nile.Sql
{
    public class SqlNileDatabase : NileDatabase
    {
        public SqlNileDatabase(string connectionString )
        {
            _connectionString = connectionString;
        }

        private readonly string _connectionString;
    }

    protected override Product AddCore(Product product )
    {
        using (var connection = Getconnection())
        {
            connection.Open();

            var cmd = connection.CreateCommand();
            cmd.CommandText = "Add Product";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@name", product.Name);
            cmd.Parameters.AddWithValue("@description", product.Description);
            cmd.Parameters.AddWithValue("@price", product.Price);
            cmd.Parameters.AddWithValue("@discontined", product.IsDiscontinued);

            var result = Convert.ToInt32(cmd.ExecuteScalar());
            product.Id = result;
            return product;
        }
    }

    protected override Product UpdateCore( int id, Product product )
    {
        using (var connection = Getconnection())
        {
            connection.Open();

            var cmd = connection.CreateCommand();
            cmd.CommandText = "Update Product";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@name", product.Name);
            cmd.Parameters.AddWithValue("@description", product.Description);
            cmd.Parameters.AddWithValue("@price", product.Price);
            cmd.Parameters.AddWithValue("@discontined", product.IsDiscontinued);
            cmd.Parameters.AddWithValue("@id", id);

            cmd.ExecuteNonQuery();
        };
        return product;
    }

    protected override IEnumerable<Product> GetAllCore()
    {
        var ds = new DataSet();

        using (var conn = GetConnection())
        {
            var cmd = new SqlCommand("GetProducts", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            var da = new SqlDataAdapter();
            da.SelectCommand = cmd;

            da.Fill(ds);
         };

        var table = ds.Tables.OfType<DataTable>().FirstOrDefault();
        if (table != null)
        {
            return from r in table.Rows.OfType<DataRow>()
                   select new Product() {
                       Id = Convert.ToInt32(r[0]),  //Ordinal, convert
                       Name = r["Name"].ToString(), //By name, convert
                       Description = r.IsNull("description") ? "" : r["description"].ToString(), //handle DB nulls
                       Price = r.Field<decimal>("Price"),
                       IsDiscontinued = r.Field<bool>("Owned"),
                   };
        };

        return Enumerable.Empty<Game>();
    }
}

    private SqlConnection GetConnection()
    {
        return new SqlConnection(connectionString);
    }

    protected override Product GetCore( int id )
    {
        using (var conn = GetConnection())
        {
            var cmd = conn.CreateCommand();
            cmd.CommandText = "GetProducts";
            cmd.CommandType = CommandType.StoredProcedure;

            conn.Open();
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                var productId = reader.GetInt32(0);
                if (productId == id)
                {
                    return new Product() {
                        Id = productId,
                        Name = GetString(reader, "Name"),
                        Description = GetString(reader, "Description"),
                        Price = reader.GetFieldValue<decimal>(3),
                        IsDiscontinued = Convert.ToBoolean(reader.GetValue(4)),
                    };
                };
            };
        };
        return null;
    }

    private string GetString( IDataReader reader, string name )
    {
        var ordinal = reader.GetOrdinal(name);

        if (reader.IsDBNull(ordinal))
            return "";

        return reader.GetString(ordinal);
    }

}
