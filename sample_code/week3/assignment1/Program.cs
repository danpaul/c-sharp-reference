using System.Xml.Linq;

namespace assignment1
{
    internal class Program
    {
        const int NumberOfGrades = 3;
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }

        private void Start()
        {
            List<Course> gradelist = ReadGradeList(NumberOfGrades);
            DisplayGradeList(gradelist);
        }

        List<Course> ReadGradeList(int nrOfCourses)
        {
            List<Course> gradelist = new List<Course>();
            for (int i = 0; i < nrOfCourses; i++)
            {
                Course course = ReadCourse("Enter a course.");
                gradelist.Add(course);
                Console.WriteLine();
            }
            return gradelist;
        }

        void DisplayGradeList(List<Course> gradeList)
        {
            bool isCumLaude = true;
            int numberOfRetakes = 0;
            foreach (Course course in gradeList)
            {
                DisplayCourse(course);
                Console.WriteLine();
                if (!course.Passed())
                {
                    isCumLaude = false;
                    numberOfRetakes++;
                }
                else if (!course.CumLaude())
                {
                    isCumLaude = false;
                }
            }
            if (numberOfRetakes > 0)
            {
                Console.WriteLine("Too bad, you did not graduate, you got {numberOfRetakes} retakes.");
            } else if (!isCumLaude) {
                Console.WriteLine("Congratulations, you graduated!");
            } else
            {
                Console.WriteLine("Congratulations, you graduated Cum Laude!");
            }
        }

        public Course ReadCourse(string question)
        {
            Course course = new Course();
            Console.WriteLine("Enter a course.");
            course.Name = ReadString("Name of course: ");
            course.TheoryGrade = ReadTheoryGrade($"Theory grade for {course.Name}: ");
            Console.WriteLine("0. None 1. Absent 2. Insufficent 3. Sufficient  4. Good");
            course.PracticalGrade = ReadPracticalGrade($"Practical grade for {course.Name}: ");
            return course;
        }

        PracticalGrade ReadPracticalGrade(string question)
        {
            return (PracticalGrade)ReadInt(question);
        }

        int ReadTheoryGrade(string question)
        {
            return ReadInt(question);
        }
        void DisplayPracticalGrade(PracticalGrade practical)
        {
            Console.Write($"{practical}");
        }

        void DisplayCourse(Course course)
        {
            Console.Write($"{course.Name} : {course.TheoryGrade} ");
            DisplayPracticalGrade(course.PracticalGrade);
            Console.WriteLine();
        }

        /**
         * Takes a string question and returns user input int
         * 
         */
        int ReadInt(string question)
        {
            Console.Write(question);
            return int.Parse(Console.ReadLine());
        }

        /**
         * Takes a string question, int min and max. Prompts user for int and
         *  validates value is between min and max. Returns validate input.
         */
        int ReadInt(string question, int min, int max)
        {
            int answer;
            do
            {
                answer = ReadInt(question);
            } while (answer < min || answer > max);
            return answer;
        }

        /**
         * Takes a string question and returns a string answer
         */
        string ReadString(string question)
        {
            Console.Write(question);
            return Console.ReadLine();
        }
    }
}