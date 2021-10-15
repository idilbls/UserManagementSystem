using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagement.Shared.BPResponse
{
    public class BPPagedResult<T>
    {
        public int TotalCount { get; set; }
        public T Items { get; set; }
    }
}
