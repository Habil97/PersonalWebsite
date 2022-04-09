using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Testimonial
    {
        [Key]
        public int ID { get; set; }
        public string Name{ get; set; }
        public string Appellation { get; set; }
        public string Comment { get; set; }
        public string ImageURL { get; set; }
    }
}
