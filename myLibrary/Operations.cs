using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myLibrary
{
    public class Operations
    {
        public int Add(int x, int y)
        {
            return x + y;
        }

        public bool isEven(int number)
        {
            return number % 2 == 0;
        }

        public double AddDecimal(double number, double number2)
        {
            return number + number2;
        }

        public IList<int> GetEvenNumbers(int start, int end)
        {
           // List<int> evenNumbers = new List<int>();
           // for (int i = start; i < end; i++)
           // {
           //     if(i % 2 == 0)
           //   {
           //       evenNumbers.Add(i);
           //   }
           // }
           //return evenNumbers;
           List<int> evenNumbers  = Enumerable.Range(start,end)
                .Where(isEven)
                .ToList();
            return evenNumbers;
        }
        //metodos de prueba de nunit para arrays
    } 
}
