using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int i = 0;
            int res = 0;
            string mensaje = "";
            Console.WriteLine("Entre el nùmero a validar si es primo ...");
            n = Convert.ToInt32(Console.ReadLine());
            
            for (i = 1; i<n; i++)
            {
                if ((n%2) == 0)
                {
                    mensaje = "NO es primo";
                }
                else
                {
                    res = n % i;
                    if (res != 0)
                    {
                        mensaje = "SI es primo";
                    }

                }
            }
            Console.WriteLine(mensaje);
            Console.ReadKey();
           

            //int a = 0;
            //int b = 0;
            //int s = 0;
            //int op = 1;
            //while (op != 0)
            //{

            //    Console.WriteLine("CALCUALDORA");
            //Console.WriteLine("===============");
            //Console.WriteLine("Entre 1er número:");
            //a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Entre 2do número:");
            //b = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine("-------------");
            //    Console.WriteLine("Entre opción:  1-Suma; 2-Resta");
            //    switch (Console.ReadLine())
            //    {
            //        case "1":
            //            s = a + b;
            //            break;
            //        case "2":

            //            s = a - b;
            //            break;
            //    }
            //    Console.WriteLine("La suma es " + s);
            //    Console.Write("presione cualquier numero para seguir;  0 para salir;");
            //    op = Convert.ToInt32(Console.ReadLine());
            //}

        }
    }
}
