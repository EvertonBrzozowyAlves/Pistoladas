using System.Threading.Tasks;
using Pistoladas.Models.Entities.MethodModels.AnnotationVote;

namespace Pistoladas.Models.Interfaces
{
    public interface IAnnotationVote
    {
        Task<AddResponse> Add(AddRequest request);
        // Task<AnnotationVotesGetAllActiveByAnnotationIdResponse> GetAllActiveByAnnotationId(AnnotationVotesGetAllActiveByAnnotationIdRequest request);
        // Task<AnnotationVotesGetAllActiveCountByAnnotationIdResponse> GetAllActiveCountByAnnotationId(AnnotationVotesGetAllActiveCountByAnnotationIdRequest request);

    }
}