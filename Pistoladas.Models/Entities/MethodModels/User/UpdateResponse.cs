using Pistoladas.Models.Entities.Base;

namespace Pistoladas.Models.Entities.MethodModels.User
{
    public class UpdateResponse : IBaseResponse
    {
        public int AffectedRows { get; set; }
    }
}
