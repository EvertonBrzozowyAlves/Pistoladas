using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Pistoladas.Data.Providers.Dapper;
using Pistoladas.Models.Entities.MethodModels.AnnotationVote;

namespace Pistoladas.Data.AnnotationVote.Implementations
{
    public class AnnotationVoteData : DataBaseOperationsDapper, IAnnotationVoteData
    {
        private readonly ILogger<AnnotationVoteData> _logger;
        
        public AnnotationVoteData(ILogger<AnnotationVoteData> logger)
        {
            _logger = logger;
        }
        
        public async Task<AddResponse> Add(AddRequest request)
        {
            try
            {
                var response = await AddAsync<AddResponse>($"PROC_AnnotationVotes_{nameof(Add)}", request);
                return response;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                throw;
            }
        }
    }
}