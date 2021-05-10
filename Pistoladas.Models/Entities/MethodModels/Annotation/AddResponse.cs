using System;
using Pistoladas.Models.Entities.Base;

namespace Pistoladas.Models.Entities.MethodModels.Annotation
{
    public class AddResponse : IBaseResponse
    {
        public Guid AnnotationId { get; set; }
    }
}