using System;
using System.Linq;
using NUnit.Framework;
using TestNinja.Fundamentals;
namespace TestNinja.unitTests {
[TestFixture] public class ErrorLoggerTests {
 [Test] public void Log_ValidError_UpdatesLastError() {
  var logger=new ErrorLogger(); logger.Log("Ошибка склада");
  Assert.That(logger.LastError, Is.EqualTo("Ошибка склада"));
 }
 [TestCase(null)][TestCase("")][TestCase(" ")]
 public void Log_InvalidError_ThrowsArgumentNullException(string error) {
  Assert.That(() => new ErrorLogger().Log(error), Throws.TypeOf<ArgumentNullException>());
 }
}
}
