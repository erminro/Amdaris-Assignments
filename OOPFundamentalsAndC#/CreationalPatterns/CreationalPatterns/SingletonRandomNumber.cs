using CreationalPatterns.Factories;
using CreationalPatterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns
{
    public class SingletoneRandomNumber
    {
        static SingletoneRandomNumber instance;
        Random random = new Random();
        private static object locker = new object();
  
        protected SingletoneRandomNumber()
        {
        }
        public static SingletoneRandomNumber GetLoadBalancer()
        {

            if (instance == null)
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new SingletoneRandomNumber();
                    }
                }
            }
            return instance;
        }
        public int RandomNumber
        {
            get
            {
                int r = random.Next(20);
                return r;
            }
        }
    }
}

