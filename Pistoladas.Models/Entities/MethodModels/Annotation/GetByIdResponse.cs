using System;
using Pistoladas.Models.Entities.Base;
using Pistoladas.Models.Enums;

namespace Pistoladas.Models.Entities.MethodModels.Annotation
{
    public class GetByIdResponse : IBaseResponse
    {
        public Guid AnnotationId { get; set; }
        public bool IsActive { get; set; }
        public DateTime RegisterDate { get; set; }
        public Guid VictimUserId { get; set; }
        public Guid AccuserUserId { get; set; }
        public AnnotationLevelEnum AnnotationLevel { get; set; }
        public string Description { get; set; }
    }
}