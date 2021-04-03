using System;
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
        private readonly string _connectionString = Environment.GetEnvironmentVariable("CONNECTION_STRING");
        private SqlConnection NewConnection()
        {
            var sqlConnection = new SqlConnection(_connectionString);
            sqlConnection.Open();
            return sqlConnection;
        }

        protected async Task<BaseResponse> GetSingleOrDefaultAsync<BaseResponse>(string procedureName, BaseRequest param)
        {
            await using var connection = NewConnection();
            return await connection.QuerySingleOrDefaultAsync<BaseResponse>(procedureName, param, commandType: CommandType.StoredProcedure);
        }

        protected async Task<IEnumerable<BaseResponse>> ListAsync<BaseResponse>(string procedureName, BaseRequest param)
        {
            await using var connection = NewConnection();
            return await connection.QueryAsync<BaseResponse>(procedureName, param, commandType : CommandType.StoredProcedure);
        }

        protected async Task<BaseResponse> ExecuteNonQueryAsync(string procedureName, BaseRequest param)
        {
            await using var connection = NewConnection();
            await connection.ExecuteAsync(procedureName, param, commandType: CommandType.StoredProcedure);
            return new BaseResponse();
        }
    }
}
