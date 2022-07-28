using TestPractice.EnumClass;


namespace TestPractice
{
    public class EvaluationDetails
    {

        List<Employee> allemployee;

        private  int totalEmployee;

        public int TotalEmployee
        {
            get { return totalEmployee; }
        }

        private double femaleEmployeePercentage;
        public double FemaleEmployeePercentage
        {
            get
            {
                //int FemaleEmployee = allemployee.Where(emp => emp.Gender == Gender.Female).Count();

                //femaleEmployeePercentage = FemaleEmployee.Percentage(TotalEmployee);

                return femaleEmployeePercentage;

            }
        }

        private double maleEmployeePercentage;

        public double MaleEmployeePercentage
        {
            get
            {
                //int MaleEmployee = allemployee.Where(emp => emp.Gender == Gender.Male).Count();

                //maleEmployeePercentage = MaleEmployee.Percentage(TotalEmployee);

                return maleEmployeePercentage;
            }
        }


        public EvaluationDetails(List<Employee> allemployee)

        {
            this.allemployee = allemployee;
            totalEmployee = allemployee.Count;
            maleEmployeePercentage= ((allemployee.Where(emp => emp.Gender == Gender.Male).Count()).Percentage(allemployee.Count));
            femaleEmployeePercentage= ((allemployee.Where(emp => emp.Gender == Gender.Female).Count()).Percentage(allemployee.Count));

        }


        public string EmployeeAvailabilityPercentage()
        {
           return "Total Employee : "+TotalEmployee+
            " Female Employee % : " +FemaleEmployeePercentage+
            " Male Employee % : "+MaleEmployeePercentage;

        }
    }
}















































