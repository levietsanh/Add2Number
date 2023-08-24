using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add2Number
{
    public class MyBigNumber
    {
        public string Sum (string num1,  string num2) 
        {
            int num1Length= num1.Length; // do dai num 1
            int num2Length= num2.Length; // do dai num  2
            int lengthMax = num1Length > num2Length ? num1Length : num2Length;
            String result = String.Empty;
            int temp = 0;
            int num1I, num2I; // num1I luu lai vi tri ky tu cua chuoi num 1 (theo chieu phai sang trai),num2I tuong tu
            char c1, c2; // c1 lay ky tu, c2 tuong tu
            int digit1, digit2; // digit1 chuyen ky tu thanh so
            int mem = 0;
            for( int i=0; i< lengthMax; i++)
            {
                num1I = num1Length - i - 1;
                num2I = num2Length - i - 1;
                c1 = (num1I >= 0) ? num1[num1I] : '0';
                c2 = (num2I >= 0) ? num2[num2I] : '0';
                digit1 = c1 - '0';
                digit2 = c2 - '0';

                temp = digit1 + digit2 + mem;
                mem = temp / 10;
                temp = temp % 10;
                
                result = temp + result;
            }
            if( mem > 0)
            {
                result = mem + result;
            }
            return result;

        }

        public static void Main()
        {
            Console.WriteLine("Enter a number 1: ");
            string num1 = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter a number 2: ");
            string num2  = Convert.ToString(Console.ReadLine());
            MyBigNumber myBigNumber = new MyBigNumber();
            Console.WriteLine("" + myBigNumber.Sum(num1, num2));
        
        }
    }
}
