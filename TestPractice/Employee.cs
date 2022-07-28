using TestPractice.EnumClass;
namespace TestPractice
{
    public class Employee
    {
        public string Name { get; }
        public Guid Id { get; }
        public int Age { get; }

        public Department Department { get; }
        public Gender Gender { get; }

        public int maxAge

        {
            get
            {
               
                return 1;

            }
        }
        public Employee(string name, int age, Gender gender, Department department)
        {
            Name = name;
            
            Age = age;
            Gender = gender;
            Department = department;
        }

        public override string ToString()
        {
            return   "Name = " + Name + " Id = " + Id + " Age = " + Age + " Gender = " + Gender + " Department = "+Department;
        }


        //public string override ToString()
        //{ return Employee.ToString; }


        //public int Salary(int month)
        //{
        //    int salary = month * 100 + Id ;

        //    return salary;
        //}
        //public string Remark(int task)
        //{
        //    if (task <= 0)

        //    {
        //        return "Start now you have completed " + task + " task";
        //    }
        //    else if (task > 0 && task < 10)
        //    {
        //        return "going alright";
        //    }
        //    else
        //    {
        //        return "very impressive";
        //    }

        //}


    }
}
