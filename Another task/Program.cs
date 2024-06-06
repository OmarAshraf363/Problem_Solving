namespace ConsoleApp6
{
    internal class Program
    {
        static bool Valid(string pin)
        {
           for(int i = 0; i < pin.Length; i++)//1234
            {
                if (char.IsNumber(pin[i]) == false)
                {
                   return false;
                    
                }

            }
            if (pin.Length==4 ||pin.Length==6)
            {
                return true;
            }
            return false;
           
           
           
        }
        static int Con(int menutis)
        {
            return menutis * 60;
        }
        static string SwapName(string name)
        {
            var s = name.Split(" ");
            for (int i = 0; i < s.Length - 1; i++)
            {
                var temp = s[i];
                s[i] = s[i + 1];
                s[i + 1] = temp;
            }

            name = string.Join(" ", s);
            return name;
        }
        static string arr(int[] array)
        {
            string[] temp= new string[array.Length];
            for (int i=0;i<array.Length;i++)
            {
                temp[i] = array[i].ToString();
            }
            for (int i=0; i<temp.Length;i++)
            {
                if (temp[i].Contains("7"))
                {
                    return "boom!!";
                }
            }
            return "there is no 7 in the array";

        }
        static string Reversat(int i)
        {
            string temp = i.ToString();
            char[] chars = temp.ToCharArray();
            char[] chars1 = new char[chars.Length];
            Array.Reverse(chars);
            string temp2=new string(chars);
             return $"{temp2}{temp}";



        }
        static string Come(string s,string mt)
        {
            char[] chars = s.ToCharArray();//*m*r
            char[] chars1=mt.ToCharArray();//oa
            int count = 0;
            for(int i=0;i<chars.Length;i++)
            {  
                    if (chars[i] == '*')
                    {
                        chars[i] = chars1[count];
                        count++;
                    }  
            }
            s=new string(chars);
            return s;
        }
        static bool Check(string[] sub, string[] all)
        {
            string test = "";
            for (int i = 0; i < all.Length; i++)
            {
                test += all[i];

            }
            //omarashraf
            for (int i = 0; i < sub.Length; i++)
            {
                if (!test.Contains(sub[i]))
                {
                    return false;
                }
               
            }
            return true;

        }
        static int Legendre(int p ,int n)
        { 
            int resuly = 0;
            for (int i=1; Math.Pow(p, i) <= n; i++)
            {
                resuly += (int)(n/Math.Pow(p, i));
            }
            return resuly;
        }
        static bool Show(string str)
        {
            // o m m o
            // o m m o
            char[] chars=str.ToCharArray();
            char[] chars1 = chars.Reverse().ToArray();
            for (int i=0;i<chars.Length;i++)
            {
                if (chars[i] == chars1[i])
                {
                    return true;
                }
            }
            return false;





        }
      
        static bool Bracits(string str)
        {
            str = str.Trim();
            if (string.IsNullOrEmpty(str)) { return true; }
            else if (str[0] == '(' && str[str.Length - 1] == ')')
            {
                return true;
            }
            else if (!str.Contains('(') && !str.Contains(')')) {
                return true;
            }
            else if (str.Contains('!')) { return false; }
            return false;
        }

        static bool isupan(int num)
        {
            if (num>100&&num<1000000)
            {
                return false;
            }
            else if (num == 40) { return true; }
            else if (num.ToString().Contains("4"))
            {
                return false;
            }
            return true;
        }
            
            
            
        
        static void Main(string[] args)
        {
            Console.WriteLine(isupan(40));
            Console.WriteLine(isupan(1000));
            Console.WriteLine(isupan(32));



        }
    }
}
