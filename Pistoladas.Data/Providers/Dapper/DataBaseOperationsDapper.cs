using Dapper;
using Pistoladas.Models.Entities.Base;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Pistoladas.Data.Providers.Dapper
{
    public class DataBaseOperationsDapper<T> where T : BaseModel
    {
        protected string _connectionString = System.Environment.GetEnvironmentVariable("CONNECTION_STRING");
        public SqlConnection NewConnection()
        {
            var sqlConnection = new SqlConnection(this._connectionString);
            sqlConnection.Open();
            return sqlConnection;
        }

        public T GetSingleOrDefault(string query, RequestModel param)
        {
            using (var connection = this.NewConnection())
            {
                var result = connection.QuerySingleOrDefault<T>(query, param, commandType: CommandType.StoredProcedure);
                return result;
            }
        }

        public List<T> List(string query)
        {
            using (var connection = this.NewConnection())
            {
                var result = connection.Query<T>(query, commandType: CommandType.StoredProcedure);
                var objectList = result?.ToList<T>();
                return objectList;
            }
        }

        public void ExecuteNonQuery(string query, RequestModel param)
        {
            using (var connection = this.NewConnection())
            {
                connection.Execute(query, param, commandType: CommandType.StoredProcedure);
            }
        }
    }
}
