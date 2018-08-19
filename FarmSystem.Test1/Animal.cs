using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FarmSystem.Test2;

namespace FarmSystem.Test1
{
    public abstract class Animal
    {
        public string Id { get; set; }
        public int NoOfLegs { get; set; }
        public abstract void Talk();
        public abstract void Run();
    }
}
