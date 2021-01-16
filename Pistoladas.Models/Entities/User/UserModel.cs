using Pistoladas.Models.Entities.Base;

namespace Pistoladas.Models.Entities.User
{
    public class UserModel : BaseModel
    {
        public UserModel()
        {
        }

        public UserModel(string name, string email, string mobilePhone)
        {
            Name = name;
            Email = email;
            MobilePhone = mobilePhone;
        }

        public string Name { get; set; }
        public string Email { get; set; }
        public string MobilePhone { get; set; }
    }
}
