using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagerDemo
{
    public class MyProcess
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int HandleCount { get; set; }
        public int ThreadCount { get; set; }
        public override string ToString()
        {
            return Id.ToString();
        }
    }
}
