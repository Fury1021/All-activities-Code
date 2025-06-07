using System;

namespace ConsoleApp1
{

    class Menu
    {
        public static void showmenu()
        {
            Console.Clear();
            Console.WriteLine("In Fundamentals of Programming");
            Console.WriteLine("Compiled by:");
            Console.WriteLine("Diomer L. Manaois");
            Console.WriteLine("IT 104 | 2021-2022");
            Console.WriteLine();

            Console.WriteLine("Choose from: ");
            Console.WriteLine();
            Console.Write("1. Class Schedule Program" + "\t" + "\t" + "\t" + "\t");
            Console.Write("2. Program that display Arithmetic values" + "\t" + "\t");
            Console.Write("3. Program that Compute Semestral grade" + "\t" + "\n");
            Console.Write("4. Program for the Area of Trapezoid" + "\t" + "\t" + "\t");
            Console.Write("5. Age Program" + "\t" + "\t" + "\t" + "\t" + "\t" + "\t");
            Console.Write("6. Age Identifier Program" + "\t" + "\n");
            Console.Write("7. Grade Identfier Program" + "\t" + "\t" + "\t" + "\t");
            Console.Write("8. Year Identifier Program" + "\t" + "\t" + "\t" + "\t");
            Console.Write("9. Odd and Even Program" + "\t" + "\n");
            Console.Write("10. Pass or Fail Grade Program" + "\t" + "\t" + "\t" + "\t");
            Console.Write("11. Military Time Program" + "\t" + "\t" + "\t" + "\t");
            Console.Write("12. Arithmetic Operation Program" + "\t" + "\t" + "\t" + "\t" + "\n");
            Console.Write("13. Song List Program" + "\t" + "\t" + "\t" + "\t" + "\t");
            Console.Write("14. Name For Loop Program" + "\t" + "\t" + "\t" + "\t");
            Console.Write("15. Student Number While Loop Program" + "\t" + "\n");
            Console.Write("16. Email Address Do While Loop Program" + "\t" + "\t" + "\t");
            Console.Write("17. 1 to 1000 For Loop Program" + "\t" + "\t" + "\t" + "\t");
            Console.Write("18. -1 to -1000 Do While Loop Program" + "\t" + "\n");
            Console.Write("19. Print even numbers 1 – 100 While Loop Program" + "\t");
            Console.Write("20. Print odd numbers 1 – 100 For Loop Program" + "\t" + "\t");
            Console.Write("21. Print (*) Rows and Columns Program" + "\t" + "\n");
            Console.Write("22. Multiplication Table Nested Loop Program" + "\t" + "\t");
            Console.Write("23. String Username and Password Log in Program" + "\t" + "\t");
            Console.Write("24. String Convert to Capital and Small letter Program" + "\t" + "\t" + "\n");
            Console.Write("25. String Length Program" + "\t" + "\t" + "\t" + "\t");
            Console.Write("26. String Upper and Lower Program" + "\t" + "\t" + "\t");
            Console.Write("27. String IndexOf and Last IndexOf Program" + "\t" + "\t" + "\n");
            Console.Write("28. String Get Haschcode Program" + "\t" + "\t" + "\t");
            Console.Write("29. String Reverse Program" + "\t" + "\t" + "\t" + "\t");
            Console.Write("30. String Contains and Endswith Program" + "\t" + "\t" + "\n");
            Console.Write("31. String Replace Program" + "\t" + "\t" + "\t" + "\t");
            Console.Write("32. Array Alphabetical Order Program" + "\t" + "\t" + "\t");
            Console.Write("33. Random letters in Alphabetical Order" + "\t" + "\t" + "\t" + "\n");
            Console.Write("34. Array Temperatures Hightes – Lowest Program" + "\t" + "\t");
            Console.Write("35. 2D Array Names and Prelim GWA Program" + "\t" + "\t");
            Console.Write("36. 2D Array Multiplication Table Program" + "\t" + "\t" + "\n");
            Console.Write("37. Division without Divide Program" + "\t" + "\t" + "\t");
            Console.Write("38. Nicknames For Loop Prpgram" + "\t" + "\t");
            Console.WriteLine();
            Console.WriteLine();


            int program;

            Console.Write("Enter Number of Program: ");
            program = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            switch (program)
            {
                case 1:
                    Console.WriteLine("Full Name: Diomer L. Manaois");
                    Console.WriteLine("Course: BSIT");
                    Console.WriteLine("Block Section: IT 104");
                    Console.WriteLine("Student Number:202115524");
                    Console.WriteLine("Address: Blk 3 Lot 1 Airportview Subd. Brgy. Moonwalk Parañaque City");


                    Console.WriteLine("         Subject                          Teacher	           Schedule");
                    Console.WriteLine("Fundamentals of Programming Lec      Sir  Gene Justine Rosales       T/Th  1:00-2:00PM");
                    Console.WriteLine("Fundamentals of Programming Lab      Sir  Gene Justine Rosales       Fri   10:30-1:30PM");
                    Console.WriteLine("Art Appreciation                     Maam Zefra Reamillo             M/W/F 8:00-9:00PM");
                    Console.WriteLine("Digital and Logic Circuits Lab       Sir  Archie Santiago            Mon   10:30-1:30PM");
                    Console.WriteLine("Introduction to Computing Lec        Maam Gloria Dela Cruz           T/Th  12:00-1:00PM");
                    Console.WriteLine("Introduction to Computing Lab        Maam Gloria Dela Cruz           Wed   10:30-1:30PM");
                    Console.WriteLine("Physical Education 1                 Maam Rosalia Erpelo             Tue   3:00-5:00PM");
                    Console.WriteLine("Reading in Philippine History        Maam Analiza Collado            M/W/F 9:00-10:00PM");
                    Console.WriteLine("Scince, Technology and Society       Maam Jinky Cabrela              T/Th  8:30-10:00PM");
                    Console.WriteLine("Searching for God in the World Today Sir  Nestor Torrefranca         T/Th  10:30-12:00PM");
                    Console.ReadKey();
                    break;
                case 2:
                    int num, num2, sum, diff, quo, pro, modu;
                    Console.Write("Enter Number 1: ");
                    num = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Number 2: ");
                    num2 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine();

                    //arithmetic operators
                    sum = num2 + num;
                    diff = num2 - num;
                    quo = num2 / num;
                    pro = num2 * num;
                    modu = num2 % num;

                    Console.WriteLine();

                    //display output in our screen
                    Console.WriteLine("The sum of {0} and {1} is {2}", num2, num, sum);
                    Console.WriteLine("The diff of {0} and {1} is {2}", num2, num, diff);
                    Console.WriteLine("The quo of {0} and {1} is {2}", num2, num, quo);
                    Console.WriteLine("The pro of {0} and {1} is {2}", num2, num, pro);
                    Console.WriteLine("The modu of {0} and {1} is {2}", num2, num, modu);
                    Console.ReadKey();
                    break;
                case 3:
                    double prelim, midterm, final, prelimNum, midtermNum2, finalNum3, semestralSum;
                    Console.Write("Enter prelimNum:");
                    prelimNum = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter midtermNum2:");
                    midtermNum2 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter finalNum3:");
                    finalNum3 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine();

                    prelim = prelimNum * 0.30;
                    midterm = midtermNum2 * 0.30;
                    final = finalNum3 * 0.40;
                    semestralSum = final + midterm + prelim;

                    Console.WriteLine();
                    Console.WriteLine("The semestralSum of {0}, {1} and {2} is {3}", finalNum3, midtermNum2, prelimNum, semestralSum);
                    Console.ReadKey();
                    break;
                case 4:
                    double sideA, sideB, sideX, height, area;
                    Console.Write("Enter sideA:");
                    sideA = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter sideB:");
                    sideB = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter height:");
                    height = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine();


                    sideX = (sideA + sideB);
                    area = (sideX * height) / 2;

                    Console.WriteLine();

                    Console.WriteLine("the area of {0}, {1} and {2} is {3}", sideA, sideB, height, area);
                    Console.ReadKey();
                    break;
                case 5:
                    int age;
                    Console.Write("Enter Age:");
                    age = Convert.ToInt32(Console.ReadLine());
                    if (age >= 18)
                    {
                        Console.WriteLine("Legal Age");
                    }
                    else
                    {
                        Console.WriteLine("Minor Age");
                    }
                    Console.ReadKey();
                    break;
                case 6:
                    int currentYear, yearOfBirth, age1;
                    Console.Write("Enter Current Year:");
                    currentYear = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Year Of Birth:");
                    yearOfBirth = Convert.ToInt32(Console.ReadLine());

                    age1 = currentYear - yearOfBirth;
                    Console.WriteLine();

                    Console.WriteLine("Your current age for the current year {0} and year of birth {1} is {2}", currentYear, yearOfBirth, age1);

                    if (age1 >= 18)
                    {
                        Console.WriteLine("Congratulations you're an adult");
                    }
                    else
                    {
                        Console.WriteLine("Oops! sorry bata kapa");
                    }
                    Console.ReadKey();
                    break;
                case 7:
                    int grade;
                    Console.Write("Enter Grade:");
                    grade = Convert.ToInt32(Console.ReadLine());

                    if (grade >= 90 && grade <= 100)
                    {
                        Console.WriteLine("Your grade is A");
                    }
                    else if (grade >= 80 && grade <= 89)
                    {
                        Console.WriteLine("Your grade is B");
                    }
                    else if (grade >= 70 && grade <= 79)
                    {
                        Console.WriteLine("Your grade is C");
                    }
                    Console.ReadKey();
                    break;
                case 8:
                    Console.Write("Enter Number: ");
                    program = Convert.ToInt32(Console.ReadLine());

                    switch (program)
                    {
                        case 1:
                            Console.WriteLine("Freshmen");
                            break;
                        case 2:
                            Console.WriteLine("Sophomore");
                            break;
                        case 3:
                            Console.WriteLine("Junior");
                            break;
                        case 4:
                            Console.WriteLine("Senior");
                            break;
                    }
                    Console.ReadKey();
                    break;
                case 9:
                    int num11;
                    Console.Write("Enter Number:");
                    num11 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine();

                    if (num11 % 2 == 1)
                    {
                        Console.WriteLine("The number is ODD");
                    }
                    else
                    {
                        Console.WriteLine("The number is EVEN");
                    }
                    Console.ReadKey();
                    break;
                case 10:
                    double prelim1, midterm1, final1, semestralSum1;
                    Console.Write("Enter prelimNum:");
                    prelimNum = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter midtermNum2:");
                    midtermNum2 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter finalNum3:");
                    finalNum3 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine();

                    //arithmetic operators
                    prelim1 = prelimNum * 0.30;
                    midterm1 = midtermNum2 * 0.30;
                    final1 = finalNum3 * 0.40;
                    semestralSum1 = final1 + midterm1 + prelim1;
                    Console.WriteLine("The semestralSum of {0}, {1} and {2} is {3}", finalNum3, midtermNum2, prelimNum, semestralSum1);


                    if (semestralSum1 >= 70 && semestralSum1 <= 100)
                    {
                        Console.WriteLine("well done! you passed");
                    }
                    else
                    {
                        Console.WriteLine("I’m sorry you failed");
                    }
                    Console.ReadKey();
                    break;
                case 11:
                    String militaryTime;
                    DateTime militaryTimeDt;
                    Console.Write("Enter Military Time:");
                    militaryTime = Convert.ToString(Console.ReadLine());
                    militaryTimeDt = DateTime.ParseExact(militaryTime, "HH:mm", null);

                    if (militaryTimeDt >= DateTime.ParseExact("00:00", "HH:mm", null) && militaryTimeDt <= DateTime.ParseExact("11:59", "HH:mm", null))
                    {
                        Console.WriteLine("Good morning!");
                    }
                    else if (militaryTimeDt >= DateTime.ParseExact("12:00", "HH:mm", null) && militaryTimeDt <= DateTime.ParseExact("16:59", "HH:mm", null))
                    {
                        Console.WriteLine("Good afternoon!");
                    }
                    else if (militaryTimeDt >= DateTime.ParseExact("17:00", "HH:mm", null) && militaryTimeDt <= DateTime.ParseExact("23:59", "HH:mm", null))
                    {
                        Console.WriteLine("Good evening!");
                    }
                    else
                    {
                        Console.WriteLine("Sorry! Invalid Military Time, Please try again");
                    }
                    Console.ReadKey();
                    break;
                case 12:
                    string operation;
                    double num21, num22, sum21, diff21, quo21, pro21, modu21;
                    Console.Write("Enter arithmetic operation");
                    operation = Console.ReadLine();
                    if (operation.ToUpper() != "addition".ToUpper()
                        && operation.ToUpper() != "multiplication".ToUpper()
                        && operation.ToUpper() != "division".ToUpper()
                        && operation.ToUpper() != "modulo".ToUpper()
                        && operation.ToUpper() != "subtraction".ToUpper())
                    {
                        Console.WriteLine("Invalid data, try again");
                    }
                    else
                    {
                        Console.Write("Enter Number 1: ");
                        num21 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Number 2: ");
                        num22 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine();

                        if (operation.ToUpper() == "multiplication".ToUpper())
                        {
                            pro21 = num21 * num22;
                            Console.WriteLine("The product of {0} and {1} is {2}", num21, num22, pro21);
                        }
                        else if (operation.ToUpper() == "division".ToUpper())
                        {
                            quo21 = num21 / num22;
                            Console.WriteLine("The quotient of {0} and {1} is {2}", num21, num22, quo21);
                        }
                        else if (operation.ToUpper() == "modulo".ToUpper())
                        {
                            modu21 = num21 % num22;
                            Console.WriteLine("The remainder of {0} and {1} is {2}", num21, num22, modu21);
                        }
                        else if (operation.ToUpper() == "addition".ToUpper())
                        {
                            sum21 = num21 + num22;
                            Console.WriteLine("The sum of {0} and {1} is [2}", num21, num22, sum21);
                        }
                        else if (operation.ToUpper() == "subtraction".ToUpper())
                        {
                            diff21 = num21 - num22;
                            Console.WriteLine("The difference of {0} and {1} is {2}", num21, num22, diff21);
                        }
                    }
                    Console.ReadKey();
                    break;
                case 13:
                    String letter;
                    Console.Write("Enter Letter: ");
                    letter = Console.ReadLine();

                    switch (letter.ToLower())
                    {
                        case "a":
                            Console.WriteLine("A matter of Habit");
                            break;
                        case "b":
                            Console.WriteLine("Bad Romance");
                            break;
                        case "c":
                            Console.WriteLine("Call me Maybe");
                            break;
                        case "d":
                            Console.WriteLine("Down");
                            break;
                        case "e":
                            Console.WriteLine("Emperor's New Clothes");
                            break;
                        case "f":
                            Console.WriteLine("Firework");
                            break;
                        case "g":
                            Console.WriteLine("Good 4 u");
                            break;
                        case "h":
                            Console.WriteLine("Hello");
                            break;
                        case "i":
                            Console.WriteLine("Iris");
                            break;
                        case "j":
                            Console.WriteLine("Joy to the World");
                            break;
                        case "k":
                            Console.WriteLine("Killing me Softly");
                            break;
                        case "l":
                            Console.WriteLine("Location");
                            break;
                        case "m":
                            Console.WriteLine("Matutulog");
                            break;
                        case "n":
                            Console.WriteLine("Next to you");
                            break;
                        case "o":
                            Console.WriteLine("Open Arms");
                            break;
                        case "p":
                            Console.WriteLine("Paraluman");
                            break;
                        case "q":
                            Console.WriteLine("Quit Playing Games (with my Heart)");
                            break;
                        case "r":
                            Console.WriteLine("Rescue me");
                            break;
                        case "s":
                            Console.WriteLine("Starboy");
                            break;
                        case "u":
                            Console.WriteLine("Umbrella");
                            break;
                        case "v":
                            Console.WriteLine("Versace on the Floor");
                            break;
                        case "w":
                            Console.WriteLine("Wake me Up");
                            break;
                        case "x":
                            Console.WriteLine("Xxxtentacion");
                            break;
                        case "y":
                            Console.WriteLine("Yellow");
                            break;
                        case "z":
                            Console.WriteLine("zoom");
                            break;
                        default:
                            Console.WriteLine("Sorry, please input letter only");
                            break;
                    }
                    Console.ReadKey();
                    break;
                case 14:
                    int name;

                    for (name = 1; name <= 10; name++)
                    {
                        Console.WriteLine("DIomer L. Manaoais");
                    }
                    Console.ReadKey();
                    break;
                case 15:
                    int studentNo = 1;

                    while (studentNo <= 15)
                    {
                        Console.WriteLine("202115524");
                        studentNo++;
                    }
                    Console.ReadKey();
                    break;
                case 16:
                    int emailAddress = 1;

                    do
                    {
                        Console.WriteLine("diomer.manaois@adamason.edu.ph");
                        emailAddress++;
                    }
                    while (emailAddress <= 10);
                    Console.ReadKey();
                    break;
                case 17:
                    int number;

                    for (number = 1; number <= 1000; number++)
                    {
                        Console.WriteLine(number);

                    }
                    Console.ReadKey();
                    break;
                case 18:
                    int number1 = -1;

                    do
                    {
                        Console.WriteLine(number1);
                        number1--;
                    }
                    while (number1 >= -1000);
                    Console.ReadKey();
                    break;
                case 19:
                    int number21 = 0, add = 2, even = 0;

                    while (number21 <= 100)
                    {
                        Console.WriteLine(even);
                        number21 = number21 += add;
                        even = number21;
                    }
                    Console.ReadKey();
                    break;
                case 20:
                    int number222 = 1, add1 = 2, odd;

                    for (odd = 0; number222 <= 100; odd = number222 += add1)
                    {
                        Console.WriteLine(odd);
                    }
                    Console.ReadKey();
                    break;
                case 21:
                    int numbr = 0;
                    Console.Write("Enter number of columns and rows: ");
                    number = Convert.ToInt32(Console.ReadLine());


                    for (int pattern = 1; pattern <= numbr; pattern++)
                    {

                        for (int pattern2 = 1; pattern2 <= numbr; pattern2++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }
                    Console.ReadKey();
                    break;
                case 22:
                    int product;
                    for (int num1021 = 1; num1021 <= 10; num1021++)
                    {
                        for (int num211 = 1; num211 <= 10; num211++)
                        {
                            product = num1021 * num211;
                            Console.Write(product + "\t");
                        }
                        Console.Write("\n");
                    }
                    Console.ReadKey();
                    break;
                case 23:
                    string userName = "Fury1021";
                    string passWord = "gustokosiomairice";

                    Console.Write("Enter email: ");
                    string email = Console.ReadLine();
                    Console.Write("Enter password: ");
                    string passCode = Console.ReadLine();

                    if (email == userName && passCode == passWord)
                    {
                        Console.WriteLine("Log-in Successful");
                    }
                    else
                    {
                        Console.WriteLine("Invalid Log-in details");
                    }
                    Console.ReadKey();
                    break;
                case 24:
                    String name44, email44;
                    Console.Write("Enter your fullname: ");
                    name44 = Console.ReadLine();
                    Console.Write("Enter your email: ");
                    email44 = Console.ReadLine();

                    Console.WriteLine();

                    Console.WriteLine(name44.ToUpper());
                    Console.WriteLine(email44.ToLower());
                    Console.ReadKey();
                    break;
                case 25:
                    string s1 = "four+five";
                    Console.WriteLine(s1.Length);
                    Console.ReadKey();
                    break;
                case 26:
                    string s2 = "capital letters dito";
                    string s3 = "SMALL LETTERS DITO";
                    Console.WriteLine(s2.ToUpper());
                    Console.WriteLine(s3.ToLower());
                    Console.ReadKey();
                    break;
                case 27:
                    string s4 = "anong sumunod sa 0";
                    string s5 = "ilang char kung walangp";
                    Console.WriteLine(s4.IndexOf('n'));
                    Console.WriteLine(s5.LastIndexOf('p'));
                    Console.ReadKey();
                    break;
                case 28:
                    string s6 = "Diomer Manaois";
                    Console.WriteLine(s6.GetHashCode());
                    Console.ReadKey();
                    break;
                case 29:
                    string s7 = "oka oblak";
                    var chars = s7.ToCharArray();
                    Array.Reverse(chars);
                    Console.WriteLine(new string(chars));
                    Console.ReadKey();
                    break;
                case 30:
                    string s8 = "I am you";
                    string s9 = "Family";
                    Console.WriteLine(s8.Contains("you"));
                    Console.WriteLine(s9.EndsWith("ily"));
                    Console.ReadKey();
                    break;
                case 31:
                    string s10 = "mahol kita";
                    Console.WriteLine(s10.Replace('o', 'a'));
                    Console.ReadKey();
                    break;
                case 32:
                    string[] names = new string[5];
                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine();
                        Console.WriteLine("(Names in alphabetical order)");
                        Console.WriteLine();
                    }

                    Array.Sort(names);
                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine(names[i]);
                    }
                    Console.ReadKey();
                    break;
                case 33:
                    string[] letters = new string[10];

                    for (int i = 0; i < 10; i++)
                    {
                        Console.Write("Enter 10 random letter");
                        letters[i] = Convert.ToString(Console.ReadLine());
                    }

                    Console.WriteLine();
                    Console.WriteLine("(Letters in alphabetical order");
                    Console.WriteLine();
                    Array.Sort(letters);
                    for (int i = 0; i < 10; i++)
                    {
                        Console.WriteLine(letters[i]);
                    }
                    Console.ReadKey();
                    break;
                case 34:
                    string[] temperature = new string[12];

                    for (int i = 0; i < 12; i++)
                    {
                        Console.WriteLine("Enter random temperature: ", i + 1);
                        temperature[i] = Convert.ToString(Console.ReadLine());
                    }

                    Console.WriteLine();
                    Console.WriteLine("(Temperature from highest to lowesr)");
                    Console.WriteLine();

                    Array.Sort(temperature);
                    Array.Reverse(temperature);
                    for (int i = 0; i < 12; i++)
                    {
                        Console.WriteLine("(0) °", temperature[i]);
                    }
                    Console.ReadKey();
                    break;
                case 35:
                    int quotient = 0, num1, num214;

                    Console.Write("Enter Number 1: ");
                    num1 = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter Number 2: ");
                    num214 = Convert.ToInt32(Console.ReadLine());


                    for (int j = 0; j + num214 <= num1; j += num214)
                    {
                        quotient++;
                    }
                    Console.WriteLine("The quotient is {0}", quotient);
                    Console.ReadKey();
                    break;
                case 36:
                    int[,] multtble = new int[10, 10];

                    Console.WriteLine("Multiplcation Table");
                    Console.WriteLine();

                    for (int row = 0; row < 10; row++)
                    {
                        for (int column = 0; column < 10; column++)
                        {
                            multtble[row, column] = (row + 1) * (column + 1);
                            Console.Write(multtble[row, column]);

                            if (column < 9)
                            {
                                Console.Write("\t");
                            }
                            else
                                Console.WriteLine("\n");

                        }
                    }
                    Console.ReadKey();
                    break;
                case 37:
                    int quotient1 = 0, num1000, num2000;

                    Console.Write("Enter Number 1: ");
                    num1000 = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter Number 2: ");
                    num2000 = Convert.ToInt32(Console.ReadLine());


                    for (int j = 0; j + num2000 <= num1000; j += num2000)
                    {
                        quotient1++;
                    }
                    Console.WriteLine("The quotient is {0}", quotient1);
                    Console.ReadKey();
                    break;
                case 38:
                    int n0m = 1;

                    for (n0m = 1; n0m <= 15; n0m++)
                    {
                        Console.WriteLine("Dio");
                    }
                    Console.ReadKey();
                    break;
            }
        }
        class program2
        {
            public static void options()
            {
                int options;
                Console.WriteLine();
                Console.WriteLine("Options");
                Console.WriteLine();
                Console.Write("1. Exit" + "\n");
                Console.Write("2. Select new Program" + "\n");

                Console.Write("What is your options: ");
                options = Convert.ToInt32(Console.ReadLine());

                switch (options)
                {
                    case 1:
                        Environment.Exit(0);
                        break;
                    case 2:
                        showmenu();
                        break;
                }
            }
            class Program
            {
                static void Main(string[] args)
                {

                    Console.Clear();
                    showmenu();
                    options();


                }
            }
        }
    }

}







