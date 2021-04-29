using System.Threading.Tasks;
using Pistoladas.Models.Entities.MethodModels.AnnotationModel;
using Pistoladas.Models.Interfaces;

namespace Pistoladas.Business.Annotations
{
    public interface IAnnotationsBusiness : IAnnotation
    {
        Task<CheckAnnotationIsValidatedResponse> CheckAnnotationIsValidated(CheckAnnotationIsValidatedRequest request);
    }
}
