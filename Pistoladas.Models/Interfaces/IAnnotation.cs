using System.Collections.Generic;
using System.Threading.Tasks;
using Pistoladas.Models.Entities.MethodModels.AnnotationModel;

namespace Pistoladas.Models.Interfaces
{
    public interface IAnnotation
    {
        Task<AnnotationGetByIdResponse> GetById(AnnotationGetByIdRequest request);
        Task<AnnotationAddResponse> Add(AnnotationAddRequest request);

        // Task<IEnumerable<AnnotationsGetAllResponse>> GetAll(AnnotationsGetAllRequest request);
        // Task<IEnumerable<AnnotationsGetAllValidatedResponse>> GetAll(AnnotationsGetAllValidatedRequest request);
    }
}