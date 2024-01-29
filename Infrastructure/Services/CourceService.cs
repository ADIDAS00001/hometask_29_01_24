using Domain.Models;

namespace Infrastructure.Services;

public class CourseService
{
    List<Course> courses =new List<Course>();
    public List<Course> GetSCourses()
    {
        return courses;
    }
    public void AddCourses(Course course)
    {
        courses.Add(course);
    }
    public void UpdateCourses(Course course)
    {
        foreach (var item in courses)
        {
            if(item.Id==course.Id)
            {
                item.Title=course.Title;
                item.Description=course.Description;
                item.Fee=course.Fee;
                item.HasDiscount=course.HasDiscount;
            }
        }
    }
    public void Delete(int id)
    {
        foreach (var item in courses)
        {
            if(id == item.Id)
            {
                courses.Remove(item);
            }
        }
    }
}
