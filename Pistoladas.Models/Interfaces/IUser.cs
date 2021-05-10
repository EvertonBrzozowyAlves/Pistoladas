using System.Collections.Generic;
using System.Threading.Tasks;
using Pistoladas.Models.Entities.MethodModels.User;

namespace Pistoladas.Models.Interfaces
{
    public interface IUser
    {
        Task<GetByIdResponse> GetById(GetByIdRequest request);
        Task<IEnumerable<GetAllActiveResponse>> GetAllActive(GetAllActiveRequest request);
        Task<AddResponse> Add(AddRequest request);
        Task<GetActiveCountResponse> GetActiveCount(GetActiveCountRequest request);


    }
}