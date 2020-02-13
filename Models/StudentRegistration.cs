using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentRegistrationDemo2.Models
{
    public class StudentRegistration
    {
        List<Student> studentList;
        static StudentRegistration stdregd = null;

        private StudentRegistration()
        {
            studentList = new List<Student>();
        }

        public static StudentRegistration getInstance()
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

        public String Add(Student student)
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

        public List<Student> getAllStudent()
        {
            return studentList;
        }

        public String UpdateStudent(Student student)
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
                        studentList[i] = student;
                        return "Update successful";
                    }
                }
            }
            return "Update un-successful";
        }

        public String Remove(String registrationNumber)
        {
            for (int i = 0; i < studentList.Count; i++)
            {
                Student stdn = studentList.ElementAt(i);
                if (stdn.RegistrationNumber.Equals(registrationNumber))
                {
                    studentList.RemoveAt(i);
                    return "Delete successful";
                }
            }

            return "Delete un-successful";
        }

        public String RemoveAll()
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