using System;
using System.Linq;
using NUnit.Framework;
using TestNinja.Fundamentals;
namespace TestNinja.unitTests {
[TestFixture] public class Assignment4Tests {
 // Для void проверяем изменившееся свойство, а не возвращаемое значение.
 [TestCase(5,3,8)][TestCase(0,10,10)][TestCase(10,1,11)]
 public void RestockProduct_ValidAmount_IncreasesStock(int initial,int amount,int expected) {
  var store = new Assignment4(initial);
  store.RestockProduct(amount);
  Assert.That(store.StockQuantity, Is.EqualTo(expected));
 }
 [Test] public void RestockProduct_InvalidAmount_DoesNotChangeStock() {
  var store = new Assignment4(7);
  Assert.That(() => store.RestockProduct(0), Throws.TypeOf<ArgumentOutOfRangeException>());
  Assert.That(store.StockQuantity, Is.EqualTo(7));
 }
}
}
