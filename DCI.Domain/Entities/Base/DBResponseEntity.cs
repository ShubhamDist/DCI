namespace DCI.Domain.Entities.Base
{
    public class DBResponseEntity
    {
        public int IsSuccess { get; set; }
        public string? ErrorMessage { get; set; }
        public int ResponseId { get; set; }
    }
}
