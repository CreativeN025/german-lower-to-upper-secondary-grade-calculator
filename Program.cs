namespace calculate_grade
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("how many subjects do you want to calculate");
            int subjects = Int16.Parse(Console.ReadLine());
            int[] grades = new int[subjects];
            //int[] grades = { 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1, 1 };

            for (int i = 0; i < grades.Length; i++)
            {
                Console.WriteLine("enter grade");

                grades[i] = Int16.Parse(Console.ReadLine());
            }

            double average = Convert.ToDouble(grades.Sum()) / subjects;

            Console.WriteLine("how many +'s do you have (example 2+)");
            int pluscount = Int16.Parse(Console.ReadLine());
            Console.WriteLine("how many -'s do you have (example 2-)");
            int minuscount = Int16.Parse(Console.ReadLine());
            pluscount = pluscount - minuscount;
            Console.WriteLine($"sum: {grades.Sum()} subjects: {subjects} average: {Math.Round(average, 2)}");
            Console.WriteLine("points: " + calculatepoints(grades, pluscount, false));
            Console.WriteLine($"GPA: {calculatepoints(grades, pluscount, true)}");
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
            ResultGPA = Math.Round(points * 0.27, 2);
            //ResultGPA = GPAlist[(int)points];
            if (!GPA)
            {
                Console.WriteLine("percent: " + Math.Round((points / 15) * 100, 2) + "%");
                return Math.Round(points, 2);
            }
            else { return ResultGPA; }

        }
    }
}

