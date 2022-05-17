public class InDays : ISalaryCalculator<double>
{
    public double CalculateWorkingTime(EmployeeDetails employee)
    {
        return (employee.EnrollmentEnd-employee.EnrollmentStart).TotalDays; 
    }
}