namespace ConsoleAppRepporteur.Model
{
    public class Rapporteur
    {
        public CommonData Name { get; set; }
        public CommonData Url { get; set; }
        public CommonData PoliticalParty { get; set; }
        public CommonData NationalParty { get; set; }
        public CommonData Nation { get; set; }
        public PublishedDate PublishedDate { get; set; }
    }
    //public class Name : CommonData
    //{
    //}

    //public class Url : CommonData
    //{
    //}

    //public class PoliticalParty : CommonData
    //{
    //}

    //public class NationalParty : CommonData
    //{
    //}

    //public class Nation : CommonData
    //{
    //}

    public class PublishedDate
    {
        public DateTime Value { get; set; }
    }
    public class CommonData
    {
        public string? Text { get; set; }
    }
}
