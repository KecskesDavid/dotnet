namespace Api.Data.Models.DTO
{
    public class AlgorithmDTO
    {
        public AlgorithmDTO(int id, string name, string description, Algorithms.AlgorithmType type, string icon, string url, string algorithmNickname)
        {
            Id = id;
            Name = name;
            Description = description;
            Type = type;
            Icon = icon;
            Url = url;
            AlgorithmNickname = algorithmNickname;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Algorithms.AlgorithmType Type { get; set; }
        public string Icon { get; set; }
        public string Url { get; set; }
        public string AlgorithmNickname { get; set; }
    }
}
