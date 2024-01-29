using Domain.Models;

namespace Infrastructure.Services;

public class StudentServices
{
    List<Student> students =new List<Student>();
    public List<Student> GetStudents()
    {
        return students;
    }
    public void AddStudent(Student student)
    {
        students.Add(student);
    }
    public void UpdateStudent(Student student)
    {
        foreach (var item in students)
        {
            if(item.Id==student.Id)
            {
                item.Firstname = student.Firstname;
                item.Lastname = student.Lastname;
                item.Birthdate = student.Birthdate;
                item.Birthdate= item.Birthdate; 
            }
        }
    }
    public void Delete(int id)
    {
        foreach (var item in students)
        {
            if(id == item.Id)
            {   
                students.Remove(item);
            }
        }
    }
}
