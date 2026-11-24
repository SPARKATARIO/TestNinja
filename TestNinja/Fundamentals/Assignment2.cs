using System;
using System.Collections.Generic;
namespace TestNinja.Fundamentals {
// Возвращает последовательные номера полок для инвентаризации.
public class Assignment2 {
 public int[] GenerateShelfNumbers(int firstShelf, int count) {
  if (firstShelf < 1 || count < 0) throw new ArgumentOutOfRangeException();
  int[] shelves = new int[count];
  for (int i = 0; i < count; i++) shelves[i] = firstShelf + i;
  return shelves;
 }
}
}
