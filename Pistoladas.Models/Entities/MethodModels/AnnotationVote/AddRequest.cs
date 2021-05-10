using System;
using Pistoladas.Models.Entities.Base;

namespace Pistoladas.Models.Entities.MethodModels.AnnotationVote
{
    public class AddRequest : IBaseRequest
    {
        public Guid AnnotationId { get; set; }
        public Guid VotingUserId { get; set; }
    }
}