using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagement.Shared.BPResponse
{
    public class BPError : Exception
    {
        public int Code { get; set; }
        public string Messages { get; set; }
        public string Details { get; set; }
        public string ValidationErros { get; set; }
    }
}
