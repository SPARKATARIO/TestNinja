using System;
using System.Linq;
using NUnit.Framework;
using TestNinja.Fundamentals;
namespace TestNinja.unitTests {
[TestFixture] public class Assignment2Tests {
 private Assignment2 _store;
 [SetUp] public void SetUp() { _store = new Assignment2(); }
 // Проверяем порядок и точный состав массива, включая пустой результат.
 [TestCase(1,3,new int[]{1,2,3})][TestCase(5,2,new int[]{5,6})]
 public void GenerateShelfNumbers_ValidRange_ReturnsSequentialArray(int first, int count, int[] expected) {
  Assert.That(_store.GenerateShelfNumbers(first,count), Is.EqualTo(expected));
 }
 [Test] public void GenerateShelfNumbers_ZeroCount_ReturnsEmptyArray() {
  Assert.That(_store.GenerateShelfNumbers(3,0), Is.Empty);
 }
 [TestCase(0,2)][TestCase(1,-1)] public void GenerateShelfNumbers_InvalidRange_Throws(int first,int count) {
  Assert.That(() => _store.GenerateShelfNumbers(first,count), Throws.TypeOf<ArgumentOutOfRangeException>());
 }
}
}
