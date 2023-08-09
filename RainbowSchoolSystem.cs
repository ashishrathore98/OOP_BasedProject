using System;
using System.Collections.Generic;

public class RainbowSchoolSystem
{
    private List<Student> students = new List<Student>();
    private List<Teacher> teachers = new List<Teacher>();
    private List<Subject> subjects = new List<Subject>();

    public object Teachers { get; internal set; }

    public void AddStudent(Student student)
    {
        students.Add(student);
    }

    public void AddTeacher(Teacher teacher)
    {
        teachers.Add(teacher);
    }

    public void AddSubject(Subject subject)
    {
        subjects.Add(subject);
    }

    public void DisplayStudentsInClass(string classSection)
    {
        Console.WriteLine($"Students in class {classSection}:");
        foreach (var student in students)
        {
            if (student.ClassSection == classSection)
            {
                Console.WriteLine($"- {student.Name}");
            }
        }
    }

    public void DisplaySubjectsTaughtByTeacher(string teacherName)
    {
        Console.WriteLine($"Subjects taught by {teacherName}:");
        foreach (var subject in subjects)
        {
            if (subject.Teacher.Name == teacherName)
            {
                Console.WriteLine($"- {subject.Name}");
            }
        }
    }
}
