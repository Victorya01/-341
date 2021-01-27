using System;

namespace телефонный_справочник
{
    class Program
    {
        static void Main(string[] args)
        {


            string[,] mas = new string[6, 2];


            mas[0,0] = "Имя ";
            mas[0,1] = "\t\t Телефон или email";
            mas[1,0] = "Степан";
            mas[1,1] = "\t\t 89129715068";
            mas[2, 0] = "Екатерина";
            mas[2, 1] = "\t eakaterina@list.ru";
            mas[3, 0] = "Иван";
            mas[3, 1] = "\t   \t 89991123423";
            mas[4, 0] = "Елизавета";
            mas[4, 1] = "\t +137172389494";
            mas[5, 0] = "Евгения";
            mas[5, 1] = "\t \t evgenia11@mail.ru";

            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    Console.Write(mas[i, j]);


                }
                Console.WriteLine();

            }

        }
    }
}
