using MovieFeeler.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieFeeler.Model
{
    public class News : BaseModel
    {
        public string storytitle { get; set; }
        public string storyshortsummary { get; set; }
        public string storyfullsummary { get; set; }
        public string author { get; set; }
        public string pub_date { get; set; }
        public string newsimage { get; set; }
    }
}
