using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using balta.SharedContext;

namespace balta.ContentContext
{
    public abstract class Content : Base
    {
        public Content(string title, string url)
        {
            Title = title;
            Url = url;
        }
        public Guid Id { get; set; }

        public string Title { get; set; }
        
        public string Url { get; set; }
    }
 
}
