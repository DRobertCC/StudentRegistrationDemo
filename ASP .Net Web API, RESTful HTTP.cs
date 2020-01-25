ASP .Net Web Application Web API RESTful HTTP
	- First, create an ASP.NET Web Application (.NET Framework) project in Visual Studio (name, location).
	- Then Choose Web API!

https://dzone.com/articles/step-by-step-how-to-develop-a-restful-web-service

2. Now we will create the below resource classes for handling our GET, POST, PUT, and DELETE services. Right-click on the Models folder from the project explorer window and select Add=>Class "Student.cs"

3. Follow the above step 2 to create and add below two classes in Models folder:
	The first one is_"StudentRegistration", this is a singleton class, and it will hold the list of registered students including all the operations for GET, POST, PUT, and DELETE requests. 
	The second one is class StudentRegistrationReply, this class will be used to reply message to the client application as response.

4. Now is the time to introduce controller classes to handle GET, POST, PUT, and DELETE web requests. We will create separate controllers for GET, POST, PUT, and DELETE requests in this example even though it's not necessary, but I am using separate controllers for more clarity. Even one controller would suffice for all the above services, but as per good design principle, we should have a separate controller so that it’s easy to maintain and debug the application too.

	Let’s start with the GET and POST request first. Right-click on the Controllers folder and select    Add=>Controller.  From the below window, select Web API 2 Controller — Empty
		- Name the first controller_as "StudentRetriveController"
		- Now is the time to introduce a controller to handle a POST request. Just following step 4 and create "StudentRegistrationController"

https://localhost:44344
GET /api/studentretrive

POST /api/studentregistration
[
   {
      "Name": "Dave",
      "Age": 270,
      "RegistrationNumber": "12347"
   },
   {
      "Name": "Adam",
      "Age": 25,
      "RegistrationNumber": "12345"
   },
   {
      "Name": "Dave",
      "Age": 29,
      "RegistrationNumber": "12345"
   },
   {
      "Name": "Peter",
      "Age": 26,
      "RegistrationNumber": "12346"
   },
   {
      "Name": "Dave",
      "Age": 27,
      "RegistrationNumber": "12347"
   }
]

So far so good. Now we are going to complete our last part of this project by adding PUT and DELETE services. {z}

9. Follow step 4 and add two controllers respectively: "StudentUpdateController" and "StudentDeleteController".

	[Route("student/remove/{regdNum}")]
	Now, look at the above controller class. What kind of differences do you notice? Route: here, we are using Route to specifically mention the resource location. You might have a question about if we need to add multiple POST or GET services and how to differentiate between each method. No worries, we can do it like below:

	First with a different method signature:

	 GetAllStudents() {} //default 
	 GetStudent(Student object) {} 
	 GetStudentRec(String registrationNumber) {} 

	and by using Route: {z}

	 [Route("student/remove/{regdNum}")] 
	 public String DeleteStudent(String regdNum) {} // Have to use the same valueName as parameter (regdNum)!!!

	 [Route("student/removeall")] 
	 public String DeleteAllStudent() {} 

https://localhost:44344

PUT /api/studentupdate

DELETE /student/remove/12346