using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultibleChoice
{
    internal class Testpaper: ITestpaper
    {
        public string Subject { get; set; }=string.Empty;
        public string[] MarkScheme { get; set; } 
        public string PassMark { get; set; } = string.Empty;

        public Testpaper(string subject, string[] markscheme, string passMark)
        {
            Subject = subject;
            MarkScheme = markscheme;
            PassMark = passMark;
        }

        //public void Test(string subject, string[] markscheme, string passmark)
        //{
        //    this.Subject = subject;
        //    this.PassMark = passmark;
        //    this.MarkScheme = markscheme;
        //}
    }
}
