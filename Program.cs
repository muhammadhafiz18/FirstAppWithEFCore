using MyFirstApp.context;
using MyFirstApp.models;

var context = new MyAppDbContext();

var student = new Student
{
    FirstName = "Muhammad",
    LastName = "Khodjaev",
    BirthDate = DateTime.Now,
    Course = "dotNet Bootcamp",
    Address = "Almazar District",
    City = "Tashkent",
    FathersName = "Fakhriddin"
};


context.Students?.Add(student);
context.SaveChanges();
