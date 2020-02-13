using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentRegistrationDemo2.Models
{
    public class Student : IEquatable<Student>
    {
        String name;
        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        int age;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        String registrationNumber;
        public String RegistrationNumber
        {
            get { return registrationNumber; }
            set { registrationNumber = value; }
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Student);
        }

        public bool Equals(Student other)
        {
            return other != null &&
                   name == other.name &&
                   age == other.age &&
                   registrationNumber == other.registrationNumber;
        }

        public override int GetHashCode()
        {
            var hashCode = -1570772789;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(name);
            hashCode = hashCode * -1521134295 + age.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(registrationNumber);
            return hashCode;
        }
    }
}