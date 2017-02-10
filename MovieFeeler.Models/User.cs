using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieFeeler.Model
{
    public class User : BaseModel
    {        
        public string username { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public long phoneno { get; set; }
    }

    public class BaseModel
    {
        public int id { get; set; }
    }
}