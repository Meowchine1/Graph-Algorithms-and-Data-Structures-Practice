using System;
using System.Collections.Generic;
using System.Text;

namespace AtdGraph
{
    public class Vertex
    {
        public string number;
        public List<Edje> adjacent; // список инцидентности

      public  Vertex(string num) {
            number = num;
            adjacent = new List<Edje>();
        }
    }
}
