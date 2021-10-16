using System;

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
