using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Experience
    {
        [Key]
        public int ID { get; set; }
        public string Title { get; set; }
        public string Date { get; set; }
        public string ImageURL { get; set; }
        public string Description{ get; set; }
    }
}
