using Domain.Models;
namespace Infrastructure.Services;

public class TeacherService
{
    List<Teacher> teachers =new List<Teacher>();
    public List<Teacher> GetTeachers()
    {
        return teachers;
    }
   public void AddTeachers(Teacher teacher)
    {
        teachers.Add(teacher);
    }
    public void UpdateTeachers(Teacher teacher)
    {
        foreach (var item in teachers)
        {
            if (item.Id == teacher.Id)
            {
                item.Firstname = teacher.Firstname;
                item.Lastname = teacher.Lastname;
                item.Position = teacher.Position;
                item.Experienceamount = teacher.Experienceamount;
            }
        }
    }
    public void Delete(int id)
    {
        foreach (var item in teachers)
        {
            if (id == item.Id)
            teachers.Remove(item);
        }
    }
}
