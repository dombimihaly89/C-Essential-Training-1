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
    }
}
