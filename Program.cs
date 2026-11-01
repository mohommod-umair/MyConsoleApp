class Student
{
    public int Id {get; set;}
    public string Name {get; set;}
    public int Age {get; set;}
}

class Program
{
    public static void Main()
    {
        List<Student> students = new List<Student>();
        
        while (true)
        {
         Console.WriteLine("\nWelcome to the Student Management System");
         Console.WriteLine("1. Add Student");
         Console.WriteLine("2. View Students");
         Console.WriteLine("3. Update Student");
         Console.WriteLine("4. Delete Student");
         Console.WriteLine("5. Exit");   

         
         Console.Write("\nSelect an Option: ");
         int choice = Convert.ToInt32(Console.ReadLine());

         // Add Student   
         if(choice == 1)
            {
                Student s = new Student();
                Console.Write("\nEnter Student Id: ");
                s.Id = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Name: ");
                s.Name = Console.ReadLine();

                Console.Write("Enter Age: ");
                s.Age = Convert.ToInt32(Console.ReadLine());

                students.Add(s);
                Console.WriteLine("\nStudent Added Sucessfully");
            }

          // View Students  
          if(choice == 2)
            {
                foreach(Student s in students)
                {
                    Console.WriteLine($"ID: {s.Id}, Name:{s.Name}, Age: {s.Age}");
                }
            }

          // Update Student  
          if(choice == 3)
            {
                Console.WriteLine("Enter Student Id to Update: ");
                int idToUpdate = Convert.ToInt32(Console.ReadLine());

                var student = students.FirstOrDefault(s=> s.Id == idToUpdate);

                if(student != null)
                {
                Console.WriteLine("Enter Name: ");
                student.Name = Console.ReadLine();

                Console.WriteLine("Enter Age: ");
                student.Age = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("Student Not Found");
                }
            }

            // Delete Student
            if(choice == 4)
            {
                Console.WriteLine("Enter ID to Delete: ");
                int idToDelete = Convert.ToInt32(Console.ReadLine());

                var student = students.FirstOrDefault(s=> s.Id == idToDelete);

                if(student != null)
                {
                    students.Remove(student);
                    Console.WriteLine("Student Deleted Sucessfully");
                }
                else
                {
                    Console.WriteLine("Student Not Found");
                }
            }

            // Exit
            if(choice == 5)
            {
                Console.WriteLine("Thank you for using the Application");
                break;
            }
        
        }     
    }
}

