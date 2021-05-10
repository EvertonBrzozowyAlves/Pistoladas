using System;
using Pistoladas.Models.Entities.Base;
using Pistoladas.Models.Enums;

namespace Pistoladas.Models.Entities
{
    public abstract class AnnotationVotesPropertiesModel : BasePropertiesModel
    {
        public Guid AnnotationVotesId { get; set; }
        public Guid AnnotationId { get; set; }
        public Guid VotingUserId { get; set; }
    }
}
