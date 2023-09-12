using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class Program
    {
        private static void Main(string[] args)
        {



            List<Drink> drinks = new List<Drink>();
            drinks.Add(new Drink() { Name = "紅茶", Size = "大杯", Price = 60 });
            drinks.Add(new Drink() { Name = "紅茶", Size = "小杯", Price = 40 });
            drinks.Add(new Drink() { Name = "綠茶", Size = "大杯", Price = 60 });
            drinks.Add(new Drink() { Name = "綠茶", Size = "小杯", Price = 40 });
            drinks.Add(new Drink() { Name = "可樂", Size = "大杯", Price = 30 });
            drinks.Add(new Drink() { Name = "可樂", Size = "小杯", Price = 20 });

            // for-loop
            //for (int i = 0; i < drinks.Count; i++)
            //{
            //    Console.WriteLine($"{drinks[i].Name}  {drinks[i].Size} {drinks[i].Price}元");
            //}

            // foreach
            foreach (Drink drink in drinks)
            {
                Console.WriteLine($"{drink.Name}  {drink.Size} {drink.Price}元");
            }
        }
    }
}