using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1_b.Model
{
    public class Drill
    {
        public List<string> IncludeComponenets { get; set; }
        public string InstallationMethod { get; set; }
        public string ItemWeight { get; set; }
        public string Manufactuerer { get; set; }
        public Material Material { get; set; }
        public IList<Material> Materials { get; set; }
        public string Note { get; set; }
        public string PackageDimensions { get; set; }
        public string PartNumber { get; set; }
        public string PowerSource { get; set; }
        public string Size { get; set; }
        public Speed Speed { get; set; }
        public IList<Speed> Speeds { get; set; }
        public string Tourque { get; set; }
        public Usage Usage { get; set; }

        public Drill(List<string> includeComponenets, string installationMethod, string itemWeight, string manufactuerer, Material material, IList<Material> materials, string note, string packageDimensions, string partNumber, string powerSource, string size, Speed speed, IList<Speed> speeds, string tourque, Usage usage)
        {
            IncludeComponenets = includeComponenets;
            InstallationMethod = installationMethod;
            ItemWeight = itemWeight;
            Manufactuerer = manufactuerer;
            Material = material;
            Materials = materials;
            Note = note;
            PackageDimensions = packageDimensions;
            PartNumber = partNumber;
            PowerSource = powerSource;
            Size = size;
            Speed = speed;
            Speeds = speeds;
            Tourque = tourque;
            Usage = usage;
        }
    }

    public enum Speed
    {
        Slow = 500,
        Medium = 1350,
        Fast = 1850,
    }

    public enum Material
    {
        Metal, Plastic, Titanium,
    }
}
