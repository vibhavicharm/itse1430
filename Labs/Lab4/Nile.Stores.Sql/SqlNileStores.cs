using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nile.Stores.Sql
{
    public class SqlNileStores : ProductDatabase
    {
        public SqlNileStores( string connectionString )
        {
            _connectionString = connectionString;
        }

        private readonly string _connectionString;

        private System.Data.SqlClient.SqlConnection GetConnection()
        {
            return new System.Data.SqlClient.SqlConnection(_connectionString);
        }

        protected override Product GetCore( int id )
        {
            using (var conn = GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "GetProduct";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id", id);



            }
            return null;
        }

        protected override IEnumerable<Product> GetAllCore()
        {
            var ds = new System.Data.DataSet();

            using (var conn = GetConnection())
            {
                var cmd = new System.Data.SqlClient.SqlCommand("GetGames", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                var da = new System.Data.SqlClient.SqlDataAdapter();
                da.SelectCommand = cmd;

                da.Fill(ds);

            };

            //var table = ds.Tables.OfType<System.Data.DataTable>().FirstOrDefault();
            //if (table != null)
            //{
            //    return from r in table.Rows.OfType<System.Data.DataRow>()
            //           select new Product() {
            //               Id = Convert.ToInt32(r[0]),  //Ordinal, convert
            //               Name = r["Name"].ToString(), //By name, convert
            //               Description = r.IsNull("description") ? "" : r["description"].ToString(), //handle DB nulls
            //               Price = r.Field<decimal>("Price"),
            //               IsDiscontinued = r.Field<bool>("Discontinued"),

            //           };
            //};

            return Enumerable.Empty<Product>();
        }

        protected override void RemoveCore( int id )
        {
            using (var connection = GetConnection())
            {
                connection.Open();

                var cmd = connection.CreateCommand();
                cmd.CommandText = "DeleteProduct";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();
            };
        }

        protected override Product UpdateCore( Product existing, Product newItem )
        {
            using (var connection = GetConnection())
            {
                connection.Open();

                var cmd = connection.CreateCommand();
                cmd.CommandText = "UpdateProduct";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                //Add parameter 1 - long way when you need control over parameter
                var parameter = new System.Data.SqlClient.SqlParameter("@name", System.Data.SqlDbType.NVarChar);
                parameter.Value = newItem.Name;
                cmd.Parameters.Add(parameter);

                //Add parameter 2 - quick way when you just need type/value
                cmd.Parameters.AddWithValue("@description", newItem.Description);
                cmd.Parameters.AddWithValue("@price", newItem.Price);
                cmd.Parameters.AddWithValue("@completed", newItem.IsDiscontinued);
                cmd.Parameters.AddWithValue("@id", existing);

                //No results
                cmd.ExecuteNonQuery();
            };

            return newItem;
        }

        protected override Product AddCore( Product product )
        {
            using (var connection = GetConnection())
            {
                connection.Open();

                var cmd = connection.CreateCommand();
                cmd.CommandText = "AddProduct";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                var parameter = new System.Data.SqlClient.SqlParameter("@name", System.Data.SqlDbType.NVarChar);
                parameter.Value = product.Name;
                cmd.Parameters.Add(parameter);

                var result = Convert.ToInt32(cmd.ExecuteScalar());

                product.Id = result;
                return product;
            }
        }

    }
}
