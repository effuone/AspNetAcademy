public class InHours : ISalaryCalculator<double>
{
    public double CalculateWorkingTime(EmployeeDetails employee)
    {
        return (employee.EnrollmentEnd-employee.EnrollmentStart).TotalDays * 60;
    }
}