namespace ConsoleAppRepporteur.Model
{
    [Serializable]
    public class RapporteurBase
    {
        public RapporteurBase()
        {
            Steps = new List<Steps_Model>();
            Categories = new List<object>();
            Tags = new List<object>();
        }

        public string? Name { get; set; }
        public string? DisplayName { get; set; }
        public string? Description { get; set; }
        public string? Author { get; set; }
        public string? Website { get; set; }
        public string? Version { get; set; }
        public bool IsSetupRecipe { get; set; }
        public List<object> Categories { get; set; }
        public List<object> Tags { get; set; }
        public List<Steps_Model> Steps { get; set; }
    }
    public class Steps_Model
    {
        public Steps_Model()
        {
            Data = new List<Data_Model>();
        }
        public string? Steps_Name { get; set; }
        public List<Data_Model> Data { get; set; }
    }
    
}

