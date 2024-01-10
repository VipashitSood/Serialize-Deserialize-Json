namespace ConsoleAppRepporteur.Model
{
    public class Data_Model
    {
        public string? ContentItemId { get; set; }
        public string? ContentItemVersionId { get; set; }
        public string? ContentType { get; set; }
        public string? DisplayText { get; set; }
        public bool Latest { get; set; }
        public bool Published { get; set; }
        public DateTime ModifiedUtc { get; set; }
        public DateTime PublishedUtc { get; set; }
        public DateTime CreatedUtc { get; set; }
        public string? Owner { get; set; }
        public string? Author { get; set; }
        public Rapporteur Rapporteur { get; set; }
        public TitlePart TitlePart { get; set; }
    }
    public class TitlePart
    {
        public string? Title { get; set; }
    }
}
