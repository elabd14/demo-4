using ConsoleApp8.iclounnable;
using System;

namespace ConsoleApp8
{
    internal class Program
    { 
       /* public static void  Print10NumberfromSeries(ISeries series)
        {
            if (series == null) 
            {
                for (int i = 0; i < 10; i++)
                {

                    Console.WriteLine(series.Current);
                    series.GetNext();
                }
                series.Reset();*/






        static void Main(string[] args)

        {
            #region 1
            /* IMytype.mytype = NEW MyType();
                myType.Id = 60;
                myType.Myfun(600);
                myType.Print();*/
            #endregion
            #region Interface ex 1
            /*  seriesBYTwo seriesBYTwo = new seriesBYTwo();
                      Print10NumberfromSeries(seriesBYTwo);   


                      seriesbytherr seriesbytherr=new seriesbytherr();
                      Print10NumberfromSeries(seriesbytherr);*/

            #endregion

            #region cars and airplan 
            /*      #region refrance 
                cars cars = new cars();
                cars Backward();


                Airplan airplan=new Airplan();
                Airplan Backword();
    */
            #endregion

            #region Shallow capys  and Deep Capy 
            #region Array of  valus  type 
            /*  int[] arr01 = { 1, 2, 3  };
               int[] arr2 = new int[3];
              Console.WriteLine($"Hc of arr01={arr01.GetHashCode()}");
              Console.WriteLine($"Hc od arr02={arr2.GetHashCode()}");
              arr2 = arr01;

              Console.WriteLine("AFTER Shallow Capye");
              Console.WriteLine($"Hc od arr02={arr2.GetHashCode()}");
              Console.WriteLine($"Hc od arr02={arr2.GetHashCode()}");


              arr2[0] = 100;
              Console.WriteLine(arr2[0]);

              #region Deep capye 
              arr2 = (int[])  arr01.Clone();*/
            #endregion

            #region arry refrance 
            /*   string[] Name01 = { "Mosty " };
               string[] Name02 = new string[1];
               Console.WriteLine($"HC of name01={Name01.GetHashCode()}");
               Console.WriteLine($"HC name02={Name02.GetHashCode()}");

               Name02 = Name01;
               Console.WriteLine("After sahllow caype ");*/

            #endregion

            #region deep capye .
            /*   Name02=(string []) Name01.Clone();
               Console.WriteLine("After Deep  caype ");
               Console.WriteLine($"HC of name01={Name01.GetHashCode()}");
               Console.WriteLine($"HC name02={Name02.GetHashCode()}"); 
               #endregion*/

            #endregion





            #endregion

            #region Employe 
            employee employe01 = new employee() { Id = 10, Name = "mosty", Salary = 60000 };
            employee employe02 = new employee() { Id = 20, Name = "fahed ", Salary = 50000 }; 
            #endregion




        }


    }


}
