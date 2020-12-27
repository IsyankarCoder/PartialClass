using System.Security.Cryptography.X509Certificates;
namespace PartialClass {
    public partial class Employee {
        public int EmpId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        
        public partial void GenerateEmployeeId();
        public partial void  Log();
    }
}