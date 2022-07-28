using TestPractice.EnumClass;
namespace TestPractice
{

    public class Program
    {
        public static void Main(string[] args)
        {
           
            List<Employee> allemployee = GetEmployeeDetails(); 

            Console.WriteLine("Enter the Age");
            int tempAge = Convert.ToInt32(Console.ReadLine());
            List<Employee> ListofElderAgeEmployee = ElderEmployee(allemployee, tempAge);
            foreach (Employee employee in ListofElderAgeEmployee)
            {
                Console.WriteLine(employee.Name + " " + employee.Id);
            }


           
            Console.WriteLine();
       

            Console.WriteLine("Enter the Name");
            string tempName = Console.ReadLine();
            List<Employee> ListOfEmployeeWithGivenName = GiveDetail(allemployee, tempName);
            foreach (Employee employee in ListOfEmployeeWithGivenName)
            {

                Console.WriteLine(employee);

            }
            Console.WriteLine();

            Console.WriteLine("Max Age is : " + allemployee.MaxAge());

            Console.WriteLine();

            Console.WriteLine("Do you want to arrange the employee names in alphabetical order (press Y if yes)");
            char ch = Convert.ToChar(Console.ReadLine());

            if (ch == 'Y')
            {
                List<Employee> AlphabeticEmployee = alphabeticallyorderednames(allemployee);

                foreach (Employee employee in AlphabeticEmployee)
                {
                    Console.WriteLine(employee);
                }
            }
            Console.WriteLine();

            Console.WriteLine("Name Of Employee Acc. to Department");
            Dictionary<Department, List<string>> DepartmentWiseEmployeeNames = EmployeeNameWithDepartment(allemployee);
            foreach (KeyValuePair<Department, List<string>> entry in DepartmentWiseEmployeeNames)
            {
                foreach (string names in entry.Value)
                    Console.WriteLine(entry.Key + " : " + names);
            }
            Console.WriteLine();
            Console.WriteLine("EvaluationDetail");
            Console.WriteLine();
            EvaluationDetails evaluationDetails = new EvaluationDetails(allemployee);
            Console.WriteLine(evaluationDetails.EmployeeAvailabilityPercentage());
        }





        public static List<Employee> GetEmployeeDetails()
        {
            List<Employee> EmployeeDetailist = new List<Employee>();

            char choice = 'Y';
            while (choice == 'Y')
            {
                Console.WriteLine("Enter the details");
                Console.WriteLine("Enter the name");
                string Name = Console.ReadLine();
                //Console.WriteLine("Enter the Id");
                //var Id = Guid.NewGuid();
                Console.WriteLine("Enter the age");
                int Age = Convert.ToInt32(Console.ReadLine());

                Gender gender = new Gender();

                while (gender != Gender.Female && gender != Gender.Male)
                {
                    try
                    {
                        Console.WriteLine("Enter Employee Gender:Female / Male");
                        string genderType = Console.ReadLine();

                        gender = (Gender)Enum.Parse(typeof(Gender), genderType);
                    }
                    catch
                    {
                        Console.WriteLine("Gender can be entered as Male and Female only");
                        continue;
                    }
                }
                Department department = new Department();

                while (department != Department.Software && department != Department.Sales && department != Department.Design && department != Department.Administration)
                {
                    try
                    {
                        Console.WriteLine("Enter Employee Department:(Software/Sales/Design/Administration)");
                        string dept = Console.ReadLine();

                        department = (Department)Enum.Parse(typeof(Department), dept);
                    }
                    catch
                    {
                        Console.WriteLine("Enter Department (Software/Sales/Design/Administration)");
                        continue;
                    }
                }
                EmployeeDetailist.Add(new Employee(Name, Age, gender, department));
                    Console.WriteLine("If you want to add more employee details press Y if not press N");
                    choice = Convert.ToChar(Console.ReadLine());
                    if (choice != 'Y' && choice != 'N')
                        Console.WriteLine("Press Y or N");
                }
            
            return EmployeeDetailist;
        }



        public static List<Employee> ElderEmployee(List<Employee> allemployee, int tempAge)
        {

            List<Employee> EmployeesWithHigherAge = new List<Employee>();
            foreach (Employee employee in allemployee)
            {
                if (employee.Age > tempAge)
                {
                    EmployeesWithHigherAge.Add(employee);
                }

            }

            return EmployeesWithHigherAge;
        }



        public static List<Employee> GiveDetail(List<Employee> allemployee, string tempName)
        {
            List<Employee> EmployeeWithGivenName = new List<Employee>();
            foreach (Employee employee in allemployee)
            {
                if (tempName == employee.Name)
                {
                    EmployeeWithGivenName.Add(employee);
                }
            }

            return EmployeeWithGivenName;
        }




        public static List<Employee> alphabeticallyorderednames(List<Employee> allemployee)
        {
            List<Employee> OrderedByNames = allemployee.OrderBy(employee => employee.Name).ToList();

            return OrderedByNames;
        }


        public static Dictionary<Department, List<string>> EmployeeNameWithDepartment(List<Employee> allemployee)
        {
            Dictionary<Department,List<string>> DepartmentWiseNames = new Dictionary<Department,List<string>>();
            List<string> EmployeeNames;
            foreach (Employee emp in allemployee)
            {
                if (DepartmentWiseNames.ContainsKey(emp.Department))
                {
                    DepartmentWiseNames[emp.Department].Add(emp.Name);
                }
                else
                {
                    EmployeeNames = new List<string>();

                    EmployeeNames.Add(emp.Name);
                    DepartmentWiseNames.Add(emp.Department, EmployeeNames);
                }
            }
            return DepartmentWiseNames;
        }

    }
}











//    foreach (Employee employee in allemployee)
//    {
//        if (employee.Age > tempAge)
//        {
//            Console.WriteLine($"The name is {employee.Name}");

//        }
//    }


//    Console.WriteLine("Enter the name of Employee");
//    string tempName = Console.ReadLine();
//    foreach (Employee employee in allemployee)
//    {
//        if (employee.Name == tempName)
//        {
//            Console.WriteLine($"The name is {employee.Name}");
//            Console.WriteLine($"Id : {employee.Id}");
//            Console.WriteLine($"Age : {employee.Age}");


//        }
//    }


//allemployee.Add(new Employee("Prathmesh", 1001, 26));
//allemployee.Add(new Employee("Abhinn", 1002, 23));
//allemployee.Add(new Employee("Bhavana", 1003, 23));
//allemployee.Add(new Employee("Aarati", 1004, 26));
//allemployee.Add(new Employee("Priyanka", 1005, 28));
//allemployee.Add(new Employee("Pavan", 1006, 24));

//Employee Emp1 = new Employee("Akash", 1011, 29);
//Console.WriteLine(Emp1.Name);
//Console.WriteLine(Emp1.Id);

//Console.WriteLine(Emp1.Salary(15));
//Console.WriteLine(Emp1.Remark(0));


//Gender gender = new Gender();
//while (gender != Gender.Female && gender != Gender.Male)
//{ 
//    try
//    {
//        Console.WriteLine("Enter Employee Gender:Female / Male");
//        string genderType = Console.ReadLine();
//        gender = (Gender)Enum.Parse(typeof(Gender), genderType);
//    }
//    catch
//    {
//        Console.WriteLine("Enter the gender either Male or Female ");
//        continue;
//    }
//}