using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Pistoladas.Data.Providers.Dapper;
using Pistoladas.Models.Entities.MethodModels.AnnotationModel;

namespace Pistoladas.Data.Annotation.Implementations
{
    public class AnnotationData : DataBaseOperationsDapper, IAnnotationData
    {
        private readonly ILogger<AnnotationData> _logger;
        
        public AnnotationData(ILogger<AnnotationData> logger)
        {
            _logger = logger;
        }
        
        public Task<AnnotationGetByIdResponse> GetById(AnnotationGetByIdRequest request)
        {
            throw new System.NotImplementedException();
        }

        public async Task<AnnotationAddResponse> Add(AnnotationAddRequest request)
        {
            try
            {
                var response = await AddAsync<AnnotationAddResponse>($"PROC_ANNOTATIONS_{nameof(Add)}", request);
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