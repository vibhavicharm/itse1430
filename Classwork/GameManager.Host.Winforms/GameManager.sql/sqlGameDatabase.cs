using System;
using System.Collections.Generic;
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


                // Add parameter 1
                var parameter = new SqlParameter("@name", System.Data.SqlDbType.NVarChar);
                parameter.Value = game.Name;
                cmd.Parameters.Add(parameter);

                // Add parameter 2
                cmd.Parameters.AddWithValue("@description", game.Description);
                cmd.Parameters.AddWithValue("@price", game.Price);
                cmd.Parameters.AddWithValue("@completed", game.Completed);
                cmd.Parameters.AddWithValue("@owned", game.Owned);

                // To execute command. there are several methods
                var result = (int)cmd.ExecuteScalar();

                game.Id = result;
                return game;
            };

            
            throw new NotImplementedException();
        }

        private object GetConnection()
        {
            throw new NotImplementedException();
        }

        protected override void DeleteCore( int id )
        {
            throw new NotImplementedException();
        }

        protected override IEnumerable<Game> GetAllCore()
        {
            //throw new NotImplementedException();
            return Enumerable.Empty<Game>();
        }

        protected override Game GetCore( int id )
        {
            //throw new NotImplementedException();
            return null;
        }

        protected override Game UpdateCore( int id, Game newGame )
        {
            throw new NotImplementedException();
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
        private string v;
        private object connection;

        public SqlCommand( string v, object connection )
        {
            this.v = v;
            this.connection = connection;
        }
    }
}
