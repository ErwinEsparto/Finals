using System;

namespace Esparto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> courseBSIT = new List<string>();
            List<string> courseDICT = new List<string>();
            List<string> courseBSIE = new List<string>();
            List<string> courseDCET = new List<string>();
            List<string> courseBEED = new List<string>();
            List<string> facultyUsers = new List<string>();
            List<string> facultyPass = new List<string>();
            string input;

            do
            {
                ShowMenu();
                input = GetUserInput();

                if (input == "X" || input == "x")
                {
                    Console.WriteLine("Thank you for using the application.");
                    break;
                }
                else if (Convert.ToInt32(input) == 1)
                {
                    ShowSections();
                    string sectioninput = GetUserInput();

                    if (Convert.ToInt32(sectioninput) == 1)
                    {
                        Console.WriteLine("\nWelcome to the BSIT Course.");
                        ShowStudentMenu();
                        string studentinput = GetUserInput();

                        if (Convert.ToInt32(studentinput) == 1)
                        {
                            string studentnumber = GetStudentNumber();
                            int format = CheckFormat(studentnumber);

                            if (format == 1)
                            {
                                if (courseBSIT.Count < 30) {
                                    courseBSIT.Add(studentnumber);
                                    Console.WriteLine("Successfully Enrolled.");
                                }
                                else
                                {
                                    Console.WriteLine("Sorry, slots are full.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Incorrect format.");
                            }
                        }
                        else if (Convert.ToInt32(studentinput) == 2)
                        {
                            string studentnumber = GetStudentNumber();
                            int format = CheckFormat(studentnumber);

                            if (format == 1)
                            {

                                courseBSIT.Remove(studentnumber);
                                Console.WriteLine("Successfully Unenrolled.");
                            }
                            else
                            {
                                Console.WriteLine("Incorrect format.");
                            }
                        }
                        else if (Convert.ToInt32(studentinput) == 3)
                        {
                            string studentnumber = GetStudentNumber();
                            int enrolled = courseBSIT.IndexOf(studentnumber);

                            if (enrolled == -1)
                            {
                                Console.WriteLine("You are not enrolled.");
                            }
                            else
                            {
                                Console.WriteLine("You are enrolled.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid input.");
                        }
                    }
                    else if (Convert.ToInt32(sectioninput) == 2)
                    {
                        Console.WriteLine("\nWelcome to the DICT Course.");
                        ShowStudentMenu();
                        string studentinput = GetUserInput();

                        if (Convert.ToInt32(studentinput) == 1)
                        {
                            string studentnumber = GetStudentNumber();
                            int format = CheckFormat(studentnumber);

                            if (format == 1)
                            {
                                if (courseDICT.Count < 30)
                                {
                                    courseDICT.Add(studentnumber);
                                    Console.WriteLine("Successfully Enrolled.");
                                }
                                else
                                {
                                    Console.WriteLine("Sorry, slots are full.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Incorrect format.");
                            }
                        }
                        else if (Convert.ToInt32(studentinput) == 2)
                        {
                            string studentnumber = GetStudentNumber();
                            int format = CheckFormat(studentnumber);

                            if (format == 1)
                            {

                                courseDICT.Remove(studentnumber);
                                Console.WriteLine("Successfully Unenrolled.");
                            }
                            else
                            {
                                Console.WriteLine("Incorrect format.");
                            }
                        }
                        else if (Convert.ToInt32(studentinput) == 3)
                        {
                            string studentnumber = GetStudentNumber();
                            int enrolled = courseDICT.IndexOf(studentnumber);

                            if (enrolled == -1)
                            {
                                Console.WriteLine("You are not enrolled.");
                            }
                            else
                            {
                                Console.WriteLine("You are enrolled.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid input.");
                        }
                    }
                    else if (Convert.ToInt32(sectioninput) == 3)
                    {
                        Console.WriteLine("\nWelcome to the BSIE Course.");
                        ShowStudentMenu();
                        string studentinput = GetUserInput();

                        if (Convert.ToInt32(studentinput) == 1)
                        {
                            string studentnumber = GetStudentNumber();
                            int format = CheckFormat(studentnumber);

                            if (format == 1)
                            {
                                if (courseBSIE.Count < 30)
                                {
                                    courseBSIE.Add(studentnumber);
                                    Console.WriteLine("Successfully Enrolled.");
                                }
                                else
                                {
                                    Console.WriteLine("Sorry, slots are full.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Incorrect format.");
                            }
                        }
                        else if (Convert.ToInt32(studentinput) == 2)
                        {
                            string studentnumber = GetStudentNumber();
                            int format = CheckFormat(studentnumber);

                            if (format == 1)
                            {

                                courseBSIE.Remove(studentnumber);
                                Console.WriteLine("Successfully Unenrolled.");
                            }
                            else
                            {
                                Console.WriteLine("Incorrect format.");
                            }
                        }
                        else if (Convert.ToInt32(studentinput) == 3)
                        {
                            string studentnumber = GetStudentNumber();
                            int enrolled = courseBSIE.IndexOf(studentnumber);

                            if (enrolled == -1)
                            {
                                Console.WriteLine("You are not enrolled.");
                            }
                            else
                            {
                                Console.WriteLine("You are enrolled.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid input.");
                        }
                    }
                    else if (Convert.ToInt32(sectioninput) == 4)
                    {
                        Console.WriteLine("\nWelcome to the DCET Course.");
                        ShowStudentMenu();
                        string studentinput = GetUserInput();

                        if (Convert.ToInt32(studentinput) == 1)
                        {
                            string studentnumber = GetStudentNumber();
                            int format = CheckFormat(studentnumber);

                            if (format == 1)
                            {
                                if (courseDCET.Count < 30)
                                {
                                    courseDCET.Add(studentnumber);
                                    Console.WriteLine("Successfully Enrolled.");
                                }
                                else
                                {
                                    Console.WriteLine("Sorry, slots are full.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Incorrect format.");
                            }
                        }
                        else if (Convert.ToInt32(studentinput) == 2)
                        {
                            string studentnumber = GetStudentNumber();
                            int format = CheckFormat(studentnumber);

                            if (format == 1)
                            {

                                courseDCET.Remove(studentnumber);
                                Console.WriteLine("Successfully Unenrolled.");
                            }
                            else
                            {
                                Console.WriteLine("Incorrect format.");
                            }
                        }
                        else if (Convert.ToInt32(studentinput) == 3)
                        {
                            string studentnumber = GetStudentNumber();
                            int enrolled = courseDCET.IndexOf(studentnumber);

                            if (enrolled == -1)
                            {
                                Console.WriteLine("You are not enrolled.");
                            }
                            else
                            {
                                Console.WriteLine("You are enrolled.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid input.");
                        }
                    }
                    else if (Convert.ToInt32(sectioninput) == 5)
                    {
                        Console.WriteLine("\nWelcome to the BEED Course.");
                        ShowStudentMenu();
                        string studentinput = GetUserInput();

                        if (Convert.ToInt32(studentinput) == 1)
                        {
                            string studentnumber = GetStudentNumber();
                            int format = CheckFormat(studentnumber);

                            if (format == 1)
                            {
                                if (courseBEED.Count < 30)
                                {
                                    courseBEED.Add(studentnumber);
                                    Console.WriteLine("Successfully Enrolled.");
                                }
                                else
                                {
                                    Console.WriteLine("Sorry, slots are full.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Incorrect format.");
                            }
                        }
                        else if (Convert.ToInt32(studentinput) == 2)
                        {
                            string studentnumber = GetStudentNumber();
                            int format = CheckFormat(studentnumber);

                            if (format == 1)
                            {

                                courseBEED.Remove(studentnumber);
                                Console.WriteLine("Successfully Unenrolled.");
                            }
                            else
                            {
                                Console.WriteLine("Incorrect format.");
                            }
                        }
                        else if (Convert.ToInt32(studentinput) == 3)
                        {
                            string studentnumber = GetStudentNumber();
                            int enrolled = courseBEED.IndexOf(studentnumber);

                            if (enrolled == -1)
                            {
                                Console.WriteLine("You are not enrolled.");
                            }
                            else
                            {
                                Console.WriteLine("You are enrolled.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid input.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input.");
                    }
                }
                else if (Convert.ToInt32(input) == 2)
                {
                    ShowFacultyMenu();
                    string facultyinput = GetUserInput();

                    if (Convert.ToInt32(facultyinput) == 1)
                    {
                        Console.Write("Please type your user>> ");
                        string facultyuser = GetUserInput();
                        int user = facultyUsers.IndexOf(facultyuser);

                        if (user == -1)
                        {
                            Console.WriteLine("User not found.");
                        }
                        else
                        {
                            Console.Write("Please type your password>> ");
                            string facultypassword = GetUserInput();
                            int password = facultyPass.IndexOf(facultypassword);

                            Console.WriteLine("Successful Login");
                            Console.WriteLine("Would you like to see the enrolled students? [Y] or [N]");
                            Console.Write("Input: ");
                            string choice = Console.ReadLine();

                            if (choice == "Y" || choice == "y")
                            {
                                ShowSections();
                                string inputsection = GetUserInput();

                                if (Convert.ToInt32(inputsection) == 1)
                                {
                                    Console.WriteLine("BSIT Students:");
                                    foreach (var student in courseBSIT)
                                    {
                                        Console.WriteLine(student);
                                    }
                                }
                                else if (Convert.ToInt32(inputsection) == 2)
                                {
                                    Console.WriteLine("DICT Students:");
                                    foreach (var student in courseDICT)
                                    {
                                        Console.WriteLine(student);
                                    }
                                }
                                else if (Convert.ToInt32(inputsection) == 3)
                                {
                                    Console.WriteLine("BSIE Students:");
                                    foreach (var student in courseBSIE)
                                    {
                                        Console.WriteLine(student);
                                    }
                                }
                                else if (Convert.ToInt32(inputsection) == 4)
                                {
                                    Console.WriteLine("DCET Students:");
                                    foreach (var student in courseDCET)
                                    {
                                        Console.WriteLine(student);
                                    }
                                }
                                else if (Convert.ToInt32(inputsection) == 5)
                                {
                                    Console.WriteLine("BEED Students:");
                                    foreach (var student in courseBEED)
                                    {
                                        Console.WriteLine(student);
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Invalid choice.");
                                }
                            }
                            else if (choice == "N" || choice == "n")
                            {
                                Console.WriteLine("Thank you for using the system.");
                            }
                            else
                            {
                                Console.WriteLine("Invalid choice.");
                            }
                        }
                    }
                    else if (Convert.ToInt32(facultyinput) == 2)
                    {
                        Console.Write("Please type your name>> ");
                        string facultyuser = Console.ReadLine();
                        facultyUsers.Add(facultyuser);
                        Console.Write("Please type your password>> ");
                        string facultypassword = Console.ReadLine();
                        facultyPass.Add(facultypassword);
                        Console.WriteLine("Successfully Registered.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid input.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid choice.");
                }
            }
            while (input != "X" || input != "x");
        }
        static void ShowMenu()
        {
            Console.WriteLine("\nWelcome to the Student Enrollment System.");
            Console.WriteLine("[1] Student");
            Console.WriteLine("[2] Faculty");
            Console.WriteLine("[X] Exit application.");
            Console.Write("Input: ");
        }
        static string GetUserInput()
        {
            string userinput = Console.ReadLine();
            return userinput;
        }
        static void ShowSections()
        {
            Console.WriteLine("\nPlease choose the desired section.");
            Console.WriteLine("[1] BSIT");
            Console.WriteLine("[2] DICT");
            Console.WriteLine("[3] BSIE");
            Console.WriteLine("[4] DCET");
            Console.WriteLine("[5] BEED");
            Console.Write("Input: ");
        }
        static void ShowStudentMenu()
        {
            Console.WriteLine("[1] Enroll");
            Console.WriteLine("[2] Unenroll");
            Console.WriteLine("[3] Check Enrollment Status");
            Console.Write("Input: ");
        }
        static int CheckFormat(string studentnumber)
        {
            if (studentnumber.Length == 15)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        static string GetStudentNumber()
        {
            Console.WriteLine("\nPlease type your student number in this format: XXXX-XXXXX-XX-X");
            Console.Write("Input: ");
            string studentnumber = GetUserInput();
            return studentnumber;
        }
        static void ShowFacultyMenu()
        {
            Console.WriteLine("\nPlease choose your desired action.");
            Console.WriteLine("[1] Login");
            Console.WriteLine("[2] Register");
            Console.Write("Input: ");
        }
    }
}