using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace backend_test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Greetings Earth");

            List<string> keyWords = Console.ReadLine().Split(" ").ToList();

            using (var context = new TestasContext())
            {
                List<Automobilis> automobilis = context.Automobilis
                    .Where(q => keyWords.Contains(q.Marke) || keyWords.Contains(q.Modelis) || keyWords.Contains(q.AutomobilioPagaminimoMetai.ToString()))
                    .ToList();

                foreach (Automobilis auto in automobilis)
                {
                    Console.WriteLine(auto.Marke);
                    Console.WriteLine(auto.Modelis);
                    Console.WriteLine(auto.AutomobilioPagaminimoMetai);
                }
            }

        }

    }
}
