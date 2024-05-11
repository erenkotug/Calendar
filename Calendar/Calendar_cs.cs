using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int D1, D2, Y1, Y2, n;
            int M1new = 0, M2new = 0;
            string M1, M2;
            string lowerM1, lowerM2;
            string weekofday = "sea";
            int c = 0;
            int z = 0;
            bool arestart = true;
            bool brestart = true;
            bool brestart2 = true;
            bool brestart3 = true;
            bool crestart = true;

            do
            {
                do
                {
                    Console.Write("D1= ");
                    string D1ex = Console.ReadLine();
                    if (Int32.TryParse(D1ex, out D1))
                    {
                        arestart = false;
                        Console.Write("");
                    }
                    else
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("Incorrect value entered of D1. ");
                        Console.WriteLine(" ");
                    }
                } while (arestart);

                Console.Write("M1= ");
                M1 = Convert.ToString(Console.ReadLine());
                lowerM1 = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(M1.ToLower());

                do
                {
                    Console.Write("Y1= ");
                    string Y1ex = Console.ReadLine();
                    if (Int32.TryParse(Y1ex, out Y1))
                    {
                        crestart = false;
                        Console.WriteLine(" ");
                    }
                    else
                    {
                        crestart = true;
                        Console.WriteLine(" ");
                        Console.WriteLine("Incorrect value entered of Y1. ");
                        Console.WriteLine(" ");
                    }
                } while (crestart);

                if (D1 <= 28 && D1 > 0 && (Y1 % 4 == 1 | Y1 % 4 == 2 | Y1 % 4 == 3) && lowerM1 == "February")
                {
                    brestart = false;
                    Console.Write("");
                }
                else if (D1 <= 29 && D1 > 0 && Y1 % 4 == 0 && lowerM1 == "February")
                {
                    brestart = false;
                    Console.Write("");
                }
                else if (D1 <= 30 && D1 > 0 && lowerM1 == "April" || lowerM1 == "June" || lowerM1 == "September" || lowerM1 == "November")
                {
                    brestart = false;
                    Console.Write("");
                }
                else if (D1 <= 31 && D1 > 0 && lowerM1 == "January" || lowerM1 == "March" || lowerM1 == "May" || lowerM1 == "July" || lowerM1 == "August" || lowerM1 == "October" || lowerM1 == "December")
                {
                    brestart = false;
                    Console.Write("");
                }
                else
                {
                    brestart = true;
                    Console.Write("D1 is wrong");
                    Console.WriteLine(" ");
                    Console.WriteLine("You must enter the correct value of D1.");
                    Console.WriteLine(" ");
                }

                if (lowerM1 == "January" || lowerM1 == "February" || lowerM1 == "March" || lowerM1 == "April" || lowerM1 == "May" || lowerM1 == "June" || lowerM1 == "July" || lowerM1 == "August" || lowerM1 == "September" || lowerM1 == "October" || lowerM1 == "November" || lowerM1 == "December")
                {
                    brestart2 = false;
                    Console.Write("");
                }
                else
                {
                    brestart2 = true;
                    Console.Write("M1 is wrong ");
                    Console.WriteLine(" ");
                    Console.WriteLine("You must enter the correct value of M1.");
                    Console.WriteLine(" ");
                }

                if (Y1 >= 2015)
                {
                    brestart3 = false;
                    Console.Write("");
                }
                else
                {
                    brestart3 = true;
                    Console.Write("Y1 is wrong ");
                    Console.WriteLine(" ");
                    Console.WriteLine("You must enter the correct value of Y1.");
                    Console.WriteLine(" ");
                }
                Console.ReadLine();
                Console.Clear();

            } while (brestart || brestart2 || brestart3);

            switch (lowerM1)
            {
                case "January": M1new = 1; break;
                case "February": M1new = 2; break;
                case "March": M1new = 3; break;
                case "April": M1new = 4; break;
                case "May": M1new = 5; break;
                case "June": M1new = 6; break;
                case "July": M1new = 7; break;
                case "August": M1new = 8; break;
                case "September": M1new = 9; break;
                case "October": M1new = 10; break;
                case "November": M1new = 11; break;
                case "December": M1new = 12; break;
                default: break;
            }

            bool drestart = true;
            bool frestart = true;
            bool frestart2 = true;
            bool frestart3 = true;

            do
            {

                do
                {
                    Console.Write("D2= ");
                    string D2ex = Console.ReadLine();
                    if (Int32.TryParse(D2ex, out D2))
                    {
                        drestart = false;
                        Console.Write("");
                    }
                    else
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("Incorrect value entered of D2. ");
                        Console.WriteLine(" ");
                    }

                } while (drestart);

                Console.Write("M2= ");
                M2 = Convert.ToString(Console.ReadLine());
                lowerM2 = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(M2.ToLower());

                do
                {
                    Console.Write("Y2= ");
                    string Y2ex = Console.ReadLine();
                    if (Int32.TryParse(Y2ex, out Y2))
                    {
                        crestart = false;
                        Console.WriteLine(" ");
                    }
                    else
                    {
                        crestart = true;
                        Console.WriteLine(" ");
                        Console.WriteLine("Incorrect value entered of Y2. ");
                        Console.WriteLine(" ");
                    }
                } while (crestart);

                if (D2 <= 28 && D2 > 0 && (Y2 % 4 == 1 | Y2 % 4 == 2 | Y2 % 4 == 3) && lowerM2 == "February")
                {
                    frestart = false;
                    Console.Write("");
                }
                else if (D2 <= 29 && D2 > 0 && Y2 % 4 == 0 && lowerM2 == "February")
                {
                    frestart = false;
                    Console.Write("");
                }
                else if (D2 <= 30 && D2 > 0 && lowerM2 == "April" || lowerM2 == "June" || lowerM2 == "September" || lowerM2 == "November")
                {
                    frestart = false;
                    Console.Write("");
                }
                else if (D2 <= 31 && D2 > 0 && lowerM2 == "January" || lowerM2 == "March" || lowerM2 == "May" || lowerM2 == "July" || lowerM2 == "August" || lowerM2 == "October" || lowerM2 == "December")
                {
                    frestart = false;
                    Console.Write("");
                }
                else
                {
                    frestart = true;
                    Console.Write("D2 is wrong");
                    Console.WriteLine(" ");
                    Console.WriteLine("You must enter the correct value of D2.");
                    Console.WriteLine(" ");
                }


                if (lowerM2 == "January" || lowerM2 == "February" || lowerM2 == "March" || lowerM2 == "April" || lowerM2 == "May" || lowerM2 == "June" || lowerM2 == "July" || lowerM2 == "August" || lowerM2 == "September" || lowerM2 == "October" || lowerM2 == "November" || lowerM2 == "December")
                {
                    frestart2 = false;
                    Console.Write("");
                }
                else
                {
                    frestart2 = true;
                    Console.Write("M2 is wrong ");
                    Console.WriteLine(" ");
                    Console.WriteLine("You must enter the correct value of M2.");
                    Console.WriteLine(" ");
                }

                if (Y2 >= 2015)
                {
                    frestart3 = false;
                    Console.Write("");
                }
                else
                {
                    frestart3 = true;
                    Console.Write("Y2 is wrong ");
                    Console.WriteLine(" ");
                    Console.WriteLine("You must enter the correct value of Y2.");
                    Console.WriteLine(" ");
                }
                Console.ReadLine();
                Console.Clear();

            } while (frestart || frestart2 || frestart3);

            bool grestart = true;
            bool grestart2 = true;

            do
            {
                do
                {
                    Console.Write("n= ");
                    string nex = Console.ReadLine();
                    bool success = Int32.TryParse(nex, out n);

                    if (success)
                    {
                        grestart = false;
                        Console.WriteLine(" ");
                    }
                    else
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("Incorrect value entered. ");
                        Console.WriteLine(" ");
                    }

                } while (grestart);

                if (n > 0)
                {
                    grestart2 = false;
                    Console.Write("");
                }
                else
                {
                    grestart2 = true;
                    Console.WriteLine("n is wrong");
                    Console.WriteLine(" ");
                    Console.WriteLine("You must enter the correct value of n.");
                    Console.WriteLine(" ");
                }
                Console.ReadLine();
                Console.Clear();

            } while (grestart2);

            switch (lowerM2)
            {
                case "January": M2new = 1; break;
                case "February": M2new = 2; break;
                case "March": M2new = 3; break;
                case "April": M2new = 4; break;
                case "May": M2new = 5; break;
                case "June": M2new = 6; break;
                case "July": M2new = 7; break;
                case "August": M2new = 8; break;
                case "September": M2new = 9; break;
                case "October": M2new = 10; break;
                case "Nowember": M2new = 11; break;
                case "December": M2new = 12; break;
                default: break;
            }

            Console.ReadLine();

            if ((Y1 == Y2) && (M1new == M2new) && (D1 > D2))
            {
                int temp;
                temp = D2;
                D2 = D1;
                D1 = temp;
            }

            else if ((Y1 == Y2) && (M2new < M1new))
            {
                int temp1;
                int temp2;
                string temp3;
                temp3 = lowerM2;
                lowerM2 = lowerM1;
                lowerM1 = temp3;
                temp2 = M2new;
                M2new = M1new;
                M1new = temp2;
                temp1 = D2;
                D2 = D1;
                D1 = temp1;
            }

            else if (Y1 > Y2)
            {
                int temp4;
                int temp5;
                int temp6;
                string temp7;
                temp7 = lowerM2;
                lowerM2 = lowerM1;
                lowerM1 = temp7;
                temp4 = D2;
                D2 = D1;
                D1 = temp4;
                temp5 = M2new;
                M2new = M1new;
                M1new = temp5;
                temp6 = Y2;
                Y2 = Y1;
                Y1 = temp6;
            }


            if (M1new == 1)
                lowerM1 = "January";
            if (M1new == 2)
                lowerM1 = "February";
            if (M1new == 3)
                lowerM1 = "March";
            if (M1new == 4)
                lowerM1 = "April";
            if (M1new == 5)
                lowerM1 = "May";
            if (M1new == 6)
                lowerM1 = "June";
            if (M1new == 7)
                lowerM1 = "July";
            if (M1new == 8)
                lowerM1 = "August";
            if (M1new == 9)
                lowerM1 = "September";
            if (M1new == 10)
                lowerM1 = "October";
            if (M1new == 11)
                lowerM1 = "November";
            if (M1new == 12)
                lowerM1 = "December";

            if (M2new == 1)
                lowerM2 = "January";
            if (M2new == 2)
                lowerM2 = "February";
            if (M2new == 3)
                lowerM2 = "March";
            if (M2new == 4)
                lowerM2 = "April";
            if (M2new == 5)
                lowerM2 = "May";
            if (M2new == 6)
                lowerM2 = "June";
            if (M2new == 7)
                lowerM2 = "July";
            if (M2new == 8)
                lowerM2 = "August";
            if (M2new == 9)
                lowerM2 = "September";
            if (M2new == 10)
                lowerM2 = "October";
            if (M2new == 11)
                lowerM2 = "November";
            if (M2new == 12)
                lowerM2 = "December";

            int Y1new = Y1;

            void zeller()
            {
                if(Y1new != Y1)
                {
                    Y1 = Y1new;
                }
                double p = Y1 / 100;
                int z = Y1 % 100;
                
                if (M1new < 3) { M1new = M1new + 12; Y1 = Y1 - 1; };
                // Zellers algorithm
                double weekday = ((c + ((13 * (M1new + 1)) / 5) + z + (z / 4) + (p / 4) + 5 * p) % 7);
                weekday = ((weekday + 5) % 7) + 1;
                switch (weekday)
                {
                    case 1:
                        weekofday = "Monday";
                            break;
                    case 2:
                        weekofday = "Tuesday";
                            break;
                    case 3:
                        weekofday = "Wednesday";
                            break;
                    case 4:
                        weekofday = "Thursday";
                            break;
                    case 5:
                        weekofday = "Friday";
                            break;
                    case 6:
                        weekofday = "Saturday";
                            break;
                    case 7:
                        weekofday = "Sunday";
                            break;
                }
            }

            

            

            if (Y1 == Y2 && M1new == M2new && D2 > D1)
            {
                if (M1new == 12 || M1new == 1 || M1new == 2)
                    Console.WriteLine("Winter");
                else if (M1new == 3 || M1new == 4 || M1new == 5)
                    Console.WriteLine("Spring");
                else if (M1new == 6 || M1new == 7 || M1new == 8)
                    Console.WriteLine("Summer");
                else if (M1new == 9 || M1new == 10 || M1new == 11)
                    Console.WriteLine("Autumn");

                for (c = D1; c <= D2; c += n)
                {
                    zeller(); 
                 
                    Console.WriteLine(c + " " + lowerM1 + " " + Y1 + " " + weekofday);
                }
            }
            
            int x = 0;
            

            if (Y2 == Y1 && M2new > M1new)
            {
                if (M1new == 1 || M1new == 2)
                    Console.WriteLine("Winter");
                else if (M1new == 4 || M1new == 5)
                    Console.WriteLine("Spring");
                else if (M1new == 7 || M1new == 8)
                    Console.WriteLine("Summer");
                else if (M1new == 10 || M1new == 11)
                    Console.WriteLine("Autumn");
                do
                {
                    if (M1new == 12)
                        Console.WriteLine("Winter");
                    else if (M1new == 3)
                        Console.WriteLine("Spring");
                    else if (M1new == 6)
                        Console.WriteLine("Summer");
                    else if (M1new == 9)
                        Console.WriteLine("Autumn");

                    if (M1new == 1 || M1new == 3 || M1new == 5 || M1new == 7 || M1new == 8 || M1new == 10 || M1new == 12)
                        x = 31;
                    else if (M1new == 4 || M1new == 6 || M1new == 9 || M1new == 11)
                        x = 30;
                    else if (((Y1 % 4 == 1) || (Y1 % 4 == 2) || (Y1 % 4 == 3)) && (M1new == 2) || ((Y1new % 4 == 1) || (Y1new % 4 == 2) || (Y1new % 4 == 3)) && (M1new == 2))
                        x = 28;
                    else if ((Y1new % 4 == 0) && (M1new == 2) || (Y1 % 4 == 0) && (M1new == 2))
                        x = 29;
                    else
                        Console.WriteLine("");
                    for (c = D1; (lowerM2 != lowerM1) && (c <= x) || (lowerM2 == lowerM1) && (c <= D2); c += n)
                    {
                        zeller();
                        Console.WriteLine(c + " " + lowerM1 + " " + Y1 + " " + weekofday);
                    }
                        
                    M1new = M1new + 1;
                    
                    if (M1new == 1)
                        lowerM1 = "January";
                    if (M1new == 2)
                        lowerM1 = "February";
                    if (M1new == 3)
                        lowerM1 = "March";
                    if (M1new == 4)
                        lowerM1 = "April";
                    if (M1new == 5)
                        lowerM1 = "May";
                    if (M1new == 6)
                        lowerM1 = "June";
                    if (M1new == 7)
                        lowerM1 = "July";
                    if (M1new == 8)
                        lowerM1 = "August";
                    if (M1new == 9)
                        lowerM1 = "September";
                    if (M1new == 10)
                        lowerM1 = "October";
                    if (M1new == 11)
                        lowerM1 = "November";
                    if (M1new == 12)
                        lowerM1 = "December";
                    D1 = c - x;
                } while (M1new != M2new + 1);

            }

            

            if ((Y2 > Y1) && (M1new >= M2new))
                M2new = M2new + (12 * (Y2 - Y1));

            
            if (Y2 > Y1)
            {

                if ((Y1new != Y2) && (M1new + 12 != M2new) || (Y1new != Y2) && (M1new + 12 == M2new) || (Y1new == Y2) && (M1new + 12 == M2new))
                {
                    do
                    {
                        if (M1new == 1 || M1new == 2)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("Winter");
                        }
                        else if (M1new == 4 || M1new == 5)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("Spring");
                        }
                        else if (M1new == 7 || M1new == 8)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("Summer");
                        }
                        else if (M1new == 10 || M1new == 11)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("Autumn");
                        }

                            do
                            {
                            if (M1new == 12)
                            {
                                Console.WriteLine(" ");
                                Console.WriteLine("Winter");
                            }
                            else if (M1new == 3)
                            {
                                Console.WriteLine(" ");
                                Console.WriteLine("Spring"); 
                            }
                            else if (M1new == 6)
                            {
                                Console.WriteLine(" ");
                                Console.WriteLine("Summer");
                            }
                            else if (M1new == 9)
                            {
                                Console.WriteLine(" ");
                                Console.WriteLine("Autumn");
                            }

                                if (M1new == 1 || M1new == 3 || M1new == 5 || M1new == 7 || M1new == 8 || M1new == 10 || M1new == 12)
                                    x = 31;
                                else if (M1new == 4 || M1new == 6 || M1new == 9 || M1new == 11)
                                    x = 30;
                                else if (((Y1 % 4 == 1) || (Y1 % 4 == 2) || (Y1 % 4 == 3)) && (M1new == 2) || ((Y1new % 4 == 1) || (Y1new % 4 == 2) || (Y1new % 4 == 3)) && (M1new == 2))
                                    x = 28;
                                else if ((Y1new % 4 == 0) && (M1new == 2) || (Y1 % 4 == 0) && (M1new == 2))
                                    x = 29;

                                for (c = D1; (Y1new != Y2) && (lowerM2 != lowerM1) && (c <= x) || (Y1new != Y2) && (lowerM2 == lowerM1) && (c <= x) || (Y1new == Y2) && (lowerM2 != lowerM1) && (c <= x) || (Y1new == Y2) && (lowerM2 == lowerM1) && (c <= D2); c += n)
                                {
                                    if (c < 1)
                                    {
                                        Console.ReadLine();
                                        System.Environment.Exit(0);
                                    }
                                    zeller();
                                    Console.WriteLine(c + " " + lowerM1 + " " + Y1new + " " + weekofday);



                                }

                                Console.Write("");

                                M1new = M1new + 1;

                                if (M1new > 13)
                                {
                                    M1new = M1new - 12;
                                }

                                if (M1new == 1)
                                    lowerM1 = "January";
                                if (M1new == 2)
                                    lowerM1 = "February";
                                if (M1new == 3)
                                    lowerM1 = "March";
                                if (M1new == 4)
                                    lowerM1 = "April";
                                if (M1new == 5)
                                    lowerM1 = "May";
                                if (M1new == 6)
                                    lowerM1 = "June";
                                if (M1new == 7)
                                    lowerM1 = "July";
                                if (M1new == 8)
                                    lowerM1 = "August";
                                if (M1new == 9)
                                    lowerM1 = "September";
                                if (M1new == 10)
                                    lowerM1 = "October";
                                if (M1new == 11)
                                    lowerM1 = "November";
                                if (M1new == 12)
                                    lowerM1 = "December";
                                D1 = c - x;

                                if (c < D2)
                                {
                                    M1new = 13;


                                }

                            } while (M1new != 13);

                            Console.Write("");

                            M1new = M1new - 12;

                            if (M1new == 1)
                                lowerM1 = "January";
                            if (M1new == 2)
                                lowerM1 = "February";
                            if (M1new == 3)
                                lowerM1 = "March";
                            if (M1new == 4)
                                lowerM1 = "April";
                            if (M1new == 5)
                                lowerM1 = "May";
                            if (M1new == 6)
                                lowerM1 = "June";
                            if (M1new == 7)
                                lowerM1 = "July";
                            if (M1new == 8)
                                lowerM1 = "August";
                            if (M1new == 9)
                                lowerM1 = "September";
                            if (M1new == 10)
                                lowerM1 = "October";
                            if (M1new == 11)
                                lowerM1 = "November";
                            if (M1new == 12)
                                lowerM1 = "December";
                            Y1new = Y1 + 1;

                            M2new = M2new - 12 * (Y2 - Y1);

                            if (M2new == 1)
                                z = 0;
                            if (M2new == 2)
                                z = 1;
                            if (M2new == 3)
                                z = 2;
                            if (M2new == 4)
                                z = 3;
                            if (M2new == 5)
                                z = 4;
                            if (M2new == 6)
                                z = 5;
                            if (M2new == 7)
                                z = 6;
                            if (M2new == 8)
                                z = 7;
                            if (M2new == 9)
                                z = 8;
                            if (M2new == 10)
                                z = 9;
                            if (M2new == 11)
                                z = 10;
                            if (M2new == 12)
                                z = 11;



                        } while ((M1new + z == M2new) && (Y1new == Y2) && (c > D2)) ;
                        }


                        else if ((Y1new == Y2) && (M1new + 12 == M2new) && (c > D2))
                        {
                            zeller();
                            Console.WriteLine(c - n + " " + lowerM1 + " " + Y1new + " " + weekofday);
                        }

                        else if ((Y1new == Y2) && (M1new + 12 == M2new) && (c == D2))
                        {
                            zeller();
                            Console.WriteLine(c + " " + lowerM1 + " " + Y1new + " " + weekofday);
                        }
                
            }

            Console.ReadLine();





        }
    }
}
