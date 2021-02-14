using Dapper;
using Pistoladas.Models.Entities.Base;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Pistoladas.Data.Providers.Dapper
{
    public class DataBaseOperationsDapper<T> where T : BaseModel
    {
        private readonly string _connectionString = System.Environment.GetEnvironmentVariable("CONNECTION_STRING");

        private SqlConnection NewConnection()
        {
            var sqlConnection = new SqlConnection(this._connectionString);
            sqlConnection.Open();
            return sqlConnection;
        }

        public async Task<T> GetSingleOrDefaultAsync(string query, RequestModel param)
        {
            using (var connection = this.NewConnection())
            {
                return await connection.QuerySingleOrDefaultAsync<T>(query, param, commandType: CommandType.StoredProcedure);
            }
        }

        public async Task<IEnumerable<T>> List(string query)
        {
            using (var connection = this.NewConnection())
            {
                return await connection.QueryAsync<T>(query, commandType: CommandType.StoredProcedure);
            }
        }

        public async void ExecuteNonQueryAsync(string query, RequestModel param)
        {
            using (var connection = this.NewConnection())
            {
                await connection.ExecuteAsync(query, param, commandType: CommandType.StoredProcedure);
            }
        }
    }
}
