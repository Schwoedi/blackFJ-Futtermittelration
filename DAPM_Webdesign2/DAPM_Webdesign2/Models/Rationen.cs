namespace DAPM_Webdesign2.Models
{
    public class Rationen
    {
        // Ration.cs
        public class Ration
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public RationType Type { get; set; }
            public string Description { get; set; }
        }

        // Enums.cs
        public enum RationType
        {
            Huhn,
            Pute
        }
    }
}
