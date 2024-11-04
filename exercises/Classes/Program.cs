using System;
using System.Collections.Generic;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of a company. Name it whatever you like.
        //     //rmbr from Company.cs:// Company has some readonly properties (let's talk about gets, baby)
        // public string Name { get; }
        // public DateTime CreatedOn { get; }
Company myCompany = new Company ("Anonymous Inc.", new DateTime(2020,1,1,9,0,0)); //Name it whatever you like.
            
            
        // Create three employees
        //rmbr from Employee.cs:An employee has the following properties.
        // First name (string)
        // Last name (string)
        // Title (string)
        // Start date (DateTime)

        Employee employee1 = new Employee("Fiona","Wee","Treasurer",new DateTime(2024-7-22));
        Employee employee2 = new Employee("Michael","Mullins","Manager",new DateTime(2023-7-22));
        Employee employee3 = new Employee("Dana","Marlowe","Secretary",new DateTime(2022-7-22));


            // Assign the employees to the company
        myCompany.Employees.Add(employee1);
        myCompany.Employees.Add(employee2);
        myCompany.Employees.Add(employee3);     
        /*
                Iterate the company's employee list and generate the
                simple report shown above:such as "Jane Doe works for Acme, Inc. as Lion Tamer since 3/23/15."
            */
        myCompany.ListEmployees();
            //or: 
            //foreach(Employee employee in myCompany.Employees){
            // Console.WriteLine($"{employee.FirstName} {employee.LastName} works for {myCompany.Name} as {employee.Title} since {employee.StartDate.ToShortDateString()}.");
        }
    }
}



//In the Main method of your console application, create a new instance of Company, and three instances of Employee. Then assign the employees to the company.