using System;
using System.Collections.Generic;
namespace TestNinja.Fundamentals {
public class ActionResult {}
public class NotFound : ActionResult {}
public class Ok : ActionResult {}
public class CustomerController {
 public ActionResult GetCustomer(int id) {
  if(id<0) throw new ArgumentOutOfRangeException("id");
  return id==0 ? (ActionResult)new NotFound() : new Ok();
 }
}
}
