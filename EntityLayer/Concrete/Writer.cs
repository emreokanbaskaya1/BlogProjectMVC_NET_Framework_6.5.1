﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Writer
    {
        [Key]
        public int WriterID { get; set; }
        [StringLength(50)]
        public string WriteName { get; set; }
        [StringLength(50)]
        public string WriterSurName { get; set; }
        [StringLength(100)]
        public string WriterImage { get; set; }
        [StringLength(100)]
        public string WriterAbout { get; set; }

        [StringLength(200)]
        public string WriteMail { get; set; }
        [StringLength(200)]
        public string WritePassword { get; set; }

        [StringLength(200)]
        public string WriteTitle { get; set; }

        public ICollection<Heading> Headings { get; set; }
        public ICollection<Content> Contents { get; set; }
    }
}
