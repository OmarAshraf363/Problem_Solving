using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultibleChoice
{
    internal interface ITestpaper
    {
        //string Subject
        //string[] MarkScheme
        //string PassMark
        public string Subject { get; set; }
        public string[] MarkScheme { get; set; }
        public string PassMark { get; set; }
        //public void Test(string Subject, string[] markscheme, string passmark);
    }
}
