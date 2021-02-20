﻿using Pistoladas.Models.Entities.Base;

namespace Pistoladas.Models.Entities.User
{
    public class UserUpdateRequestModel : RequestModel
    {
        public long UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string MobilePhone { get; set; }
    }
}