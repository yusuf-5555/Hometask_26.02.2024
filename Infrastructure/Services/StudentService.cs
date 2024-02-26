namespace Insrastructure.Services;
using Domain.Models;

public class StudentService
{
    List<Student> _students = new();
    public List<Student> GetStudents()
    {
        return _students;
    }
    public void AddStudent(Student student)
    {
        _students.Add(student);
    }
    public void UpdateStudent(Student student)
    {
        foreach (var item in _students)
        {
            if(item.id==student.id)
            {
                item.FirstName=student.FirstName;
                item.LastName=student.LastName;
                item.id=student.id;
                item.BirthDate=student.BirthDate;
                item.Address=student.Address;
            }
        }
    }
    public void Delete(int id)
    {
        foreach (var item in _students)
        {
            if(item.id==id)
            {
                _students.Remove(item);
                break;
            }
        }
    }
}