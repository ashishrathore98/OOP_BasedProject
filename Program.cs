class Program
{
    static void Main(string[] args)
    {
        RainbowSchoolSystem schoolSystem = new RainbowSchoolSystem();

        // Add sample data
        schoolSystem.AddStudent(new Student { Name = "Ashish", ClassSection = "A" });
        schoolSystem.AddStudent(new Student { Name = "Beena", ClassSection = "B" });

        schoolSystem.AddTeacher(new Teacher { Name = "Ronaldo", ClassSection = "A" });
        schoolSystem.AddTeacher(new Teacher { Name = "Messi", ClassSection = "B" });

        schoolSystem.AddSubject(new Subject { Name = "Math", SubjectCode = "MATH101", Teacher = (Teacher)schoolSystem.Teachers });
        schoolSystem.AddSubject(new Subject { Name = "Science", SubjectCode = "SCI101", Teacher = (Teacher)schoolSystem.Teachers });

        // Display students in a class
        schoolSystem.DisplayStudentsInClass("A");

        // Display subjects taught by a teacher
        schoolSystem.DisplaySubjectsTaughtByTeacher("Ms. Nikku");
    }
}
