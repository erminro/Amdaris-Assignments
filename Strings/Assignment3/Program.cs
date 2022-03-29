using System;
using System.Collections;
using System.Globalization;

namespace Assignment3 {
    public class String_DatesAndTimes {
        public static void Main(string[] args){
            string s = "Ana are mere";
            Console.WriteLine(s);
           var res1=s.Replace("Ana", "Maria");
            Console.WriteLine(res1);
            Console.WriteLine(string.Compare(s, res1));
            Console.WriteLine(res1.Length);
            s = s.Remove(3);
            Console.WriteLine(s);
            s = s.Insert(s.Length, " are mere");
            Console.WriteLine(s);
            Console.WriteLine(s.First());
            Console.WriteLine(s.Last());
            string s2 = "Income={0,3}";
            Console.WriteLine(string.Format(s2, 1));
            string s1 = "    abc     ";
            var result=s1.Trim();
            var result1=s1.TrimStart();
            var result2=s1.TrimEnd();
            Console.Write(result);
            Console.WriteLine("a");
            Console.Write(result1);
            Console.WriteLine("a");
            Console.Write(result2);
            Console.WriteLine();
            string s3 = $"{s} bune";
            Console.WriteLine(s3);

            DateTime dt= DateTime.Now;
            Console.WriteLine(dt);
            Console.WriteLine(DateTime.MinValue.Ticks);
            Console.WriteLine(DateTime.MaxValue.Ticks);
            
            DateTime dt1 = new DateTime(2021, 12, 31);
            DateTime dt2 = new DateTime(2022, 2, 2);
            TimeSpan ts1 = dt2.Subtract(dt1);
            Console.WriteLine(ts1);
            DateTime dt3 = DateTime.Now;  
            Console.WriteLine(dt3.ToString(CultureInfo.CreateSpecificCulture("en-US")));
            Console.WriteLine(dt3.ToString(CultureInfo.CreateSpecificCulture("en-GB")));
            DateTime dt4 = new DateTime(2007, 07, 12, 06, 32, 00);
            DateTimeOffset do1 = new DateTimeOffset(dt4,
                                     TimeZoneInfo.Local.GetUtcOffset(dt4));
            Console.WriteLine(do1);
        }
    }
}