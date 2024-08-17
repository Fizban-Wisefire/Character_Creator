using Entities;

namespace WebAPI
{
    public class RaceAPI
    {
        public string Name { get; set; }
        public string Resource { get; set; }
        public string Description { get; set; }
        public int Str { get; set; }
        public int Dex { get; set; }
        public int Con { get; set; }
        public int Wis { get; set; }
        public int Int { get; set; }
        public int Cha { get; set; }
        public string Age { get; set; }
        public string Size { get; set; }
        public int Speed { get; set; }
        public List<RaceDescriptionFeature> DescriptionFeatures { get; set; }
        public List<RaceMechanicFeature> MechanicFeatures { get; set; }

    }
}
