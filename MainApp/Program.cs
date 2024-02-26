using Domain.Models;
using Infrastructure.Services;
using Insrastructure.Services;

var student1 = new Student();
student1.id = 1;
student1.FirstName = "Yusuf";
student1.LastName = "Rahmon";
student1.BirthDate = new DateTime();
student1.Address = "Mayak 15";

var student2 = new Student();
student2.id = 2;
student2.FirstName = "Islom";
student2.LastName = "Saidov";
student2.BirthDate = new DateTime();
student2.Address = "Mayak 20";

var student3 = new Student();
student3.id = 3;
student3.FirstName = "Behruz";
student3.LastName = "Xalilov";
student3.BirthDate = new DateTime();
student3.Address = "Mayak 5";

var student4 = new Student();
student4.id = 4;
student4.FirstName = "Usmonali";
student4.LastName = "Hakimov";
student4.BirthDate = new DateTime();
student4.Address = "Mayak 65";

var student5 = new Student();
student5.id = 2;
student5.FirstName = "Safarali";
student5.LastName = "Hakimov";
student5.BirthDate = new DateTime();
student5.Address = "Sino 2";

var stService = new StudentService();
stService.AddStudent(student1);
stService.AddStudent(student2);
stService.AddStudent(student3);
stService.AddStudent(student4);
stService.UpdateStudent(student5);
stService.Delete(3);

foreach (var item in stService.GetStudents())
{
    System.Console.WriteLine(item.id);
    System.Console.WriteLine(item.FirstName);
    System.Console.WriteLine(item.LastName);
    System.Console.WriteLine(item.BirthDate);
    System.Console.WriteLine(item.Address);
    System.Console.WriteLine("--------------------------");
}


var teacher1 = new Teacher();
teacher1.id=1;
teacher1.FirstName = "Said";
teacher1.LastName = "Saidov";
teacher1.ExperienceAmount = 5;
teacher1.Position = "high";

var teacher2 = new Teacher();
teacher2.id=2;
teacher2.FirstName = "Said";
teacher2.LastName = "Saidov";
teacher2.ExperienceAmount = 5;
teacher2.Position = "high";

var teacher3 = new Teacher();
teacher3.id=3;
teacher3.FirstName = "Said";
teacher3.LastName = "Saidov";
teacher3.ExperienceAmount = 5;
teacher3.Position = "high";

var teacher4 = new Teacher();
teacher4.id=4;
teacher4.FirstName = "Said";
teacher4.LastName = "Saidov";
teacher4.ExperienceAmount = 5;
teacher4.Position = "high";

var teacher5 = new Teacher();
teacher5.id = 3;
teacher5.FirstName = "Hello";
teacher5.LastName = "World";
teacher5.ExperienceAmount = 10;
teacher5.Position = "Low";

var tService = new TeacherService();
tService.AddTeacher(teacher1);
tService.AddTeacher(teacher2);
tService.AddTeacher(teacher3);
tService.AddTeacher(teacher4);
tService.UpdateTeacher(teacher5);
tService.Delete(1);

foreach (var item in tService.GetTeacher())
{
    System.Console.WriteLine(item.id);
    System.Console.WriteLine(item.FirstName);
    System.Console.WriteLine(item.LastName);
    System.Console.WriteLine(item.ExperienceAmount);
    System.Console.WriteLine(item.Position);
    System.Console.WriteLine("---------------------------");
}



