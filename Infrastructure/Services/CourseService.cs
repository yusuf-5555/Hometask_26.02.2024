using Domain.Models;

namespace Infrastructure.Services;

public class CourseService
{
    List<Course> _course = new List<Course>();

    public List<Course> GetCourses()
    {
        return _course;
    } 
    public void AddCourses(Course course)
    {
        _course.Add(course);
    }
    public void UpdateCourse(Course course)
    {
        foreach (var item in _course)
        {
            if(item.Id == course.Id)
            {
                item.Id=course.Id;
                item.Title=course.Title;
                item.Description=course.Description;
                item.Fee=course.Fee;
                item.HasDiscount=course.HasDiscount;
            }
        }
    }
    public void DeleteCourse(int id)
    {
        foreach (var item in _course)
        {
            if(item.Id==id)
            {
                _course.Remove(item);
                break;
            }
        }
    }
}