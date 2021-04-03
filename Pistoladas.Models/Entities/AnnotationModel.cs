using Pistoladas.Models.Entities.Base;
using Pistoladas.Models.Enums;

namespace Pistoladas.Models.Entities
{
    public class AnnotationModel : BaseModel
    {
        public AnnotationModel()
        {
        }

        public AnnotationModel(AnnotationLevelEnum annotationLevel, long userId, string description, int votes, bool isValidated)
        {
            AnnotationLevel = annotationLevel;
            UserId = userId;
            Description = description;
            Votes = votes;
            IsValidated = isValidated;
        }

        public AnnotationLevelEnum AnnotationLevel { get; set; }
        public long UserId { get; set; }
        public string Description { get; set; }
        public int Votes { get; set; }
        public bool IsValidated { get; set; }

    }
}
