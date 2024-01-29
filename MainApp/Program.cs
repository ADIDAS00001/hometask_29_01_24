using System.Runtime.CompilerServices;
using Domain.Models;
using Infrastructure.Services;

var student1=new Student();
student1.Id=1;
student1.Firstname="Shohrux";
student1.Lastname="Narziev";
student1.Birthdate=new DateTime(2003,12,04);
student1.Address="Sino";
var student2=new Student();
student2.Id=2;
student2.Firstname="icid";
student2.Lastname="sodmfl";
student2.Birthdate=new DateTime(2006,01,29);
student2.Address="Profsoyuz";
StudentServices student3=new StudentServices();
student3.AddStudent(student1);
student3.AddStudent(student2);
foreach (var item in student3.GetStudents())
{
    System.Console.WriteLine(item.Id);
    System.Console.WriteLine(item.Firstname);
    System.Console.WriteLine(item.Lastname);
    System.Console.WriteLine(item.Birthdate);
    System.Console.WriteLine(item.Address);
}
var updatestudent = new  Student();
updatestudent.Id=2;
updatestudent.Firstname="islom";
updatestudent.Lastname="adhf";
updatestudent.Birthdate=new DateTime(04,02,2006);
