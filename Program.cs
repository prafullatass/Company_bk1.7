using System;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Praful = new Employee("Prafullata"," Sonawane");
            Praful.setStartDate(new DateTime(2015, 03,12));
            Praful.Title = "Founder";

            Employee Priya = new Employee("Priya" ,  "Shah");
            Priya.setStartDate(new DateTime(2015,12,12));
            Priya.Title = "Manager";

            Company Innovative = new Company("Innovative s/w");
            Innovative.setFoundedDate(new DateTime(2015,03,12));
            Innovative.Employees.Add(Praful);
            Innovative.Employees.Add(Priya);

            Console.WriteLine($@"
                {Innovative.getCompanyName()}
                Founded in {Innovative.getFoundedDate()}
                has Following Employees --
                ------------------------------------------------
            ");
            foreach (Employee emp in Innovative.Employees) {
                Console.WriteLine($@"
                {emp.getEmpName()} works as {emp.Title} since {emp.getStartDate()}.
                ");
            };

        }
    }
}
