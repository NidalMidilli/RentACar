using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace EntityLayer
{
    public class Car
    {
        [Key]
        public int carId { get; set; }

        public string carName { get; set; }

        public string vehicleType { get; set; }
        public int Price { get; set; }

        public int Quantity { get; set; }

        public int Luggage { get; set; }

        public int Doors { get; set; }
        
        public int Passenger { get; set; }

        public int modelId { get; set; }

        public int categoryId { get; set; }
        public virtual Model Model { get; set; }

        public virtual ICollection<Category> Categories { get; set; }



       
    }
}
