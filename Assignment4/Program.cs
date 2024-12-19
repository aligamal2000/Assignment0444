using System.ComponentModel;

namespace Assignment4
{
    #region 1- Write a program that allows the user to insert an integer then print all numbers between 1 to that number.


    //internal class Program
    //{
    //    public static void Main()
    //    {

    //        Console.Write("Enter an integer: ");
    //        int number = int.Parse(Console.ReadLine());


    //        Console.Write("Numbers from 1 to " + number + ": ");
    //        for (int i = 1; i <= number; i++)
    //        {

    //            Console.Write(i);
    //            if (i < number)
    //            {
    //                Console.Write(", ");
    //            }
    //        }
    //        Console.WriteLine(); 
    //    }
    //}

    #endregion
    #region 2- Write a program that allows the user to insert an integer then   print a multiplication table up to 12.



    //internal class Program
    //{
    //    public static void Main()
    //    {

    //        Console.Write("Enter an integer: ");
    //        int number = int.Parse(Console.ReadLine());


    //        Console.Write("Multiplication table for " + number + ": ");
    //        for (int i = 1; i <= 12; i++)
    //        {

    //            Console.Write(number * i);

    //            if (i < 12)
    //            {
    //                Console.Write(" ");
    //            }
    //        }
    //        Console.WriteLine(); 
    //    }
    //}

    #endregion
    #region 3- Write a program that allows to user to insert number then print all even numbers between 1 to this number

    //internal class Program
    //{
    //    public static void Main()
    //    {
    //        Console.Write("Enter a number: ");
    //        int number = int.Parse(Console.ReadLine());


    //        Console.Write("Even numbers between 1 and " + number + ": ");
    //        for (int i = 2; i <= number; i += 2)
    //        {
    //            Console.Write(i);

    //            if (i < number - 1 && i + 2 <= number)
    //            {
    //                Console.Write(" ");
    //            }
    //        }
    //        Console.WriteLine(); 
    //    }
    //}

    #endregion
    #region 4- Write a program that takes two integers then prints the power
    //internal class Program
    //{
    //    public static void Main()
    //    {
    //        Console.Write("Enter the base number: ");
    //        int baseNumber = int.Parse(Console.ReadLine());

    //        Console.Write("Enter the exponent: ");
    //        int exponent = int.Parse(Console.ReadLine());


    //        int result = 1;
    //        for (int i = 1; i <= exponent; i++)
    //        {
    //            result *= baseNumber;
    //        }


    //        Console.WriteLine($"The result of {baseNumber}^{exponent} is: {result}");
    //    }
    //}


    #endregion
    #region 5- Write a program to allow the user to enter a string and print the REVERSE of it.
    //internal class Program
    //{
    //    public static void Main()
    //    {
    //        // Prompt the user to enter a string
    //        Console.Write("Enter a string: ");
    //        string input = Console.ReadLine();

    //        // Reverse the string using a loop
    //        char[] reversed = input.ToCharArray();
    //        Array.Reverse(reversed);

    //        // Print the reversed string
    //        Console.WriteLine("Reversed string: " + new string(reversed));
    //    }
    //}

    #endregion
    #region 6- Write a program in C# Sharp to find prime numbers within a range of numbers.
    //internal class Program
    //{
    //    public static void Main()
    //    {

    //        Console.Write("Input starting number of range: ");
    //        int start = int.Parse(Console.ReadLine());

    //        Console.Write("Input ending number of range: ");
    //        int end = int.Parse(Console.ReadLine());

    //        Console.WriteLine("The prime numbers between " + start + " and " + end + " are: ");


    //        for (int num = start; num <= end; num++)
    //        {

    //            if (IsPrime(num))
    //            {
    //                Console.Write(num + " ");
    //            }
    //        }
    //        Console.WriteLine(); 
    //    }


    //    static bool IsPrime(int number)
    //    {
    //        if (number <= 1) return false; 
    //        for (int i = 2; i <= Math.Sqrt(number); i++) 
    //        {
    //            if (number % i == 0) 
    //            {
    //                return false;
    //            }
    //        }
    //        return true; 
    //    }
    //}

    #endregion
    #region 7- . Write a program in C# Sharp to convert a decimal number into binary without using an array.
    //internal class Program
    //{
    //    public static void Main()
    //    {
    //        Console.Write("Enter a number to convert: ");
    //        int decimalNumber = int.Parse(Console.ReadLine());

    //        string binary = "";

    //        while (decimalNumber > 0)
    //        {
    //            binary = (decimalNumber % 2) + binary;
    //            decimalNumber = decimalNumber / 2;
    //        }

    //        if (binary == "")
    //        {
    //            binary = "0";
    //        }

    //        Console.WriteLine($"The Binary of {decimalNumber} is {binary}");
    //    }
    //}


    #endregion
    #region 8 Write a program that prints an identity matrix using for loop, in other words takes a value n from the user and shows the identity table of size n * n.
    //internal class Program
    //{
    //    public static void Main()
    //    {
    //        Console.Write("Enter the size of the matrix (n): ");
    //        int n = int.Parse(Console.ReadLine());

    //        for (int i = 0; i < n; i++)
    //        {
    //            for (int j = 0; j < n; j++)
    //            {
    //                if (i == j)
    //                {
    //                    Console.Write("1 ");
    //                }
    //                else
    //                {
    //                    Console.Write("0 ");
    //                }
    //            }
    //            Console.WriteLine();
    //        }
    //    }
    //}

    #endregion
    #region 9- Write C# program that Extract a substring from a given string.
    //internal class Program
    //{
    //    public static void Main()
    //    {
    //        Console.Write("Enter a string: ");
    //        string inputString = Console.ReadLine();

    //        Console.Write("Enter the starting index: ");
    //        int startIndex = int.Parse(Console.ReadLine());

    //        Console.Write("Enter the length of the substring: ");
    //        int length = int.Parse(Console.ReadLine());

    //        string substring = inputString.Substring(startIndex, length);

    //        Console.WriteLine($"The extracted substring is: {substring}");
    //    }
    //}

    #endregion
    #region 10- Write C# program that take two string variables and print them as one variable 
    //internal class Program
    //{
    //    public static void Main()
    //    {
    //        Console.Write("Enter the first string: ");
    //        string firstString = Console.ReadLine();

    //        Console.Write("Enter the second string: ");
    //        string secondString = Console.ReadLine();

    //        string combinedString = firstString + secondString;

    //        Console.WriteLine($"The combined string is: {combinedString}");
    //    }
    //}

    #endregion
    #region 11 is 8
    //Q8
    #endregion
    #region 12- Write a program in C# Sharp to find the sum of all elements of the array.
    //internal class Program
    //{
    //    public static void Main()
    //    {
    //        Console.Write("Enter the size of the array: ");
    //        int size = int.Parse(Console.ReadLine());

    //        int[] numbers = new int[size];

    //        Console.WriteLine("Enter the elements of the array:");

    //        for (int i = 0; i < size; i++)
    //        {
    //            Console.Write($"Element {i + 1}: ");
    //            numbers[i] = int.Parse(Console.ReadLine());
    //        }

    //        int sum = 0;
    //        for (int i = 0; i < size; i++)
    //        {
    //            sum += numbers[i];
    //        }

    //        Console.WriteLine($"The sum of all elements in the array is: {sum}");
    //    }
    //}

    #endregion
    #region 13- Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.
    //internal class Program
    //{
    //    public static void Main()
    //    {
    //        Console.Write("Enter the size of the arrays: ");
    //        int size = int.Parse(Console.ReadLine());

    //        int[] array1 = new int[size];
    //        int[] array2 = new int[size];
    //        int[] mergedArray = new int[size * 2];

    //        Console.WriteLine("Enter the elements of the first array:");

    //        for (int i = 0; i < size; i++)
    //        {
    //            Console.Write($"Element {i + 1}: ");
    //            array1[i] = int.Parse(Console.ReadLine());
    //        }

    //        Console.WriteLine("Enter the elements of the second array:");

    //        for (int i = 0; i < size; i++)
    //        {
    //            Console.Write($"Element {i + 1}: ");
    //            array2[i] = int.Parse(Console.ReadLine());
    //        }


    //        for (int i = 0; i < size; i++)
    //        {
    //            mergedArray[i] = array1[i];
    //            mergedArray[size + i] = array2[i];
    //        }


    //        Array.Sort(mergedArray);


    //        Console.WriteLine("The merged and sorted array is:");
    //        foreach (int item in mergedArray)
    //        {
    //            Console.Write(item + " ");
    //        }
    //        Console.WriteLine();
    //    }
    //}

    #endregion
    #region 14- Write a program in C# Sharp to count the frequency of each element of an array.

    //internal class Program
    //{
    //    public static void Main()
    //    {
    //        Console.Write("Enter the size of the array: ");
    //        int size = int.Parse(Console.ReadLine());

    //        int[] array = new int[size];

    //        Console.WriteLine("Enter the elements of the array:");

    //        for (int i = 0; i < size; i++)
    //        {
    //            Console.Write($"Element {i + 1}: ");
    //            array[i] = int.Parse(Console.ReadLine());
    //        }


    //        Console.WriteLine("The frequency of each element is:");

    //        for (int i = 0; i < size; i++)
    //        {
    //            int count = 1; 
    //            if (array[i] != int.MinValue) 
    //            {
    //                for (int j = i + 1; j < size; j++)
    //                {
    //                    if (array[i] == array[j])
    //                    {
    //                        count++;
    //                        array[j] = int.MinValue; 
    //                    }
    //                }
    //                Console.WriteLine($"{array[i]} occurs {count} time(s)");
    //            }
    //        }
    //    }
    //}

    #endregion
    #region 15- Write a program in C# Sharp to find maximum and minimum element in an array
    //internal class Program
    //{
    //    public static void Main()
    //    {
    //        Console.Write("Enter the size of the array: ");
    //        int size = int.Parse(Console.ReadLine());

    //        int[] array = new int[size];

    //        Console.WriteLine("Enter the elements of the array:");

    //        for (int i = 0; i < size; i++)
    //        {
    //            Console.Write($"Element {i + 1}: ");
    //            array[i] = int.Parse(Console.ReadLine());
    //        }

    //        int max = array[0];
    //        int min = array[0];

    //        for (int i = 1; i < size; i++)
    //        {
    //            if (array[i] > max)
    //            {
    //                max = array[i];
    //            }

    //            if (array[i] < min)
    //            {
    //                min = array[i];
    //            }
    //        }

    //        Console.WriteLine($"The maximum element in the array is: {max}");
    //        Console.WriteLine($"The minimum element in the array is: {min}");
    //    }
    //}

    #endregion
    #region 16- Write a program in C# Sharp to find the second largest element in an array.
    //internal class Program
    //{
    //    public static void Main()
    //    {
    //        Console.Write("Enter the size of the array: ");
    //        int size = int.Parse(Console.ReadLine());

    //        int[] array = new int[size];

    //        Console.WriteLine("Enter the elements of the array:");

    //        for (int i = 0; i < size; i++)
    //        {
    //            Console.Write($"Element {i + 1}: ");
    //            array[i] = int.Parse(Console.ReadLine());
    //        }

    //        if (size < 2)
    //        {
    //            Console.WriteLine("Array must contain at least two elements.");
    //            return;
    //        }

    //        int largest = int.MinValue;
    //        int secondLargest = int.MinValue;

    //        for (int i = 0; i < size; i++)
    //        {
    //            if (array[i] > largest)
    //            {
    //                secondLargest = largest;
    //                largest = array[i];
    //            }
    //            else if (array[i] > secondLargest && array[i] != largest)
    //            {
    //                secondLargest = array[i];
    //            }
    //        }

    //        if (secondLargest == int.MinValue)
    //        {
    //            Console.WriteLine("There is no second largest element.");
    //        }
    //        else
    //        {
    //            Console.WriteLine($"The second largest element in the array is: {secondLargest}");
    //        }
    //    }
    //}

    #endregion
    #region 17-. Consider an Array of Integer values with size N, having values as in this Example

    //internal class Program
    //{
    //    public static void Main()
    //    {
    //        Console.Write("Enter the size of the array: ");
    //        int size = int.Parse(Console.ReadLine());

    //        int[] array = new int[size];

    //        Console.WriteLine("Enter the elements of the array:");

    //        for (int i = 0; i < size; i++)
    //        {
    //            Console.Write($"Element {i + 1}: ");
    //            array[i] = int.Parse(Console.ReadLine());
    //        }

    //        int maxDistance = 0;

    //        for (int i = 0; i < size; i++)
    //        {
    //            for (int j = i + 1; j < size; j++)
    //            {
    //                if (array[i] == array[j])
    //                {
    //                    int distance = j - i - 1; // distance between the two elements
    //                    if (distance > maxDistance)
    //                    {
    //                        maxDistance = distance;
    //                    }
    //                }
    //            }
    //        }

    //        if (maxDistance == 0)
    //        {
    //            Console.WriteLine("No equal elements found with distance.");
    //        }
    //        else
    //        {
    //            Console.WriteLine($"The longest distance between two equal elements is: {maxDistance}");
    //        }
    //    }
    //}

    #endregion
    #region 18- Write a program to create two multidimensional arrays of same size. Accept value from user and store them in first array. Now copy all the elements of first array on second array and print second array.
    //internal class Program
    //{
    //    public static void Main()
    //    {
    //        Console.Write("Enter the number of rows: ");
    //        int rows = int.Parse(Console.ReadLine());

    //        Console.Write("Enter the number of columns: ");
    //        int columns = int.Parse(Console.ReadLine());

    //        int[,] array1 = new int[rows, columns];
    //        int[,] array2 = new int[rows, columns];

    //        Console.WriteLine("Enter the elements for the first array:");


    //        for (int i = 0; i < rows; i++)
    //        {
    //            for (int j = 0; j < columns; j++)
    //            {
    //                Console.Write($"Element at position ({i}, {j}): ");
    //                array1[i, j] = int.Parse(Console.ReadLine());
    //            }
    //        }

    //        for (int i = 0; i < rows; i++)
    //        {
    //            for (int j = 0; j < columns; j++)
    //            {
    //                array2[i, j] = array1[i, j];
    //            }
    //        }


    //        Console.WriteLine("\nThe second array is:");
    //        for (int i = 0; i < rows; i++)
    //        {
    //            for (int j = 0; j < columns; j++)
    //            {
    //                Console.Write(array2[i, j] + " ");
    //            }
    //            Console.WriteLine();
    //        }
    //    }
    //}




    #endregion
    #region 19- Write a Program to Print One Dimensional Array in Reverse Order

    internal class Program
    {
        public static void Main()
        {
            Console.Write("Enter the size of the array: ");
            int size = int.Parse(Console.ReadLine());

            int[] array = new int[size];

            Console.WriteLine("Enter the elements of the array:");

            for (int i = 0; i < size; i++)
            {
                Console.Write($"Element {i + 1}: ");
                array[i] = int.Parse(Console.ReadLine());
            }

            
            Console.WriteLine("Array in reverse order:");

            for (int i = size - 1; i >= 0; i--)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine(); 
        }
    }

    #endregion
}
