using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Project
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string ImageURL { get; set; }
        public string URL { get; set; }
        public string ImageURL2 { get; set; }
        public string Platform{ get; set; }
        public string PlatformImage { get; set; }
        public string Price{ get; set; }
        public int CompletionTime { get; set; }
        public bool Status { get; set; }

    }
}
