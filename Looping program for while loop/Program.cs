using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Looping_program_for_while_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Q1 count the number of an digits
            //Console.WriteLine("enter input the count the number of an digits");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int count = 0;

            //while (n!=0)
            //{
            //    n = n / 10;
            //    count++;


            //}
            //Console.WriteLine(count);
            #endregion
            #region Q2 check the number even length or odd length
            //Console.WriteLine("enter the inputs");
            //int n = Convert.ToInt32(Console.ReadLine());
            //if (n % 2 == 0)
            //{
            //    Console.WriteLine("even length");
            //}
            //else if (n % 2 != 0)
            //{
            //    Console.WriteLine("odd length");
            //}
            //Console.WriteLine(n);
            #endregion
            #region Q3 sum of digits of an given integer
            //Console.WriteLine("enter sum of digits of given integer");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int sum = 0;
            //while (n!=0)
            //{
            //    int rem = n % 10;
            //    sum += rem;
            //    n = n / 10;
            //}
            //Console.WriteLine(sum);
            #endregion




            #region Q4 sum of digits in odd positions
            //Console.WriteLine("enter sum of digits in integer");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int len = 0;
            //int sum = 0;
            //bool isskip = false;
            //if (len % 2 == 0)
            //{
            //    isskip = false;
            //}
            //else
            //{
            //    isskip = true;
            //}
            //while (n != 0)
            //{
            //    int rem = n % 10;
            //    if (!isskip)
            //    {
            //        sum += rem;
            //    }
            //    n = n / 10;
            //    isskip = !isskip;


            //}

            //Console.WriteLine(sum);
            #endregion
            #region Q5 sum of digits in even position of given integer
            //Console.WriteLine("sum of digits in even position of integer");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int len = 0;
            //int sum = 0;
            //bool isskip = false;
            //if (len % 2 != 0)
            //{
            //    isskip = true;
            //}
            //else
            //{
            //    isskip = false;
            //}
            //while (n != 0)
            //{
            //    int rem = n % 10;
            //    if (!isskip)
            //    {
            //        sum += rem;
            //    }
            //    n = n / 10;
            //    isskip = !isskip;


            //}

            //Console.WriteLine(sum);
            #endregion
            #region Q6 count the number of an even digits is an integer
            //Console.WriteLine("enter inputs for even digits in integer");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int count = 0;
            //while (n != 0)
            //{
            //    int rem = n % 10;
            //    if (n % 2 == 0)
            //    {

            //        count++;

            //    }

            //    n = n / 10;

            //}
            //Console.WriteLine(count);
            #endregion
            #region Q7 count the number of odd digit of an integer
            //Console.WriteLine("enter input count the number of odd digit");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int count = 0;
            //while (n!=0)
            //{
            //    int rem = n % 10;
            //    if (n%2!=0)
            //    {
            //        count++;   
            //    }
            //    n = n / 10;
            //}
            //Console.WriteLine(count);
            #endregion
            #region Q8 sum of the odd digits of given integer
            //Console.WriteLine("enter input sum of odd digits");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int sum = 0;
            //while (n!=0)
            //{
            //    int rem = n % 10;
            //    if (n%2!=0)
            //    {
            //        sum += rem;
            //    }
            //    n = n / 10;
            //}
            //Console.WriteLine(sum);
            #endregion
            #region Q9 sum of the even digits of given integers
            //Console.WriteLine("enter input sum of even digits");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int sum = 0;
            //while (n!=0)
            //{
            //    int rem = n % 10;
            //    if (n%2==0)
            //    {
            //        sum += rem;
            //    }
            //    n = n / 10;
            //}
            //Console.WriteLine(sum);
            #endregion
            #region Q10 Get the last digits of a given integer
            //Console.WriteLine("enter the last digits of intrger");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int rem = 0;
            //while (n != 0)
            //{
            //     rem = n % 10;
            //     break;
            //     n = n / 10;
            //}
         
            //Console.WriteLine(rem);
            #endregion
            #region Q11 get the first digits of an given numbers
            //Console.WriteLine("enter inputs first digit of an number");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int rem = 0;
            //while (n != 0)
            //{
            //    rem = n % 10;
            //    n = n / 10;
            //}
            //Console.WriteLine(rem);
            #endregion
            #region Q12 if the first and last digit of an given integer same
            //Console.WriteLine("enter input first and last digit of an integer");
            //int input = 72857;
            //int n = input;
            //int lastdigtit = 0;
            //int count = 0;
            //while (n!=0)
            //{
            //    count++;
            //    n = n / 10;
            //}
            //int firstdigit = input/ (int)Math.Pow(10,(count - 1));
            //if (firstdigit==lastdigtit)
            //{
            //    Console.WriteLine("true");
            //}
            //else
            //{
            //    Console.WriteLine("false");
            //}
             #endregion
            #region Q13 Given an integer find the digit maximum value
            //int n = 1890;
            //int largest = 0;
            //int position = 0;
            //int count = 0;
            //while (n != 0)
            //{
            //    int rem = n % 10;
            //    if (rem > largest)
            //    {
            //        largest = rem;
            //        position = count;
            //    }
            //    n = n / 10;
            //    count++;
            //}
            //Console.WriteLine(largest);
            //Console.WriteLine((int)Math.Pow(10, position));
            #endregion
            #region Q14 Given an integer find the digit at maximum value
            //int n = 3842;
            //int largest = 0;
            //int position = 0;
            //int count = 0;
            //while (n != 0)
            //{
            //    int rem = n % 10;
            //    if (rem > largest)
            //    {
            //        largest = rem;
            //        position = count;
            //    }
            //    n = n / 10;
            //    count++;
            //}
            //Console.WriteLine(largest);
            //Console.WriteLine((int)Math.Pow(10, position) + "s");
            #endregion
            #region Q15 Given an integer find the digit of minimum value
            //int n = 1890;
            //int smallest = 0;
            //int position = 0;
            //int count = 0;
            //while (n!=0)
            //{
            //    int rem = n % 10;
            //    if (rem<smallest)
            //    {
            //        smallest = rem;
            //        position = count;
            //    }
            //    n = n / 10;
            //    count++;
                
            //}
            //Console.WriteLine(smallest);
            //Console.WriteLine((int)Math.Pow(10, position));
            #endregion
            #region Q16 find the location the digit with maximum value
            //int n = 2483;
            //int smallest = 0;
            //int position = 0;
            //int count = 0;
            //while (n != 0)
            //{
            //    int rem = n % 10;
            //    if (rem < smallest)
            //    {
            //        smallest = rem;
            //        position = count;
            //    }
            //    n = n / 10;
            //    count++;
            //}
            //Console.WriteLine(smallest);
            //Console.WriteLine((int)Math.Pow(10,(position))+ "s");
            #endregion
            #region Q17 Reverse a given integer number n
            //Console.WriteLine("reverse of an ineger n ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int reverse = 0;
            //while (n!=0)
            //{
            //    int rem = n % 10;
            //    reverse = 10 * reverse + rem;
            //    n = n / 10;
            //}
            //Console.WriteLine(reverse);
            #endregion
            #region Q18 find the digital root of an given integers
            //Console.WriteLine("find the digital root of an integers");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int root = 0;
            //int rem = 0;
            //int sum = 0;
            //while (n != 0)
            //{
            //    rem = n % 10;
            //    sum += rem;
            //    n = n / 10;
            //}
            //    if (sum>=10)
            //    {
            //        rem = sum % 10;
            //        root += rem;
            //        sum /= 10;
            //        root+= sum;
            //    }
            //    Console.WriteLine(root);
           #endregion
            #region Q19 check all digits of an integer n divide n
            //Console.WriteLine("enter all digitsmof integer divide n");
            //int n = int.Parse(Console.ReadLine());
            //while (n!=0)
            //{
            //    int rem =n % 10;
            //    n=n/10;
            //    if (rem%n==0)
            //    {
            //        Console.WriteLine("true");
            //    }
            //    else
            //    {
            //        Console.WriteLine("false");
            //    }
               
            //}
            #endregion
            #region Q20
            //Console.WriteLine("enter the count digits of integer");
            //int n = int.Parse(Console.ReadLine());
            
            //int count = 0;
            //while (n != 0)
            //{
            //    int rem = n % 10;

            //    if (n % 2 == 0)
            //    {
            //        count++;
            //    }
            //     n= n / 10;
            //}
            //Console.WriteLine(count);
            #endregion
            #region Q21 two or three positive integer is palindrome or not
            //Console.WriteLine("enter input positive integer in palindrome");
            //int n = int.Parse(Console.ReadLine());
            //int palindrome = 0;
            //int rem = 0; 
            //int number = n;
            //while (n != 0)
            //{
            //    rem = n % 10;
            //    palindrome=palindrome*10+rem;
            //    n=n/10;
            //}
            //Console.WriteLine(palindrome);
            //if (number==palindrome)
            //{
            //    Console.WriteLine("true");
            //}
            //else 
            //{
            //    Console.WriteLine("false");
            //}
           
            #endregion
            #region Q22 check if the given positive long integer is palindrome or not
            //Console.WriteLine("enter input positive long integer is palindrome");
            //long n = long.Parse(Console.ReadLine());
            //long palindrome = 0;
            //long rem = 0;
            //long number = n;
            //while (n != 0)
            //{
            //    rem = n % 10;
            //    palindrome = palindrome * 10 + rem;
            //    n = n / 10;
            //}
            //Console.WriteLine(palindrome);
            //if (number == palindrome)
            //{
            //    Console.WriteLine("true");
            //}
            //else
            //{
            //    Console.WriteLine("false");
            //}
           
            #endregion
            #region Q23 find the maximum number n using digits of an integer
            //Console.WriteLine("enter the maximum number of an digits");
            //int n = int.Parse(Console.ReadLine());
            //int largest = 0;
            //int rem = 0;
            //int number = n;
            //int temp = 0;
            //for (int i = 0; i <= 9; i++)
            //{
            //    temp = number;
            //    while (temp != 0)
            //    {
            //        rem = temp % 10;
            //        if (rem == i)
            //        {
            //            largest = largest * 10 + i;
            //        }

            //        temp = temp / 10;
            //    }
            //}
            //Console.WriteLine(largest);
           #endregion
            #region Q24 minimum number n using digits of an integer
            //Console.WriteLine("enter the minimum number digits of an integer");
            //int n = int.Parse(Console.ReadLine());
            //int smallest = 0;
            //int rem = 0;
            //int number = n;
            //int temp = 0;
            //for (int i = 0; i <= 9; i++)
            //{
            //    temp = number;
            //    while (temp != 0)
            //    {
            //        rem = temp % 10;
            //        if (rem == i)
            //        {
            //            smallest = smallest * 10 + i;
            //        }

            //        temp = temp / 10;
            //    }
            //}
            //Console.WriteLine(smallest);    
            #endregion



        }
    }
}
        