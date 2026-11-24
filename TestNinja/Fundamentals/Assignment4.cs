using System;
using System.Collections.Generic;
namespace TestNinja.Fundamentals {
// Приход товара: меняет состояние StockQuantity, ничего не возвращает.
public class Assignment4 {
 public int StockQuantity { get; private set; }
 public Assignment4(int initialQuantity) {
  if (initialQuantity < 0) throw new ArgumentOutOfRangeException("initialQuantity");
  StockQuantity = initialQuantity;
 }
 public void RestockProduct(int amount) {
  if (amount <= 0) throw new ArgumentOutOfRangeException("amount");
  StockQuantity = checked(StockQuantity + amount);
 }
}
}
