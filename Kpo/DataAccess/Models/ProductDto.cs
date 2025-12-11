using System.Xml.Serialization;

namespace Kpo.DataAccess.Models
{
    public class ProductDto
    {
        [XmlElement("name")]
        public string Name { get; set; }

        [XmlElement("proteins")]
        public double Proteins { get; set; }

        [XmlElement("fats")]
        public double Fats { get; set; }

        [XmlElement("carbs")]
        public double Carbs { get; set; }

        [XmlElement("calories")]
        public double CaloriesPer100g { get; set; }
    }
}