using System;
using System.Linq;
namespace HelloApp
{
  class Program
  {
    static void Main(string[] args)
    {
      // Добавление
      using (ApplicationContext db = new ApplicationContext())
      {
        // OrderType dealType = new OrderType { Type = "Брокерская" };
        // OrderVeriety typeOfTransaction = new OrderVeriety { Veriety = "Продажа" };
        // Currency dollar = new Currency { CurrencyFull = "United States Dollar", CurrencyShort = "USD" };

        Order firstOrder = new Order
        {
          Tiker = "ES74",
          Count = 45,
          Type = "Продажа",
          Number = 456,
          Data = new DateTime(2022, 1, 12),
          Duration = "4 дня"
        };

        Order secondOrder = new Order
        {
          Tiker = "TD52",
          Count = 34,
          Type = "Покупка",
          Number = 457,
          Data = new DateTime(2022, 2, 4),
          Duration = "1 день"
        };

        // Добавление
        // db.OrderTypes.Add(dealType);
        // db.OrderVerieties.Add(typeOfTransaction);
        // db.Currencies.Add(dollar);
        db.OrderList.Add(firstOrder);
        db.OrderList.Add(secondOrder);
        db.SaveChanges();
      }
      // получение
      using (ApplicationContext db = new ApplicationContext())
      {
        // получаем объекты из БД и выводим на консоль
        var orders = db.OrderList.ToList();
        Console.WriteLine("Данные после добавления:");
        foreach (Order o in orders)
        {
          Console.WriteLine($"{o.Id}"
            + $"\n{o.Tiker} - {o.Count} - {o.Type} - {o.Number}"
            + $"\n{o.Data} - {o.Duration}"
          );
        }
      }
      // Редактирование
      using (ApplicationContext db = new ApplicationContext())
      {
        // получаем первый объект
        Order order = db.OrderList.FirstOrDefault();
        if (order != null)
        {
          order.Tiker = "BS54";
          order.Number = 458;
          //обновляем объект
          //db.Users.Update(user);
          db.SaveChanges();
        }
        // выводим данные после обновления
        Console.WriteLine("\nДанные после редактирования:");
        var orders = db.OrderList.ToList();
        foreach (Order o in orders)
        {
          Console.WriteLine($"{o.Id}"
            + $"\n{o.Tiker} - {o.Count} - {o.Type} - {o.Number}"
            + $"\n{o.Data} - {o.Duration}"
          );
        }
      }
      // Удаление
      using (ApplicationContext db = new ApplicationContext())
      {
        // получаем первый объект
        Order order = db.OrderList.FirstOrDefault();
        if (order != null)
        {
          //удаляем объект
          db.OrderList.Remove(order);
          db.SaveChanges();
        }
        // выводим данные после обновления
        Console.WriteLine("\nДанные после удаления:");
        var orders = db.OrderList.ToList();
        foreach (Order o in orders)
        {
          Console.WriteLine($"{o.Id}"
            + $"\n{o.Tiker} - {o.Count} - {o.Type} - {o.Number}"
            + $"\n{o.Data} - {o.Duration}"
          );
        }
      }
      Console.Read();
    }
  }
}