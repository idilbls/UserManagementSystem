using System;
using System.Collections.Generic;
using System.Text;

namespace UserManagement.Models.Entities.Core
{
    public abstract class BaseEntity
    {
        public BaseEntity()
        {
            this.IsActive = true;
        }

        public bool IsActive { get; set; }
        public DateTime CreationTime { get; set; }
    }
}
