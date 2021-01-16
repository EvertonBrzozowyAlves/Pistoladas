using System;

namespace Pistoladas.Models.Entities.Base
{
    public abstract class BaseModel
    {
        protected BaseModel()
        {
            RegisterDate = DateTime.Now;
        }

        public long Id { get; set; }
        public DateTime RegisterDate { get; set; }
    }
}
