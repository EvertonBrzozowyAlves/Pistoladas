using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Pistoladas.Data.Providers.Dapper;
using Pistoladas.Models.Entities.MethodModels.Annotation;

namespace Pistoladas.Data.Annotation.Implementations
{
    public class AnnotationData : DataBaseOperationsDapper, IAnnotationData
    {
        private readonly ILogger<AnnotationData> _logger;
        
        public AnnotationData(ILogger<AnnotationData> logger)
        {
            _logger = logger;
        }
        
        public async Task<GetByIdResponse> GetById(GetByIdRequest request)
        {
            try
            {
                var response = await GetSingleOrDefaultAsync<GetByIdResponse>($"PROC_ANNOTATIONS_{nameof(GetById)}", request);
                return response;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                throw;
            }
        }

        public async Task<AddResponse> Add(AddRequest request)
        {
            try
            {
                var response = await AddAsync<AddResponse>($"PROC_ANNOTATIONS_{nameof(Add)}", request);
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