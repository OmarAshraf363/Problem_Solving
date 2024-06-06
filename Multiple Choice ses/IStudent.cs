using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultibleChoice
{
    internal interface IStudent
    {
        public string[] TestsTaken { get; set; }
        public void Taketest(ITestpaper paper, string[] answers);
    }
}
