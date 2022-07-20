using TestPractice.EnumClass;
namespace TestPractice
{
    public class Employee
    {
        public string Name { get; }
        public int Id { get; }
        public int Age { get; }

        public Gender Gender { get; }

        public Employee(string name, int id, int age, Gender gender)
        {
            Name = name;
            Id = id;
            Age = age;
            Gender = gender;
        }






        public override string ToString()
        { return "Name = " + Name + " Id = " + Id + " Age = " + Age+ " Gender = " + Gender; }



















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
