namespace UserManagement.Shared.BPResponse
{
    public class BPJson<T>
    {
        public T Result { get; set; }
        public BPError Error { get; set; }
        public bool Success { get; set; }
        public string TargetUrl { get; set; }
        public bool UnauthorizedRequest { get; set; }
        public bool IsAbp { get; set; }
    }
}
