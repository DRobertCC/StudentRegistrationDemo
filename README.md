# The back-end of a RESTful Web Application in ASP .Net with Web API 2 and Singleton 'DB'

## A simple app with CRUD operations to handle Student details.

### Example usage:
```
GET: /api/studentretrive

POST: /api/studentregistration
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

PUT: /api/studentupdate

DELETE: /student/remove/12346
DELETE: /student/removeall
```

## About

This app was written by a Codecooler, Róbert Dancsó from Miskolc.
