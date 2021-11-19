using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JOB DETAILS
{
    class Job : IComparable
    {
        string role;
        string skillset;
        string emptype;
        string location;
        int exp;
        double sal;

        public Job()
        {
        }

        public Job(string role, string skillset, string emptype, string location, int exp, double sal)
        {
            Role = role;
            Skillset = skillset;
            Emptype = emptype;
            Location = location;
            Exp = exp;
            Sal = sal;
        }

        public string Role { get => role; set => role = value; }
        public string Skillset { get => skillset; set => skillset = value; }
        public string Emptype { get => emptype; set => emptype = value; }
        public string Location { get => location; set => location = value; }
        public int Exp { get => exp; set => exp = value; }
        public double Sal { get => sal; set => sal = value; }

        public int CompareTo(object obj)
        {
            Job j1 = (Job)obj;
            return this.Exp.CompareTo(j1.Exp);
        }

        public override string ToString()
        {
            return string.Format("Role : {0}\nSkillset : {1}\nEmptype : {2}\nLocation: {3}\nExp: {4}\nSal: {5}", Role, Skillset, Emptype, Location);
        }
    }
}