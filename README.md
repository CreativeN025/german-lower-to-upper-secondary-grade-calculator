# german-lower-to-upper-secondary-grade-calculator
calculate your lower secondary to upper secondary grade (percentage/points) also includes calculating your unweighted GPA

This C# console application allows users to calculate the average grade, total points, and GPA based on a set of input grades. The program prompts the user to enter the number of subjects, 
grades for each subject, and additional information about plus and minus grades. It then calculates and displays the average grade, total points, percentage, and GPA.

Instructions

    1.Run the program.
    2.Enter the number of subjects you want to calculate.
    3.Enter the grades for each subject when prompted.
    4.Specify the number of plus and minus grades.
    5.View the calculated average grade, total points, percentage, and GPA.

Program Details

The program consists of a single C# file, Program.cs, with the following key components:

    Input: The program prompts the user to enter the number of subjects and grades for each subject.

    Grade Calculation: The calculatepoints method calculates the total points based on the entered grades and additional points for plus and minus grades.

    Average Calculation: The average grade is calculated by dividing the sum of grades by the total number of subjects. Note that the program uses floating-point division to ensure accurate results.

    GPA Calculation: The program converts the total points to a GPA using a custom mapping defined in the GPAlist array.

    Percentage Display: The program displays the percentage equivalent of the calculated points out of the maximum possible points.
