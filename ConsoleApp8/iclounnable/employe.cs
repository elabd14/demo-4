using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8.iclounnable
{
    internal interface employee
    {
        public int Id { get; set; }
        public string?  Name { get; set; }
        public decimal? Salary { get; set; }


        public override string ToString()
        {

        return $"Id"; }

        
    }
}
