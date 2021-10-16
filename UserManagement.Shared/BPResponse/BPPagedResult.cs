namespace UserManagement.Shared.BPResponse
{
    public class BPPagedResult<T>
    {
        public int TotalCount { get; set; }
        public T Items { get; set; }
    }
}
