using Pistoladas.Models.Entities.Base;

namespace Pistoladas.Models.Entities.MethodModels.AnnotationModel
{
    public class CheckAnnotationIsValidatedResponse : IBaseResponse
    {
        public bool IsValidated { get; set; }
    }
}