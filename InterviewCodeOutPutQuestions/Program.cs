using System.Xml.Linq;

namespace InterviewCodeOutPutQuestions
{
    internal class Program
    {
        //public delegate int PerformCalculation(int x, int y);
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>() {
                new Student() { Id = 1, Name = "Stud 1", Standard = 1 },
                new Student() { Id = 2, Name = "Stud 2", Standard = 1 },
                new Student() { Id = 3, Name = "Stud 3", Standard = 2 },
                new Student() { Id = 4, Name = "Stud 4", Standard = 3 },
            };

            var result1 = students.Where(i => i.Id == 3).ToList(); //wrong
            var result2 = students.Where(s => s.Id == 3).Select(s => new Student { Id=s.Id,Name=s.Name }); //wrong
            var result3 = students.Where(i=>i.Id==3).FirstOrDefault(); //correct answewr to get the 

            // Get the student with Id = 3
            var result4 = students.FirstOrDefault(s => s.Id == 3);

            //get me list of string which contains the name of all student 
            var result5 = students.Select(s => s.Name).ToList();


            // Get a list of strings containing the names of all students
            var studentNames = students
                                .Select(s => s.Name)   // Project to names
                                .OfType<string>()      // Ensure type is string
                                .ToList();


            //// Create an instance of the delegate, pointing to the MyMethod
            //PerformCalculation del = new PerformCalculation(Add);

            //// Invoke the delegate
            //var result5 = del(10, 20);


            //// Using lambda expression
            //PerformCalculation del4 = (x, y) => x / y;
            //var divResult = del4(15, 3);
            //Console.WriteLine(divResult);



            int temp = 1;
            temp += 1;
            Console.WriteLine(temp);
            temp = -1;
            Console.WriteLine(temp);
            temp = 2;
            Console.WriteLine(temp);

        }
        static public int Add(int a, int b)
        {
            return a + b;
        }
    }


    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Standard { get; set; }
    }
}
