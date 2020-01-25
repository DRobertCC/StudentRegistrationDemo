using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using StudentRegistrationDemo2.Models;

namespace StudentRegistrationDemo2.Controllers
{
    // GET api/studentretrive
    public class StudentRetriveController : ApiController
    {
        public List<Student> GetAllStudents()
        {
            return StudentRegistration.getInstance().getAllStudent();
        }
    }
}// We don't need to exclusively mention whether it is a GET request method or not. It even does not require to mention the resource path. The Web API automatically considers it a GET request as the method name starts with a keyword "Get" (GetAllStudent) and in resource path, it will add "api" at the front and the name of the controller (all in small letters) at its back. So any GET call with resource path "/api/studentretrive" will invoke the above "GetAllStudents" method. But if you implement more than one GET method, you have to clearly mention the resource path.