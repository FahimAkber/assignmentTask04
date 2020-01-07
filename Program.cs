using System;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //first 20 prime number and their sum.
           int isPrime, sum = 0; 
           for(int i = 2; i <= 72; i++){
               isPrime = 1;
               for(int j = 2; j <= i/2; j++){
                   if(i % j == 0){
                       isPrime = 0;
                       break;
                   }
               }
               if(isPrime== 1){
                   sum = sum + i ;
                   Console.Write (" "+i);
               }
               
           }
           Console.WriteLine("\n"+sum);
        }
            
    
    }
}
