﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class SocialMedia
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string URL{ get; set; }
        public string Icon{ get; set; }
        public bool Status { get; set; }
    }
}
