using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManager.sql
{
    public class SqlGameDatabase : GameDatabase
    {
        public SqlGameDatabase(string cinnectionString)
        {
            var _connectionString = connectionString;
        }

        private readonly string _connectionString;

        public object connectionString { get; private set; }

        protected override Game AddCore( Game game )
        {
            using (var connection = GetConnection())
            {
                connection.Open();

                
                var cmd = connection.CreateCommand();
                cmd.CommandText = "AddGame";
                //add something here
                //var cmd = new SqlCommand("", connection); //same thing does as above two lines


                // Add parameter 1 - long way when you need control over parameter
                var parameter = new SqlParameter("@name", System.Data.SqlDbType.NVarChar);
                parameter.Value = game.Name;
                cmd.Parameters.Add(parameter);

                // Add parameter 2 - quick way when you just need type/value
                cmd.Parameters.AddWithValue("@description", game.Description);
                cmd.Parameters.AddWithValue("@price", game.Price);
                cmd.Parameters.AddWithValue("@completed", game.Completed);
                cmd.Parameters.AddWithValue("@owned", game.Owned);

                //To execute
                // (int)cmd.ExecuteScalar();
                // cmd.ExecuteScalar() as int;  //reference types 
                var result = Convert.ToInt32(cmd.ExecuteScalar());

                game.id = result;
                return game;
            };

            
            throw new NotImplementedException();
        }

        private object GetConnection()
        {
            return new NotImplementedException();
        }

        protected override void DeleteCore( int id )
        {
            using (var connection = GetConnection())
            {
                connection.Open();


                var cmd = connection.CreateCommand();
                cmd.CommandText = "AddGame";
                //add something here
                //var cmd = new SqlCommand("", connection); //same thing does as above two lines


                
                cmd.Parameters.AddWithValue("@id", id);

                //No result
                cmd.ExecuteNonQuery();
            };


            throw new NotImplementedException();
        }

        protected override IEnumerable<Game> GetAllCore()
        {
            var ds = new DataSet();

            using (var conn = GetConnection())
            {
                var cmd = new SqlCommand("GetGames", conn);
                cmd.CommandTupe = System.Data.CommandType.StoredProcedure;

                
                var da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                //DataColumn.SelectCommand = cmd;
                //DataColumn.Fill(ds);
                da.Fill(ds);

                //If you want to update
                //da.Update(ds);
            };
            //Disconnected from DB
            //ds.Tables[0].Rows[0][0] = "Old";
            //ds.Tables[0].Rows[0]["Name"] = "Old";

            var table = ds.Tables.OfType<DataTable>().FirstOrDefault();
            if(table != null)
            {
                return from r in table.Rows.OfType<DataRow>()
                       select new Game() {
                           Id = Convert.ToInt32(r[0]), // Ordinal, convert - first option is using index. but zero based index is not a good thing
                           Name = r["Name"].ToString(), // By name, convert - second approach - we can go with the names of the columns
                           Description = r.IsNull("description") ? "": r["description"].ToString(), // handle DB nulls - this is not .NET null.
                           Price = r.Field<decimal>("Price"), //this does exact same thing as Id row
                           Owned = r.Field<bool>("Owned"), //boolian 
                           Completed = r.Field<bool>("Completed"),
                       };
            };

            return Enumerable.Empty<Game>();
        }

        protected override Game GetCore( int id )
        {
            using (var conn = GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "GetGames";
                cmd.CommandType = CommandType.StoredProcedure;

                conn.Open();

                var reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    var gameId = reader.GetInt32(0); 
                    if(gameId == id)
                    {
                         

                        return new Game() {
                            Id = gameId,
                            Name = reader.GetString(reader, "Name"),
                            Description = reader.GetString(reader, "Description"),
                            Price = reader.GetFieldValue<decimal>(3),
                            Owned = Convert.ToBoolean(reader.GetValue(4)),
                            Completed = Convert.ToBoolean(reader.GetValue(5)),
                        };
                    }
                };
            };
            return null;
        }

        private string GetString( IDataReader reader )
        {
            var ordinal = reader.GetOrdinal("Name"); //You can do this if you want.

            if (reader.IsDBNull(ordinal))
                return "";
            return reader.GetString(ordinal);
        }

        protected override Game UpdateCore( int id, Game game )
        {
            using (var connection = GetConnection())
            {
                connection.Open();


                var cmd = connection.CreateCommand();
                cmd.CommandText = "UpdateGame";
                //add something here
                //var cmd = new SqlCommand("", connection); //same thing does as above two lines


                // Add parameter 1 - long way when you need control over parameter
                var parameter = new SqlParameter("@name", System.Data.SqlDbType.NVarChar);
                parameter.Value = game.Name;
                cmd.Parameters.Add(parameter);

                // Add parameter 2 - quick way when you just need type/value
                cmd.Parameters.AddWithValue("@description", game.Description);
                cmd.Parameters.AddWithValue("@price", game.Price);
                cmd.Parameters.AddWithValue("@completed", game.Completed);
                cmd.Parameters.AddWithValue("@owned", game.Owned);
                cmd.Parameters.AddWithValue("@id", id);

                //No result
                cmd.ExecuteNonQuery();
            };


            return game;
        }

        private class SqlConnection
        {
            public SqlConnection()
            {
            }

            internal void Open()
            {
                throw new NotImplementedException();
            }
        }
    }

    internal class SqlCommand
    {
        internal CommandType CommandTupe;
        private string v;
        private object connection;

        public SqlCommand( string v, object connection )
        {
            this.v = v;
            this.connection = connection;
        }

        public static implicit operator System.Data.SqlClient.SqlCommand( SqlCommand v )
        {
            throw new NotImplementedException();
        }
    }
}

/* April 10, 2019 - Dataset
 * Dataset - you can load data in to dataset and work with it
 * Table -> Data Table[] - Columns[]<- DataColumn <- Name Type
 *                       - Rows[] <- DataRow
 * So, column in your table will be the id, name and description
 * DataRow is an object[]
 * get the name from the row you will go to the second column
 * if you mouse over the ds then click the magnifying glass then the table will be shown with data on it.
 * order is not quiry.
 * columns have name.. rows do not. rows go numbers(iThink)
 * data adapters can read any data from the program. dataSets are design for search and get the results. you can get anything from datasets. datasets are selfaware.
 * you can get whatever you want from data set. like type of the data value of data etc.
 * 
 * 6 steps - 1) Create the dataSet
 * 2) Create adapter
 * 3) Set command
 * 4) Fill
 * 5) Get Table
 * 6) <- rows
 * 
 * if there is a problem go to the solution explorer -> store Procedures then type "SET NOCOUNT ON;" if this is not already there. then add your Id on SELECT row 
 * 
 * ExecuteNonQuery(cmd) - Update and Delete
 * ExecuteScalar(cmd) -> object - I
 */

/* April 15, 2019 - Reading Data 2(not a Dataset)
 * Reader stream the data from the
 * reader can read data from the one by one or anyway but you have to write the code
 * once you move on from the row you cannot go back. it is only forward
 * if you can get database errore you can add this add ; if (reader.IsDBNull(ordinal))
                                                            return "";
 * the errors could be database errors not the .NET errors
 * data readers vs datasets;
 * 
 * dataSets
 *  Modifuble
 *  Multi-table relations
 *  discoverable
 *  disconnected
 *  Slow
 *  large memory
 *  100 rows are ok for datasets, but above 100 rows tables are probably not good for datasets
 *  fixed objects
 *  readAll the lines 
 *  
 * dataReaders
 *  Read Only
 *  Row based
 *  Not discoverable/ only the column name and type of the colum data
 *  connected
 *  Fastest
 *  small memory
 *  business objects
 *  you can get "preferred" lines because you load one row at a time. 
 *  
 */

/* Review 2
 * Action<T> = void action(T)
 * Func<T> = T func()
 * Func<S,T> = T func(s)
 * Delegete is s function type
 * 
 * What is interface implementation?
 *  public class Foo: IDisposable{ public void Dispose(){}
 *     void IDisposable.Ber(){}
 *  }
 *  
 * Creating an instance of a generic type - new List<string>
 * 
 * LINQ qurries always returns IEnum<T> except; 
 *  To - tocovert
 *  Single
 *  First
 *  Last
 *  
 * List<T> and Collection<T>
 *  List <T> always use for fields, and for private side
 *  public side, returning collection types you use collection<T>
 * 
 * from
 * where
 * orderby
 * select
 * if you are doing extension methods you start with from.
 * then the rest is you can do whatever way
 * 
 * try{threw new IOE();}catch Et
 * 
 * ErrorProvider;
 *  set: SetError(ctrl,msg)
 *  clear: SetError(ctrl,"")
 * 
 */
