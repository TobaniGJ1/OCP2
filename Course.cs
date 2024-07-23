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
        // Código para suscribirse a un curso en línea
        Console.WriteLine($"{std.Name} se ha suscrito al curso en línea: {Title}");
    }
}

public class OfflineCourse : Course
{
    public override void Subscribe(Student std)
    {
        // Código para suscribirse a un curso presencial
        Console.WriteLine($"{std.Name} se ha suscrito al curso presencial: {Title}");
    }
}

public class HybridCourse : Course
{
    public override void Subscribe(Student std)
    {
        // Código para suscribirse a un curso híbrido
        Console.WriteLine($"{std.Name} se ha suscrito al curso híbrido: {Title}");
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
        Course onlineCourse = new OnlineCourse { CourseId = 1, Title = "Curso de Programación en Línea" };
        Course offlineCourse = new OfflineCourse { CourseId = 2, Title = "Curso de Programación Presencial" };
        Course hybridCourse = new HybridCourse { CourseId = 3, Title = "Curso de Programación Híbrido" };

        // Crear instancia de estudiante
        Student student = new Student("Tobani Gonzalez");

        // Suscribir estudiante a los cursos
        onlineCourse.Subscribe(student);
        offlineCourse.Subscribe(student);
        hybridCourse.Subscribe(student);
    }
}