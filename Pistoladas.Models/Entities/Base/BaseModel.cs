using System;

namespace Pistoladas.Models.Entities.Base
{
    public abstract class BaseModel
    {
        public bool IsActive { get; set; }
        public DateTime RegisterDate { get; set; }
    }
}
