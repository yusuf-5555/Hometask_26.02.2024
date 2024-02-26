namespace Infrastructure.Services;
using Domain.Models;

public class TeacherService
{
    List<Teacher> _teacher = new();
    public List<Teacher> GetTeacher()
    {
        return _teacher;
    }
    public void AddTeacher(Teacher teacher)
    {
        _teacher.Add(teacher);
    }
    public void UpdateTeacher(Teacher teacher)
    {
        foreach (var item in _teacher)
        {
            if(item.id==teacher.id)
            {
                item.id=teacher.id;
                item.FirstName=teacher.FirstName;
                item.LastName=teacher.LastName;
                item.ExperienceAmount=teacher.ExperienceAmount;
                item.Position=teacher.Position;
            }
        }
    }
    public void Delete(int id)
    {
        foreach (var item in _teacher)
        {
            if(item.id==id)
            {
                _teacher.Remove(item);
                break;  
            }
        }
    }
}