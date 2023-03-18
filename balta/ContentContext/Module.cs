using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using balta.SharedContext;

namespace balta.ContentContext
{
    public class Module : Base
    {
        public Module()
        {
            IList<Lecture> Lectures = new List<Lecture>();
        }
        public int Order { get; set; }
        public string Title { get; set; }
        public IList<Lecture> Lectures { get; set; }
    }

}