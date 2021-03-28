using Dapper;
using Pistoladas.Models.Entities.Base;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Pistoladas.Data.Providers.Dapper
{
    public class DataBaseOperationsDapper
    {
        private readonly string _connectionString = System.Environment.GetEnvironmentVariable("CONNECTION_STRING");

        private SqlConnection NewConnection()
        {
            var sqlConnection = new SqlConnection(_connectionString);
            sqlConnection.Open();
            return sqlConnection;
        }

        public async Task<BaseResponse> GetSingleOrDefaultAsync<BaseResponse>(string query, BaseRequest param)
        {
            await using var connection = NewConnection();
            return await connection.QuerySingleOrDefaultAsync<BaseResponse>(query, param, commandType: CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<BaseResponse>> ListAsync<BaseResponse>(string query, BaseRequest param)
        {
            await using var connection = NewConnection();
            return await connection.QueryAsync<BaseResponse>(query, param, commandType : CommandType.StoredProcedure);
        }

        public async Task<long> ExecuteNonQueryAsync(string query, BaseRequest param)
        {
            await using var connection = NewConnection();
            return await connection.ExecuteAsync(query, param, commandType: CommandType.StoredProcedure);
        }
    }
}
