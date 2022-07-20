namespace TestPractice
{
    public static class ExtensionMethod
    {
        public static int MaxAge(this List<Employee> allemployee)
        {

            int max_age = 0;
            foreach (Employee emp in allemployee)
            {

                if (emp.Age > max_age)
                {
                    max_age = emp.Age;
                }


            }
            return max_age;
        }

        public static double Percentage(this int a, int b)
        {
            double Percentage = (a * 100) / b;
            return Percentage;

        }
    }
}
