using System;

var employee = new EmployeeDetails()
{
    EmployeeId=1, 
    EnrollmentEnd = DateTime.Now, 
    EnrollmentStart = new DateTime(2018,9,1)};
var inDays = new InDays();
var inHours = new InHours();
var inYears = new InYears();
Console.WriteLine(inHours.CalculateWorkingTime(employee));
Console.WriteLine(inDays.CalculateWorkingTime(employee));
Console.WriteLine(inYears.CalculateWorkingTime(employee));