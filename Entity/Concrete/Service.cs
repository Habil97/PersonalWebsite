using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Service
    {
        [Key]
        public int ID { get; set; }
        public string Description{ get; set; }
        public string Title { get; set; }
        public string ImageURL { get; set; }
    }
}
