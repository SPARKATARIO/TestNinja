using System;
using System.Linq;
using NUnit.Framework;
using TestNinja.Fundamentals;
namespace TestNinja.unitTests {
[TestFixture] public class Math_Lab2Tests {
 private Math_Lab2 _math;
 [SetUp] public void SetUp() { _math=new Math_Lab2(); }
 [TestCase(2,1,2)][TestCase(1,2,2)][TestCase(1,1,1)]
 public void Max_WhenCalled_ReturnsGreaterArgument(int a,int b,int expected) {
  Assert.That(_math.Max(a,b), Is.EqualTo(expected));
 }
 [TestCase(2,1,3)][TestCase(1,2,3)][TestCase(1,1,2)]
 public void Add_WhenCalled_ReturnsSumOfArguments(int a,int b,int expected) {
  Assert.That(_math.Add(a,b), Is.EqualTo(expected));
 }
 // Общее 1: заведомо неверное ожидание. Включить для демонстрации на защите.
 [TestCase(2,1,2)][Explicit("Демонстрация намеренно провального теста")]
 public void Add_IncorrectExpectedValue_Fails(int a,int b,int wrongExpected) {
  Assert.That(_math.Add(a,b), Is.EqualTo(wrongExpected));
 }
 [Test] public void GetOddNumbers_LimitFive_ReturnsOrderedUniqueOdds() {
  var result=_math.GetOddNumbers(5).ToArray();
  Assert.That(result, Is.EqualTo(new[]{1,3,5}));
  Assert.That(result, Is.Ordered);
  Assert.That(result, Is.Unique);
 }
}
}
