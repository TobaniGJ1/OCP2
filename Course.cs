using System;

public abstract class Course
{
    public int CourseId { get; set; }
    public string Title { get; set; }

    public abstract void Subscribe(Student std);
}

public class OnlineCourse : Course
{
    public override void Subscribe(Student std)
    {
        // C�digo para suscribirse a un curso en l�nea
        Console.WriteLine($"{std.Name} se ha suscrito al curso en l�nea: {Title}");
    }
}

public class OfflineCourse : Course
{
    public override void Subscribe(Student std)
    {
        // C�digo para suscribirse a un curso presencial
        Console.WriteLine($"{std.Name} se ha suscrito al curso presencial: {Title}");
    }
}

public class HybridCourse : Course
{
    public override void Subscribe(Student std)
    {
        // C�digo para suscribirse a un curso h�brido
        Console.WriteLine($"{std.Name} se ha suscrito al curso h�brido: {Title}");
    }
}

public class Student
{
    public string Name { get; set; }

    public Student(string name)
    {
        Name = name;
    }
}

class Program
{
    static void Main()
    {
        // Crear instancias de cursos
        Course onlineCourse = new OnlineCourse { CourseId = 1, Title = "Curso de Programaci�n en L�nea" };
        Course offlineCourse = new OfflineCourse { CourseId = 2, Title = "Curso de Programaci�n Presencial" };
        Course hybridCourse = new HybridCourse { CourseId = 3, Title = "Curso de Programaci�n H�brido" };

        // Crear instancia de estudiante
        Student student = new Student("Tobani Gonzalez");

        // Suscribir estudiante a los cursos
        onlineCourse.Subscribe(student);
        offlineCourse.Subscribe(student);
        hybridCourse.Subscribe(student);
    }
}