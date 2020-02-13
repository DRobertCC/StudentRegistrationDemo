using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using StudentRegistrationDemo2.Models;

namespace StudentRegistrationDemo2.Controllers
{
    public class StudentRegistrationController : ApiController
    {
        public StudentRegistrationReply registerStudent(Student studentToReg)
        {
            if (studentToReg != null)
            {
                Console.WriteLine("In registerStudent");
                StudentRegistrationReply stdregreply = new StudentRegistrationReply();
                String msg = StudentRegistration.getInstance().Add(studentToReg);
                stdregreply.Name = studentToReg.Name;
                stdregreply.Age = studentToReg.Age;
                stdregreply.RegistrationNumber = studentToReg.RegistrationNumber;
                stdregreply.RegistrationStatus = msg;

                return stdregreply;
            }
            return null;
        }
    }
}
