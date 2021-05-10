using System.Threading.Tasks;
using Pistoladas.Models.Entities.MethodModels.Annotation;
using Pistoladas.Models.Interfaces;

namespace Pistoladas.Business.Annotations
{
    public interface IAnnotationsBusiness : IAnnotation
    {
        Task<CheckAnnotationIsValidatedResponse> CheckIfAnnotationIsValidated(CheckAnnotationIsValidatedRequest request);
    }
}
