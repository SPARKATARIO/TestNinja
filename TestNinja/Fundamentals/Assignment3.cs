using System;
using System.Collections.Generic;
namespace TestNinja.Fundamentals {
// Возвращает функцию подсчёта количества коробок с заданной вместимостью.
public class Assignment3 {
 public Func<int,int> GetPackagingCalculator(int boxCapacity) {
  if (boxCapacity <= 0) throw new ArgumentOutOfRangeException("boxCapacity");
  return itemCount => {
   if (itemCount < 0) throw new ArgumentOutOfRangeException("itemCount");
   return (itemCount + boxCapacity - 1) / boxCapacity;
  };
 }
}
}
