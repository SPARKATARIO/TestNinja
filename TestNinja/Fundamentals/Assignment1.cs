using System;
using System.Collections.Generic;
namespace TestNinja.Fundamentals {
// Проверка свежести товара по количеству дней до окончания срока годности.
public class Assignment1 {
 public string GetProductFreshness(int daysLeft) {
  if (daysLeft < 0) return "Expired";
  if (daysLeft <= 3) return "ExpiringSoon";
  return "Fresh";
 }
}
}
