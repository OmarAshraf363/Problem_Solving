using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultibleChoice
{
    internal class Student:IStudent
    {
        public string[] TestsTaken { get; set; }
        public void Taketest(ITestpaper? paper = null, string[]? answers=null)
        {
          
            if (paper == null)
            {
                Console.WriteLine("No test taken"); ;
            }
            else 
            {
                double counter = 0;
                for (int i = 0;i<answers.Length;i++)
                {
                    if (answers[i] == paper.MarkScheme[i])
                    {
                        counter +=0.2;
                    }
                }
                counter = counter * 100;
                int x = int.Parse(paper.PassMark);
                if (counter  < x)
                {
                    Console.WriteLine($"You failed in [{paper.Subject}] your grade is {counter}% less than pass rate {paper.PassMark}%");

                }
                else
                {
                    Console.WriteLine($"pass!!...Your Grade in [{paper.Subject}] is {counter }%");
                }
            }
        }
        /*
            paper1 = new Testpaper("Maths", new string[] { "1A", "2C", "3D", "4A", "5A" }, "60%")
            paper2 = new Testpaper("Chemistry", new string[] { "1C", "2C", "3D", "4A" }, "75%")
            paper3 = new Testpaper("Computing", new string[] { "1D", "2C", "3C", "4B", "5D", "6C", "7A" }, "75%")

            student1 = new Student()
            student2 = new Student()
         
         
         */

    }
}
