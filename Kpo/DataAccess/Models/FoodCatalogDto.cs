using System.Collections.Generic;
using System.Xml.Serialization;

namespace Kpo.DataAccess.Models
{
    [XmlRoot("catalog")]
    public class FoodCatalogDto
    {
        [XmlElement("category")]
        public List<CategoryDto> Categories { get; set; }
    }
}