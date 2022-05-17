public class InYears : ISalaryCalculator<double>
{
    public double CalculateWorkingTime(EmployeeDetails employee)
    {
        return employee.EnrollmentEnd.Year - employee.EnrollmentStart.Year;
    }
}