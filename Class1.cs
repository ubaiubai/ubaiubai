using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class1

{
    class company
    {
        
        string name;
        string sector;
        string location;
        int age;


        
        public string Name { get => name; set => name = value; }
        public string Sector { get => sector; set => sector = value; }
        public string Location { get => location; set => location = value; }
        public int Age { get => age; set => age = value; }

        //Parameterized constructor
        public company(string name, string sector, string location, int age)
        {
            this.name = name;
            this.sector = sector;
            this.location = location;
            this.age = age;
        }
        company()
        {

        }

        public override bool Equals(object obj)
        {
            company com = (company)obj;
            return this.name.Equals(com.name) && this.location.Equals(com.location);
        }




        
        public override string ToString()
        {
            return String.Format("name is {0} \n sector is {1} \n location is : {2} \n age is : {3}", name, sector, location, age);
        }

        
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static company GetCompanyDetails(String comaccdetails)
        {
            string[] c = comaccdetails.Split(',');
            company com_details = new company(c[0], c[1], c[2], int.Parse(c[3]));
            return com_details;
        }


    }
}