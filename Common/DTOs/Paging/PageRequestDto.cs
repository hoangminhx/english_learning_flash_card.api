namespace Common.DTOs.Paging
{
    public record PageRequestDto
    {
        public int Page { get; set; } = 0;
        public int PageSize { get; set; } = 10;
    }
}
