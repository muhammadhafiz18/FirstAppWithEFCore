using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyFirstApp.models
{
    public class Student
    {
        public int StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FathersName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Course { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
    }
}