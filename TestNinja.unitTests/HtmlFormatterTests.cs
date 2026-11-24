using System;
using System.Linq;
using NUnit.Framework;
using TestNinja.Fundamentals;
namespace TestNinja.unitTests {
[TestFixture] public class HtmlFormatterTests {
 [Test] public void FormatAsBold_WhenCalled_WrapsContent() {
  var result=new HtmlFormatter().FormatAsBold("abc");
  Assert.That(result, Does.StartWith("<strong>").IgnoreCase);
  Assert.That(result, Does.Contain("abc"));
  Assert.That(result, Does.EndWith("</strong>").IgnoreCase);
 }
}
}
