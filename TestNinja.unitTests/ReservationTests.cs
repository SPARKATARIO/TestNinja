using System;
using System.Linq;
using NUnit.Framework;
using TestNinja.Fundamentals;
namespace TestNinja.unitTests {
[TestFixture] public class ReservationTests {
 [Test] public void CanBeCancelledBy_Admin_ReturnsTrue() {
  var reservation=new Reservation(); var user=new User { IsAdmin=true };
  Assert.That(reservation.CanBeCancelledBy(user), Is.True);
 }
 [Test] public void CanBeCancelledBy_Creator_ReturnsTrue() {
  var user=new User(); var reservation=new Reservation { MadeBy=user };
  Assert.That(reservation.CanBeCancelledBy(user), Is.True);
 }
 [Test] public void CanBeCancelledBy_Stranger_ReturnsFalse() {
  var reservation=new Reservation { MadeBy=new User() };
  Assert.That(reservation.CanBeCancelledBy(new User()), Is.False);
 }
}
}
