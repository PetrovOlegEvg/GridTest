namespace GridTest.Server.Models
{
    public class GridFormElement
    {
        public IEnumerable<HeaderGridFormElement> Header { get; set; } = new List<HeaderGridFormElement>();

        public IEnumerable<HeaderGridFormElement> FrozenColumns { get; set; } = new List<HeaderGridFormElement>();

        public IEnumerable<HeaderGridFormElement> ScrollableColumns { get; set; } = new List<HeaderGridFormElement>();

        public IEnumerable<RowGridFormElement> Rows { get; set; } = new List<RowGridFormElement>();

        public string? Id { get; set; }

        public string? Name { get; set; }

        public float FieldSize { get; set; }

        public bool IsGrid { get; } = true;

        public float Y { get; set; }

        public float Height { get; set; }

        public float FrozenWidth { get; set; }

        public float Space { get; set; } = 0;

        public string? Title { get; set; }

        public bool IsStaticGrid { get; set; }

        public bool IsBestFitGrid { get; set; }

        public bool IsWideScreenGrid { get; set; }

        public bool IsFullScreenGrid { get; set; }

        public bool LabelOnLeft { get; set; }
    }
}
