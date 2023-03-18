﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace balta.ContentContext
{
    public class Career : Content
    {
        public Career(string title, string url) 
            : base(title, url)
        {
            Items = new List<CareerItem>();
        }
        public int Courses { get; set; }

        public IList<CareerItem> Items { get; set; }

        public int TotalCourses => Items.Count; 
       
    }

}
