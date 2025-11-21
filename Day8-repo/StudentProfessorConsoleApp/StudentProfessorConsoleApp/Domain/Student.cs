using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProfessorConsoleApp.Domain
{
    public class Student : IPerson
    {
        

        public string Name { get ; set ; }
        public string Id { get  ; set  ; }
        public string EmailId { get; set; }
        public DateTime Dob { get; set; }

        public string Branch { get; set; }


        public Student(string id, string name, string emailid, DateTime dob, string branch)
        {

            Name = name;
            Id = id;
            EmailId = emailid;
            Dob = dob;
            Branch = branch;


        }
    }
}
