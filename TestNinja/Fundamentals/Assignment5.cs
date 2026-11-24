using System;
using System.Collections.Generic;
namespace TestNinja.Fundamentals {
// Проверка веса товара. Недопустимый вес вызывает исключение.
public class Assignment5 {
 public decimal ValidateProductWeight(decimal weightKg) {
  if (weightKg <= 0 || weightKg > 100)
   throw new ArgumentOutOfRangeException("weightKg", "Вес должен быть больше 0 и не больше 100 кг");
  return weightKg;
 }
}
}
