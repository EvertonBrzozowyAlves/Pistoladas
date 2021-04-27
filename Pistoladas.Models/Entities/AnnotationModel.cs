﻿using System;
using Pistoladas.Models.Entities.Base;
using Pistoladas.Models.Enums;

namespace Pistoladas.Models.Entities
{
    public abstract class AnnotationModel : BaseModel
    {
        public Guid AnnotationId { get; set; }
        public Guid VictimUserId { get; set; }
        public Guid AccuserUserId { get; set; }
        public AnnotationLevelEnum AnnotationLevel { get; set; }
        public string Description { get; set; }
        public int Votes { get; set; }
    }
}
