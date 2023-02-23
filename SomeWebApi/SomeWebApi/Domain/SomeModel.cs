namespace SomeWebApi.Domain
{
    public record SomeModel
    {
        public Guid Id { get; set; }

        public string SomeName { get; set; } = string.Empty;

        public int SomeNumber { get; set; }

        public DateTime SomeDate { get; set; }

        public SomeEnum SomeEnum { get; set; }
    }
}
