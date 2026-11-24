using System;
using System.Linq;
using NUnit.Framework;
using TestNinja.Fundamentals;
namespace TestNinja.unitTests {
[TestFixture] public class Math_Lab1Tests {
 private Math_Lab1 _math;
 [SetUp] public void SetUp() { _math=new Math_Lab1(); }
 // Индивидуальное 1, вариант 17. Проверка фактической реализации из предыдущей работы.
 [TestCase(0,20,true)][TestCase(1,20,false)][TestCase(0,21,false)]
 public void IsSumDivisibleBy10_GivenInputs_ReturnsExpected(int a,int b,bool expected) {
  Assert.That(_math.IsSumDivisibleBy10(a,b), Is.EqualTo(expected));
 }
 // Специально неверное ожидание для демонстрации надёжности теста.
 [TestCase(0,20,false)][Explicit("Демонстрация намеренно провального теста")]
 public void IsSumDivisibleBy10_WrongExpectation_Fails(int a,int b,bool wrongExpected) {
  Assert.That(_math.IsSumDivisibleBy10(a,b), Is.EqualTo(wrongExpected));
 }
 // Дополнительный тест выявляет дефект приоритета операций в исходном методе.
 [TestCase(3,7,true)][Explicit("Дефект исходника: a+b%10 вместо (a+b)%10")]
 public void IsSumDivisibleBy10_MathematicalSumDivisibleByTen_ExposesBug(int a,int b,bool expected) {
  Assert.That(_math.IsSumDivisibleBy10(a,b), Is.EqualTo(expected));
 }
}
}
