using Pistoladas.Models.Entities.Base;

namespace Pistoladas.Models.Entities.MethodModels.Annotation
{
    public class CheckAnnotationIsValidatedResponse : IBaseResponse
    {
        public bool IsValidated { get; set; }
    }
}