// Created by: Venika Sem
// Created on: Mar 2022
//
// This program does calculations

using System;

class Program
{
    public static void Main(string[] args)
    {
        string currentAction = "minus";
        int numberOfIterations;
        float number = 1;
        float pi;

        Console.Write("Enter integer: ");
        numberOfIterations = Convert.ToInt32(Console.ReadLine());
        pi = (4 / number);
        while (numberOfIterations > 1)
        {
            if (currentAction == "minus")
            {
                number = number + 2;
                pi = pi - (4 / number);
                currentAction = "plus";
            }
            else if (currentAction == "plus")
            {
                number = number + 2;
                pi = pi + (4 / number);
                currentAction = "minus";
            }
            numberOfIterations = numberOfIterations - 1;
        }
        Console.WriteLine("π is equal to " + (pi).ToString("0.00"));
        Console.WriteLine("\nDone.");
    }
}