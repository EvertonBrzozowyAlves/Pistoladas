using System;
using Pistoladas.Models.Entities.Base;

namespace Pistoladas.Models.Entities.MethodModels.Annotation
{
    public class GetByIdRequest : IBaseRequest
    {
        public Guid AnnotationId { get; set; }
    }
}