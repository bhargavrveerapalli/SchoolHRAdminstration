using HRAdminstrationApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolHRAdminstration
{
     class Program
    {
        static void Main(string[] args)
        {
            //decimal totalsalaries = 0;
            List<IEmployee> employees = new List<IEmployee>();
            seeddata(employees);
            //foreach (IEmployee employee in employees)
            //{
            //    totalsalaries += employee.Salary;
            //}
            //Console.WriteLine($"Toatal Annaul Salaries(Including bonus) : {totalsalaries}");
            //Console.ReadKey();

            //Console.WriteLine($"Toatal Annaul Salaries(Including bonus) :{employees.Sum(e => e.Salary)}");
            //Console.ReadKey();
        }
        public static void seeddata(List<IEmployee> employees)
        {
            IEmployee teacher1 = new Teacher
            {
                Id = 1,
                FirstName = "Fathima",
                lastName = "shaik",
                Salary = 40000
            };
            employees.Add(teacher1);

            IEmployee teacher2 = new Teacher
            {
                Id = 2,
                FirstName = "Ramu",
                lastName = "Sk",
                Salary = 60000
            };
            employees.Add(teacher2);

            IEmployee teacher3 = new Teacher
            {
                Id = 3,
                FirstName = "Pathi",
                lastName = "Nid",
                Salary = 20909
            };
            employees.Add(teacher3);
            IEmployee teacher4 = new Teacher
            {

                Id = 4,
                FirstName = "Ganesh",
                lastName = "chinna",
                Salary = 90000
            };
            employees.Add(teacher4);

            IEmployee teacher5 = new Teacher
            {

                Id = 5,
                FirstName = "sudheer",
                lastName = null,
                Salary = 56000
            };
            employees.Add(teacher5);

            IEmployee headOfDepartment1 = new HeadOfDepartment
            {
                Id = 1,
                FirstName = "Sridhar",
                lastName = "Royal",
                Salary = 100000
            };
            employees.Add(headOfDepartment1);

            IEmployee headOfDepartment2 = new HeadOfDepartment
            {

                Id = 2,
                FirstName = "Surya",
                lastName = "Narayana",
                Salary = 238797
            };
            employees.Add(headOfDepartment2);

            IEmployee headOfDepartment3 = new HeadOfDepartment { Id = 3, FirstName = "Guru", lastName = "mashesh", Salary = 87667 };
            employees.Add(headOfDepartment3);

            IEmployee headOfDepartment4 = new HeadOfDepartment
            {
                Id = 4,
                FirstName = "varaun",
                lastName = "Chittot",
                Salary = 987908
            };
            employees.Add(headOfDepartment4);

            IEmployee headOfDepartment5 = new HeadOfDepartment
            {
                Id = 5,
                FirstName = "raju",
                lastName = "Poga",
                Salary = 798907
            };
            employees.Add(headOfDepartment5);

            IEmployee headMaster1 = new HeadMaster
            {
                Id = 1,
                FirstName = "Ashok",
                lastName = null,
                Salary = 696006
            };
            employees.Add(headMaster1);
            IEmployee headMaster2 = new HeadMaster
            {
                Id = 2,
                FirstName = "Krish",
                lastName = null,
                Salary = 800000

            };
            employees.Add(headMaster2);
            IEmployee headMaster3 = new HeadMaster
            {
                Id = 3,FirstName = "vinay",
                lastName= null,
                Salary = 990876
            };
            employees.Add(headMaster3);
            IEmployee headMaster4 = new HeadMaster { Id = 4, FirstName = "venu", lastName = null, Salary = 878976 };
            employees.Add(headMaster4);
            IEmployee headMaster5 = new HeadMaster
            {
                Id = 5,
                FirstName = "uday",
                lastName = "Kumar",
                Salary = 9038739
            };
            employees.Add(headMaster5);
        }
    }

    public class Teacher : EmployeeBase
    {
        public override decimal Salary { get => base.Salary + (base.Salary * 0.02m); }
    } 
    public class HeadOfDepartment : EmployeeBase
    {
        public override decimal Salary { get => base.Salary + (base.Salary * 0.03m); }
    }
    public class HeadMaster : EmployeeBase 
    {
        public override decimal Salary { get => base.Salary +( base.Salary *0.04m ); }
    }
}
