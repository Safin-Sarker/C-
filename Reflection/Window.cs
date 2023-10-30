using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class Window
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public List<Lock> Locks { get; set; } = new List<Lock>();
    }
}
