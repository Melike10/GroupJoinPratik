namespace GroupJoinPratik
{

    public class Program
    {
        public static void Main(string[] args)
        {
            List<Class> classes = new List<Class>() {
            new Class (1,"C#"),
            new Class (2,"Data Structure and Algorithm"),
            new Class (3,"Database Management")
            };

            List<Student> students = new List<Student>() { 
             new Student(1,"Ahmet",1),
             new Student (1,"Ahmet",2),
             new Student (1,"Ahmet",3),
             new Student(2,"Zeynep",1),
             new Student( 2 ,"Zeynep",3),
             new Student (3,"Melike",2),
             new Student(4,"Mustafa", 3),
             new Student (5,"Melis",1)
            };

            // group join ile dersleri ve onu alan öğrencileri birleştirdik
            var lessonsOfStudents = classes.GroupJoin(students,
                student => student.ClassId,
                lesson => lesson.ClassId,
                (lesson, StudentGroup) => new
                {
                  lesson= lesson,
                  student = StudentGroup.ToList()

                }
                );

            foreach (var item in lessonsOfStudents)
            {
                Console.WriteLine($"Ders: {item.lesson.ClassName}");
                foreach (var s in item.student)
                {
                    Console.WriteLine($"{s.StudentName}");
                }
            }


        }
    }
}
