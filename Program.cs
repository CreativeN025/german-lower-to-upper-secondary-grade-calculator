namespace calculate_grade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int subjects = takeinput("how many subjects do you want to calculate");
            int[] grades = new int[subjects];

            for (int i = 0; i < grades.Length; i++)
            {
                grades[i] = takeinput("enter grade");
            }

            double average = Convert.ToDouble(grades.Sum()) / subjects;

            int pluscount = takeinput("how many +'s do you have (example 2+)");
            int minuscount = takeinput("how many -'s do you have (example 2-)");
            pluscount -= minuscount;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"sum: {grades.Sum()} subjects: {subjects} average: {Math.Round(average, 2)}");
            Console.WriteLine("points: " + calculatepoints(grades, pluscount, false));
            Console.WriteLine($"GPA: {calculatepoints(grades, pluscount, true)}");
        }
        static int takeinput(string write)
        {
            while (true)
            {
                Console.WriteLine(write);
                try
                {
                    return Int16.Parse(Console.ReadLine());
                }
                catch(System.FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("invalid input try again");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            
            }
        static double calculatepoints(int[] grades, int extrapoints, bool GPA)
        {
            double points = 0;
            double[] pointlist = { 14, 11, 8, 5, 2, 0 };
            double[] GPAlist = { 0, 0, 0, 0, 1.0, 1.3, 1.7, 2.0, 2.3, 2.7, 3.0, 3.3, 3.7, 4.0, 4.0 };
            double ResultGPA = 0;
            for (int i = 0; i < grades.Length; i++)
            {
                points += pointlist[grades[i] - 1];
            }
            points += extrapoints;
            points /= grades.Length;
            
            if (!GPA)
            {
                Console.WriteLine($"percent: {Math.Round((points / 15) * 100, 2)}%");
                return Math.Round(points, 2);
            }
            else { return Math.Round(points * 0.27, 2); }

        }
    }
}


