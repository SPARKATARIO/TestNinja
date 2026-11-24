using System;
using System.Linq;
using NUnit.Framework;
using TestNinja.Fundamentals;
namespace TestNinja.unitTests {
[TestFixture] public class Assignment5Tests {
 private Assignment5 _store;
 [SetUp] public void SetUp() { _store = new Assignment5(); }
 // Проверяем отрицательное, нулевое и чрезмерное значение.
 [TestCase(-1)][TestCase(0)][TestCase(101)]
 public void ValidateProductWeight_InvalidWeight_Throws(decimal weight) {
  Assert.That(() => _store.ValidateProductWeight(weight), Throws.TypeOf<ArgumentOutOfRangeException>());
 }
 [TestCase(1)][TestCase(100)] public void ValidateProductWeight_ValidWeight_ReturnsWeight(decimal weight) {
  Assert.That(_store.ValidateProductWeight(weight), Is.EqualTo(weight));
 }
}
}
