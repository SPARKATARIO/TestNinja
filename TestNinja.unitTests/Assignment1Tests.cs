using System;
using System.Linq;
using NUnit.Framework;
using TestNinja.Fundamentals;
namespace TestNinja.unitTests {
[TestFixture] public class Assignment1Tests {
 private Assignment1 _store;
 [SetUp] public void SetUp() { _store = new Assignment1(); }
 // Проверяем просроченный товар, границу 0..3 и свежий товар.
 [TestCase(-1,"Expired")][TestCase(0,"ExpiringSoon")][TestCase(3,"ExpiringSoon")][TestCase(4,"Fresh")]
 public void GetProductFreshness_DaysLeft_ReturnsStatus(int days, string expected) {
  Assert.That(_store.GetProductFreshness(days), Is.EqualTo(expected));
 }
}
}
