using System.Threading.Tasks;
using Pistoladas.Models.Entities.MethodModels.Annotation;

namespace Pistoladas.Models.Interfaces
{
    public interface IAnnotation
    {
        Task<GetByIdResponse> GetById(GetByIdRequest request);
        Task<AddResponse> Add(AddRequest request);

        // Task<IEnumerable<AnnotationsGetAllResponse>> GetAll(AnnotationsGetAllRequest request);
        // Task<IEnumerable<AnnotationsGetAllValidatedResponse>> GetAll(AnnotationsGetAllValidatedRequest request);
    }
}