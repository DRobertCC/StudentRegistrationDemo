using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentRegistrationDemo2.Models
{
    public class StudentRegistration // This is a singleton class, and it will hold the list of registered students including all the operations for GET, POST, PUT, and DELETE requests. 
    {
        List<Student> studentList;
        static StudentRegistration stdregd = null; // Singleton part1

        private StudentRegistration()
        {
            studentList = new List<Student>();
        }

        public static StudentRegistration getInstance() // Singleton part2
        {
            if (stdregd == null)
            {
                stdregd = new StudentRegistration();
                return stdregd;
            }
            else
            {
                return stdregd;
            }
        }

        public String Add(Student student) // POST
        {
            if (student == null)
            {
                return "Nothing to add";
            }
            for (int i = 0; i < studentList.Count; i++)
            {
                Student stdn = studentList.ElementAt(i);
                if (stdn.Equals(student))
                {
                    return "Student with these details is already exist";
                }
                if (stdn.RegistrationNumber.Equals(student.RegistrationNumber))
                {
                    return "This RegistrationNumber already exist";
                }
            }
            studentList.Add(student);
            return "Student successfuly added";
        }

        public List<Student> getAllStudent() // GET
        {
            return studentList;
        }

        public String UpdateStudent(Student student) // PUT
        {
            for (int i = 0; i < studentList.Count; i++)
            {
                Student stdn = studentList.ElementAt(i);
                if (stdn.RegistrationNumber.Equals(student.RegistrationNumber))
                {
                    if (stdn.Equals(student))
                    {
                        return "Nothing to change";
                    }
                    else
                    {
                        studentList[i] = student; // update with the new record
                        return "Update successful";
                    }
                }
            }
            return "Update un-successful";
        }

        public String Remove(String registrationNumber) // DELETE 
        {
            for (int i = 0; i < studentList.Count; i++)
            {
                Student stdn = studentList.ElementAt(i);
                if (stdn.RegistrationNumber.Equals(registrationNumber))
                {
                    studentList.RemoveAt(i);//update the new record
                    return "Delete successful";
                }
            }

            return "Delete un-successful";
        }

        public String RemoveAll() // DELETE
        {
            if (studentList.Count() > 0)
            {
                studentList.Clear();
                return "Successfully deleted All Student records";
            }
            return "Nothing to delete";
        }
    }
}