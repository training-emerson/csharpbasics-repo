using EngineeringCollegeConsoleApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProfessorConsoleApp.Domain
{
    public class Professor : IPerson,ISalaried
    {
        public string Name { get; set; }

        public string Id { get; set; }

        public string EmailId { get; set; }

        public DateTime Dob { get; set; }

        public double BasicSalary { get; set; }

        //assumption of DA = 50%

        public double DA { get; set; }
        public double IBasicSalary { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double IDA { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Professor(string id, string name, string emailId, DateTime dob, double basicSalary, double da)
        {

            Id = id;
            Name = name;
            EmailId = emailId;
            Dob = dob;
            BasicSalary = basicSalary;
            DA = da;

        }


        public double CalculateSalary()
        {
            return BasicSalary * (1 + DA / 100);
        }

    }
}
