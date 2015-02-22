﻿//  Problem 4. Appearance count

//  Write a method that counts how many times given number appears in given array.
//  Write a test program to check if the method is workings correctly.

using System;

class AppearanceCount
{
    static void Check(int[] array, int checkNumber)
    {
        int counter = 0;

        for (int i = 0; i < array.Length; i++)
        {
            int temp = array[i];
            if (temp == checkNumber)
            {
                counter++;
            }
        }
        Console.WriteLine("{0} times", counter);
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Appearance Count\n");

        Console.Write("Enter the array length: ");
        int arrayLength = int.Parse(Console.ReadLine());

        int[] array = new int[arrayLength];

        for (int i = 0; i < arrayLength; i++)
        {
            Console.Write("Enter number: ");
            array[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Enter number you want to check: ");
        int checkNumber = int.Parse(Console.ReadLine());

        Check(array, checkNumber);
    }
}