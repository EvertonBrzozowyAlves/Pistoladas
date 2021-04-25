using Pistoladas.Models.Entities.Base;
using Pistoladas.Models.Enums;

namespace Pistoladas.Models.Entities
{
    public abstract class AnnotationModel : BaseModel
    {
        public AnnotationLevelEnum AnnotationLevel { get; set; }
        public long UserId { get; set; }
        public string Description { get; set; }
        public int Votes { get; set; }
        public bool IsValidated { get; set; }
    }
}
