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
            await using var connection = this.NewConnection();
            return await connection.QuerySingleOrDefaultAsync<T>(query, param, commandType: CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<T>> ListAsync(string query)
        {
            await using var connection = this.NewConnection();
            return await connection.QueryAsync<T>(query, commandType: CommandType.StoredProcedure);
        }

        public async Task<long> ExecuteNonQueryAsync(string query, RequestModel param)
        {
            await using var connection = this.NewConnection();
            return await connection.ExecuteAsync(query, param, commandType: CommandType.StoredProcedure);
        }
    }
}
