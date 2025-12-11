using System.Collections.Generic;
using System.Xml.Serialization;

namespace Kpo.DataAccess.Models
{
    public class CategoryDto
    {
        [XmlElement("name")]
        public string Name { get; set; }

        [XmlArray("products")]
        [XmlArrayItem("product")]
        public List<ProductDto> Products { get; set; }
    }
}