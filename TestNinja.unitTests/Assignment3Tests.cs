using System;
using System.Linq;
using NUnit.Framework;
using TestNinja.Fundamentals;
namespace TestNinja.unitTests {
[TestFixture] public class Assignment3Tests {
 private Assignment3 _store;
 [SetUp] public void SetUp() { _store = new Assignment3(); }
 // Проверяем возвращённую функцию: полная и неполная коробка, нулевое количество.
 [TestCase(5,11,3)][TestCase(10,20,2)][TestCase(8,0,0)]
 public void GetPackagingCalculator_ValidCapacity_CalculatesBoxes(int capacity,int items,int expected) {
  Func<int,int> calculator = _store.GetPackagingCalculator(capacity);
  Assert.That(calculator(items), Is.EqualTo(expected));
 }
 [Test] public void GetPackagingCalculator_DifferentCapacities_ProduceDifferentResults() {
  Assert.That(_store.GetPackagingCalculator(4)(9), Is.Not.EqualTo(_store.GetPackagingCalculator(5)(9)));
 }
 [Test] public void GetPackagingCalculator_ZeroCapacity_Throws() {
  Assert.That(() => _store.GetPackagingCalculator(0), Throws.TypeOf<ArgumentOutOfRangeException>());
 }
}
}
