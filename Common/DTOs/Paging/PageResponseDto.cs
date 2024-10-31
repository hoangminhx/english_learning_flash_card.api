namespace Common.DTOs.Paging
{
    public class PageResponseDto<T>
    {
        public IEnumerable<T>? Items { get; set; }
        public int Total { get; set; }
    }
}
