using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ADO_NET.entities
{
    public class Category
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Detail { get; set; }
        public string ImagePath { get; set; }
        public string Meta_Keyword { get; set; }
        public string Meta_Description { get; set; }
        public bool Status { get; set; }
        public bool ShowOnHome { get; set; }
    }
}