using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_set_3_question
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //Console.WriteLine("enter the factors of number");
            //int n = int.Parse(Console.ReadLine());
            //Console.WriteLine(getfactor(n));
            #endregion

            #region Q2
            //Console.WriteLine("prime:1" + isprime(1));
            //Console.WriteLine("prime:2" + isprime(2));
            //Console.WriteLine("prime:4" + isprime(4));
            //Console.WriteLine("prime:7" + isprime(7));
            #endregion

            #region Q3
            //Console.WriteLine("enter the number");
            //int n = int.Parse(Console.ReadLine());
            //Console.WriteLine(printprime(n));
            //Console.WriteLine(primenumbers(n));
            #endregion

            #region q4
            //Console.WriteLine("enter the prime number");
            //int m = int.Parse(Console.ReadLine());
            //int n=int.Parse(Console.ReadLine());
            //Console.WriteLine(primenumbers(n));
           #endregion

            #region Q5
            //int n=int.Parse(Console.ReadLine());
            //Console.WriteLine(primenumberlessthanequaln(n));
           #endregion

            #region Q6
            //console.WriteLine(sumofnprime(n));
            #endregion

            #region Q7
            //Console.WriteLine(primenumberlessthann(n));
            #endregion

            #region Q8
            //Console.WriteLine(primenumbersmandn(m,n));
            #endregion

            #region Q9
            //int n = int.Parse(Console.ReadLine());
            //Console.WriteLine(primefactorn(n));
            #endregion

            #region Q10
            Console.WriteLine("enter the number of prime numbers");
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(numberofprimenumber(m,n));
            #endregion

        }
        #region Q1 factors of n
        public static int getfactor(int n)
        {
            for (int factor = 1; factor <= n; factor++)
            {
                if (n % factor == 0)
                {
                    Console.WriteLine(factor + ",");
                }
            }
            return 0;
        }
        #endregion
        #region Q2 find all a given number is prime or not
        public static bool isprime(int n)
        {
            bool prime = true;
            if (n < 2)
            {
                return false;
            }
            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0)
                {
                    prime = false;
                    break;
                }
            }
            return prime;
        }
        #endregion
        #region Q3 print prime numbers from 1upto n
        public static int printprime(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                if (isprime(i))
                {
                    Console.WriteLine(i);
                }
            }
            return 0;
        }
        #endregion
        #region Q4 first n prime numbers starting from 2
        public static int primenumbers(int n)
        {
           for (int i = 2; i<=n; i++)
			{
			   if (isprime(i))
	{
		 Console.WriteLine(i);
	} 
			}
            return 0;
        }
        #endregion
        #region Q5 find the number of prime numbers less than eual n
        public static int primenumberlessthanequaln(int n)
        {
            int k = printprime(n);
            {
                if (k < n)
                {

                }

            }
            return k;

        }
        #endregion
        #region Q6 sum of first n prime number
        public static int sumofnprime(int n)
        {
            int sum = 0;
            for (int i = 1; i <=n; i++)
            {
                int count = 0;
                for (int j = 2; j <=i/2; j++)
                {
                    if (i%j==0)
                    {
		                count++;
                        break;
	                }
                    if (count==0&&i!=0)
                    {
                        count += n = 1;
                        sum += i;
                    }
                }
            }
            return sum;
        
        }
        #endregion
        #region Q7 sum of all prime numbers less than n
        public static int primenumberlessthann(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                int count = 0;
                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                        break;
                    }
                    if (count == 0 && i != 0)
                    {
                        
                        sum += i;
                        if (sum<=n)
                        {
                            Console.WriteLine(sum);
                        }
                    }
                }
            }
            return 0;
        
        
        
        }
        #endregion
        #region Q8 print all prime numbers m and n
        public static int primenumbersmandn(int m,int n)
        {
            for (int i = m; i <=n; i++)
            {
                if (isprime(i))
                {
                    Console.WriteLine(i);
                }
            }
            return 0;
        
        }
        #endregion
        #region Q9 print the prime factor of a given number n
        public static int primefactorn(int n)
        {
            int fac = getfactor(n);
            for (int i = 1; i<=n; i++)
            {
                int count = 0;
                for (int j = 2; j <=i/2; j++)
                {
                    if (i%j==0)
                    {
                        count++;
                        //break;
                    }
                    
                }
                if (count==0&&i!=0)
                {
                    if (fac%i==0)
                    {
                        Console.WriteLine(fac);
                        break;
                    }
                }
            }

            return fac;
        }
        #endregion
        #region Q10 number of prime numbers 
        public static int numberofprimenumber(int m, int n)
        {
            int count = 0;
            while (n!=0)
                for (int i = m; i <=n; i++)
                {
                    n = n / 10;
                    if (isprime(i))
                    {
                        Console.WriteLine(i);
                        i += n;
                        count++;
                    }
                }
            return 0;
        }
        #endregion
    }
}
