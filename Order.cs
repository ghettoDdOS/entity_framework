using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

class OrderType
{
  public int Id { get; set; }
  public string Type { get; set; }
}

class OrderVeriety
{
  public int Id { get; set; }
  public string Veriety { get; set; }
}

class Currency
{
  public int Id { get; set; }
  public string CurrencyFull { get; set; }
  public string CurrencyShort { get; set; }
}
class Order
{
  public int Id { get; set; }
  // public int OrderTypeID { get; set; }
  // public OrderType OrderType { get; set; }
  // public int OrderVerietyID { get; set; }
  // public OrderVeriety OrderVeriety { get; set; }
  // public int CurrencyID { get; set; }
  // public Currency Currency { get; set; }
  public string Tiker { get; set; }
  public int Count { get; set; }
  public string Type { get; set; }
  public int Number { get; set; }

  [DataType(DataType.Date)]
  [Column(TypeName = "Date")]
  public DateTime Data { get; set; }
  public string Duration { get; set; }
}

