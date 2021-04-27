using System;
using Pistoladas.Models.Entities.Base;

namespace Pistoladas.Models.Entities.MethodModels.AnnotationModel
{
    public class AnnotationAddResponse : IBaseResponse
    {
        public Guid AnnotationId { get; set; }
    }
}