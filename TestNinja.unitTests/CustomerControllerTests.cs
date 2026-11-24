using System;
using System.Linq;
using NUnit.Framework;
using TestNinja.Fundamentals;
namespace TestNinja.unitTests {
[TestFixture] public class CustomerControllerTests {
 [Test] public void GetCustomer_IdZero_ReturnsNotFound() {
  Assert.That(new CustomerController().GetCustomer(0), Is.TypeOf<NotFound>());
 }
 [Test] public void GetCustomer_PositiveId_ReturnsOk() {
  Assert.That(new CustomerController().GetCustomer(1), Is.TypeOf<Ok>());
 }
 [Test] public void GetCustomer_NegativeId_Throws() {
  Assert.That(() => new CustomerController().GetCustomer(-1), Throws.TypeOf<ArgumentOutOfRangeException>());
 }
}
}
