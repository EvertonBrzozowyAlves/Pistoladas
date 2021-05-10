using System;
using Pistoladas.Models.Entities.Base;

namespace Pistoladas.Models.Entities.MethodModels.AnnotationVote
{
    public class AddResponse : IBaseResponse
    {
        public Guid AnnotationVoteId { get; set; }
    }
}