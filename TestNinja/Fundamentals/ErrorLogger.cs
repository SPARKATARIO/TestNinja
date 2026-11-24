using System;
using System.Collections.Generic;
namespace TestNinja.Fundamentals {
public class ErrorLogger {
 public string LastError { get; private set; }
 public void Log(string error) {
  if(string.IsNullOrWhiteSpace(error)) throw new ArgumentNullException("error");
  LastError=error;
 }
}
}
