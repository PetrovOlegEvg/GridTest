namespace GridTest.Server.Models
{
    public class FieldFormElement
    {
        public string? Id { get; set; }

        public string? Name { get; set; }

        public int Index { get; set; }

        public bool Enabled { get; set; }

        public string? Value { get; set; }

        public bool Readonly { get; set; }

        public bool Active { get; set; }

        public bool Required { get; set; }

        public bool Validation { get; set; }

        public bool IsGrid { get; } = false;
    }
}
