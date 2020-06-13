using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
    public abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        // We can put abstract methods not just only in absctract classes.
        // You have to implement abstract methods in child classes.
        public abstract float ComputeGradeAverage();

        // We can use virtual methods in base classes if we want the capability to override it in
        // a subclass. If the method is not abstract nor virtual then we cannot override them.
        // The difference between them is that you cannot implement an abstract method.
        public virtual string SendMessage(string message)
        {
            var sb = new StringBuilder();
            var timeStamp = string.Format("Sent on {0:D} at {0:t}", DateTime.Now);
            sb.AppendLine(timeStamp);
            sb.AppendLine("");
            sb.AppendLine("Dear " + FirstName + ",");
            sb.AppendLine(message);
            return sb.ToString();
        }
    }
}
