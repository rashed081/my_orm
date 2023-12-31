﻿using Assignment4;
using System.Data.SqlClient;
using System.Net;
using System.Numerics;
using System.Text;

#region
Course course = new Course
{
    id = 1,
    Title = "Programming 101",
    Fees = 1000.0,
    instructor = new Instructor
    {
        id = 1,
        Name = "John Doe",
        Email = "johndoe@example.com",
        PresentAddress = new Address
        {
            id = 1,
            Street = "123 Main St",
            City = "Anytown",
            Country = "USA"
        },
        PermanentAddress = new Address
        {
            id = 2,
            Street = "456 Oak Ave",
            City = "Anytown",
            Country = "USA"
        },
        PhoneNumbers = new List<Phone>
        {
            new Phone
            {
                id = 1,
                Number = "123-456-7890",
                Extension = "123",
                CountryCode = "+1"
            }
        }
    },
    Topics = new List<Topic>
    {
        new Topic
        {
            id = 1,
            Title = "Introduction to Programming",
            Description = "An introduction to programming concepts and best practices",
            Sessions = new List<Session>
            {
                new Session
                {
                    id = 1,
                    DurationInHour = 2,
                    LearningObjective = "Understanding programming fundamentals"
                },
                new Session
                {
                    id = 2,
                    DurationInHour = 2,
                    LearningObjective = "Variables and data types"
                }
            }
        },
        new Topic
        {
            id = 2,
            Title = "Advanced Programming",
            Description = "Advanced topics in programming such as algorithms and data structures",
            Sessions = new List<Session>
            {
                new Session
                {
                    id = 3,
                    DurationInHour = 2,
                    LearningObjective = "Understanding algorithms and their efficiency"
                },
                new Session
                {
                    id = 4,
                    DurationInHour = 2,
                    LearningObjective = "Data structures and their implementation"
                }
            }
        }
    },
    Tests = new List<AdmissionTest>
    {
        new AdmissionTest
        {
            id = 1,
            StartDateTime = new DateTime(2023, 5, 1, 9, 0, 0),
            EndDateTime = new DateTime(2023, 5, 1, 11, 0, 0),
            TestFees = 50.0
        },
        new AdmissionTest
        {
            id = 2,
            StartDateTime = new DateTime(2023, 5, 8, 9, 0, 0),
            EndDateTime = new DateTime(2023, 5, 8, 11, 0, 0),
            TestFees = 50.0
        }
    }
};
#endregion

#region
Course course2 = new Course
{
    id = 2,
    Title = "Web Development Bootcamp",
    Fees = 2500.0,
    instructor = new Instructor
    {
        id = 2,
        Name = "Jane Smith",
        Email = "janesmith@example.com",
        PresentAddress = new Address
        {
            id = 3,
            Street = "789 Elm St",
            City = "Anytown",
            Country = "USA"
        },
        PermanentAddress = new Address
        {
            id = 4,
            Street = "123 Pine Ave",
            City = "Anytown",
            Country = "USA"
        },
        PhoneNumbers = new List<Phone>
        {
            new Phone
            {
                id = 2,
                Number = "555-555-1212",
                Extension = "555",
                CountryCode = "+1"
            },
            new Phone
            {
                id = 3,
                Number = "555-555-1213",
                Extension = "556",
                CountryCode = "+1"
            }
        }
    },
    Topics = new List<Topic>
    {
        new Topic
        {
            id = 3,
            Title = "HTML and CSS Basics",
            Description = "An introduction to the basics of web development with HTML and CSS",
            Sessions = new List<Session>
            {
                new Session
                {
                    id = 5,
                    DurationInHour = 3,
                    LearningObjective = "Creating and styling web pages with HTML and CSS"
                },
                new Session
                {
                    id = 6,
                    DurationInHour = 3,
                    LearningObjective = "Responsive design and mobile-first development"
                }
            }
        },
        new Topic
        {
            id = 4,
            Title = "JavaScript and Frontend Frameworks",
            Description = "Advanced topics in frontend web development with JavaScript and popular frameworks",
            Sessions = new List<Session>
            {
                new Session
                {
                    id = 7,
                    DurationInHour = 3,
                    LearningObjective = "Introduction to JavaScript and DOM manipulation"
                },
                new Session
                {
                    id = 8,
                    DurationInHour = 3,
                    LearningObjective = "React, Angular, and Vue frameworks"
                }
            }
        }
    },
    Tests = new List<AdmissionTest>
    {
        new AdmissionTest
        {
            id = 3,
            StartDateTime = new DateTime(2023, 6, 1, 9, 0, 0),
            EndDateTime = new DateTime(2023, 6, 1, 11, 0, 0),
            TestFees = 75.0
        },
        new AdmissionTest
        {
            id = 4,
            StartDateTime = new DateTime(2023, 6, 8, 9, 0, 0),
            EndDateTime = new DateTime(2023, 6, 8, 11, 0, 0),
            TestFees = 75.0
        }
    }
};


#endregion

//InsertOperation i1 = new InsertOperation();
//i1.InsertObjectIntoDb(course2, null, null);

string _connection = "Server=DESKTOP-86V0L02;Database=assignment_4;Trusted_Connection=True;";


//List<Dictionary<string, object>> result = DataExtractor.ExtractAllData(course, null);
//DataPrinter dp1 = new DataPrinter();
//dp1.PrintData(result);

//DeleteOperation obj1 = new DeleteOperation();
//obj1.DeleteObjectById("1");

MyORM<Guid, Course> orm = new MyORM<Guid, Course>();
course2.Fees = 25000000;
orm.Update(course2);


