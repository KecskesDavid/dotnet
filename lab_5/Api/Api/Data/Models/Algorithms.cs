using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Data.Models
{
    public class Algorithms
    {
        public enum AlgorithmType
        {   
            Sorting, Searching, Backtracking
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public AlgorithmType Type { get; set; }
        public string Icon { get; set; }
        public string Url { get; set; }
        public string AlgorithmNickname { get; set; }
        public Boolean IsPublished { get; set; }
        public DateTime CreationDate { get; set; }

        public Algorithms(string name, string description, AlgorithmType type, string icon, string url, string algorithmNickname, bool isPublished, DateTime creationDate)
        {
            Name = name;
            Description = description;
            Type = type;
            Icon = icon;
            Url = url;
            AlgorithmNickname = algorithmNickname;
            IsPublished = isPublished;
            CreationDate = creationDate;
        }

        public void copy(Algorithms algorithms)
        {
            Name = algorithms.Name;
            Description = algorithms.Description;
            Type = algorithms.Type;
            Icon = algorithms.Icon;
            Url = algorithms.Url;
            AlgorithmNickname = algorithms.AlgorithmNickname;
            IsPublished = algorithms.IsPublished;
            CreationDate = algorithms.CreationDate;
        }
    }
}
