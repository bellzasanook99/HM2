using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Models
{
   public class Errorx
    {
        public int Code { get; set; }
        public string errors { get; set; }
    }

    public class Errors
    {
        public List<string> messages { get; set; }
    }

    public class Root
    {
        public Errors errors { get; set; }
        public string title { get; set; }
        public int status { get; set; }
        public string traceId { get; set; }
    }
}
