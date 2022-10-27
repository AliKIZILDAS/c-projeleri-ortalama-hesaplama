using System;
using System.Collections.Generic;
using System.Collections;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fibonacci Fibo=new Fibonacci();
            Console.WriteLine("Lütfen bir sayi giriniz.");
            int sayi=Int32.Parse(Console.ReadLine());
            Fibo.FibonacciHesap(sayi);
            
                  
                      
        }
    }

    class Fibonacci
    {
        public void FibonacciHesap(int len)
        {
            
            //ArrayList dizi=new ArrayList();
            //             
            //for (int i = 2; i <= sayi; i++)
            //{           
            //    for (int j = 1; j < i; j++)
            //    {
            //        FibonacciHesap(1)[0]=1;
            //        FibonacciHesap(1)[1]=1;
//
            //        FibonacciHesap(i)[0]=1;
            //        FibonacciHesap(i)[i+1]=1;
            //        FibonacciHesap(i)[j]=FibonacciHesap(i-1)[j-1]+FibonacciHesap(i-1)[j];
            //        
            //    }              
            //}
            int[] dizi=new int[len];
            int a = 0, b = 1, c = 0;
            dizi[0]=a; dizi[1]=b;
            Console.Write("{0} {1}", a, b);
            for (int i = 2; i < len; i++)
            {
                c = a + b;
                Console.Write(" {0}", c);
                a = b;
                b = c;
            dizi[i]=c;
            }
            double sum=0;
            double ortalama=0;
            for(int i=0;i<len;i++)
            {
                sum+=dizi[i];
            }
            ortalama=sum/len;
            Console.WriteLine(" \nOrtalama= "+ ortalama);
        }
    }             
}


