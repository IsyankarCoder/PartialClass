using System;
namespace PartialClass
{
    public partial class Employee
    {
        public Employee(int Id, string Name)
        {
            this.EmpId = Id;
            this.FirstName = Name;
        }
        public void DisplayEmployeeInfo()
        {
            Console.WriteLine(this.EmpId + " " +this.FirstName + " " + this.LastName);
        }

        public void Save(int id, string firstName, string lastName)
        {
            Console.WriteLine("Saved!");
        }
         public partial void GenerateEmployeeId()
        {
            this.EmpId = 150;
        }
        

       
    }
}