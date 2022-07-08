using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Employee
    {
        public string Name { get; }
        public int Id { get; }
        public int Age { get; }

        public Employee(string name, int id, int age)
        {
            Name = name;
            Id = id;
            Age = age;
        }

       
        public string ElderEmployee(int tempAge)
        {


            return " ";         
        }
       public string GiveDetail(string tempName)
        {
          

            return " ";
        }


        public int Salary(int month)
        {
            int salary = month * 100;

            return salary;
        }
        public string Remark(int task)
        {
            if (task <= 0)

            {
                return "Start now you have completed " + task + " task";
            }
            else if (task > 0 && task < 10)
            {
                return "going alright";
            }
            else
            {
                return "very impressive";
            }

        }


    }
}
