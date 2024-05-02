namespace GridTest.Server.Models
{
    public class RowGridFormElement
    {
        public IEnumerable<FieldFormElement> Cells { get; set; } = new List<FieldFormElement>();

        public string? Color { get; set; }
    }
}
