using System;

namespace PartialClass
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee e = new Employee(10, "Volkan");
            e.DisplayEmployeeInfo();
            e.Save(15, "Volkan", "Genç");
            e.GenerateEmployeeId();
            e.Log();

        }
    }
}
