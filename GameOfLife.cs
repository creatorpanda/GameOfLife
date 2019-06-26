using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace GameOfLife
{

    class PetriDish
    {

        //method that prints Emulator's Logo.
        static void Logo()
        {



            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine(" _____                                __   _      _  __     ");
            Console.WriteLine("/ ____|                              / _| | |    (_)/ _|    ");
            Console.WriteLine("| |  __  __ _ _ __ ___   ___    ___ | |_  | |     _| |_ ___ ");
            Console.WriteLine("| | |_ |/ _` | '_ ` _ \\ / _ \\  / _ \\|  _| | |    | |  _/ _ \\");
            Console.WriteLine("| |__| | (_| | | | | | |  __/ | (_) | |   | |____| | ||  __/");
            Console.WriteLine("\\_____ |\\__,_|_| |_| |_|\\___|  \\___/|_|   |______|_|_| \\___|");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("                                         by creatorpanda");
            Console.WriteLine();
            Console.WriteLine();
            Console.ResetColor();

        }

        //Programmer's (that's me) Signature.
        static void Signature()
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine("GitHub: creatorpanda");
            Console.WriteLine("creation of 2018");
            Console.ResetColor();
            End();

        }

        //"Press ENTER to continue" method.
        static void Wait()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("*");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Press ENTER to continue");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("*");
            Console.ResetColor();
            Console.ReadLine();
        }

        //"Press ENTER to close this window" method.
        static void End()
        {
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("*");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("Press ENTER to close this window");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("*");
            Console.ResetColor();
            Console.ReadLine();
        }

        //method that sets all array values to 0.
        static void InitiateArray(int[,] arrayName)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    arrayName[i, j] = 0;
                }
            }

        }

        //method that prints generation lapses.
        static void TimeLapse(int generations)
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Generations passed: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(generations);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(" (");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Force stop at the 100th generation");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(")");
            Console.WriteLine();
            Console.ResetColor();
            Console.WriteLine();
        }

        //method that prints arrays' content.
        static void ArrayPrinter(int[,] arrayName)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("----------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("PETRI DISH");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("----------");
            Console.WriteLine();
            Console.ResetColor();


            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (arrayName[i, j] == 1) { Console.ForegroundColor = ConsoleColor.Red; }
                    else if (arrayName[i, j] == 0) { Console.ForegroundColor = ConsoleColor.White; }
                    Console.Write(arrayName[i, j]);
                }
                System.Console.WriteLine();
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("1");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(": Living unit");


            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("0");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(": Empty Space");
            Console.WriteLine();

            Console.ResetColor();
        }

        //method that prints the heat-view-like living neighbors' quantity.
        static void UnitsCounterPrinter(int[,] arrayName)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("----------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Neighbors Counter");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("----------");
            Console.WriteLine();
            Console.ResetColor();

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (arrayName[i, j] == 1) { Console.ForegroundColor = ConsoleColor.White; }
                    else if (arrayName[i, j] == 2) { Console.ForegroundColor = ConsoleColor.DarkGreen; }
                    else if (arrayName[i, j] == 3) { Console.ForegroundColor = ConsoleColor.Green; }
                    else if (arrayName[i, j] == 4) { Console.ForegroundColor = ConsoleColor.Red; }
                    else if (arrayName[i, j] > 4) { Console.ForegroundColor = ConsoleColor.DarkRed; }
                    else if (arrayName[i, j] == 0) { Console.ForegroundColor = ConsoleColor.DarkGray; }
                    Console.Write(arrayName[i, j]);
                }
                System.Console.WriteLine();
            }
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Color explanation");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("White");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(":      1 neighbor            (underpopulation)");

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("Dark Green");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(": 2 neighbors           (fine quantity of neighbors)");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Green");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(":      3 neighbors           (fine quantity of neighbors + breeding)");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Red");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(":        4 neighbors           (overpopulation + death)");

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("Dark Red");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(":   more than 4 neighbors (overpopulation + death)");
            Console.WriteLine();

            Console.ResetColor();
        }

        //method that moves one array's content to another.
        static void ArrayTransferer(int[,] FromArray, int[,] ToArray)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    ToArray[i, j] = FromArray[i, j];
                }
            }

        }

        //method that counts each position's living neighbors.
        static void UnitsCalculator(int[,] dishArray, int[,] unitsArray)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    //if first corner
                    if ((i == 0) & (j == 0))
                    {
                        unitsArray[i, j] = dishArray[0, 1] +
                                                 dishArray[1, 0] +
                                                 dishArray[1, 1];
                    }

                    //if second corner
                    else if ((i == 0) & (j == 9))
                    {
                        unitsArray[i, j] = dishArray[0, 8] +
                                                 dishArray[1, 8] +
                                                 dishArray[1, 9];
                    }

                    //if third corner
                    else if ((i == 9) & (j == 0))
                    {
                        unitsArray[i, j] = dishArray[8, 0] +
                                                 dishArray[8, 1] +
                                                 dishArray[9, 1];
                    }

                    //if fourth corner
                    else if ((i == 9) & (j == 9))
                    {
                        unitsArray[i, j] = dishArray[9, 8] +
                                                 dishArray[8, 8] +
                                                 dishArray[8, 9];
                    }

                    //if north bar
                    else if ((i == 0) & ((j > 0) & (j < 9)))
                    {
                        unitsArray[i, j] = dishArray[0, j - 1] +
                                                 dishArray[1, j - 1] +
                                                 dishArray[1, j] +
                                                 dishArray[1, j + 1] +
                                                 dishArray[0, j + 1];
                    }

                    //if south bar
                    else if ((i == 9) & ((j > 0) & (j < 9)))
                    {
                        unitsArray[i, j] = dishArray[9, j - 1] +
                                                 dishArray[8, j - 1] +
                                                 dishArray[8, j] +
                                                 dishArray[8, j + 1] +
                                                 dishArray[9, j + 1];
                    }

                    //if west bar
                    else if (((i > 0) & (i < 9)) & (j == 0))
                    {
                        unitsArray[i, j] = dishArray[i - 1, 0] +
                                                 dishArray[i - 1, 1] +
                                                 dishArray[i, 1] +
                                                 dishArray[i + 1, 1] +
                                                 dishArray[i + 1, 0];
                    }

                    //if east bar
                    else if (((i > 0) & (i < 9)) & (j == 9))
                    {
                        unitsArray[i, j] = dishArray[i - 1, 9] +
                                                 dishArray[i - 1, 8] +
                                                 dishArray[i, 8] +
                                                 dishArray[i + 1, 8] +
                                                 dishArray[i + 1, 9];
                    }

                    //if cube body
                    else
                    {
                        unitsArray[i, j] = dishArray[i - 1, j - 1] +
                                                 dishArray[i - 1, j] +
                                                 dishArray[i - 1, j + 1] +
                                                 dishArray[i, j + 1] +
                                                 dishArray[i + 1, j + 1] +
                                                 dishArray[i + 1, j] +
                                                 dishArray[i + 1, j - 1] +
                                                 dishArray[i, j - 1];
                    }

                }
            }
        }

        //method that decides who lives and dies. (cool)
        static void EvolutionRules(int[,] dishArray, int[,] unitsArray)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if ((unitsArray[i, j] < 2) & (dishArray[i, j] == 1)) { dishArray[i, j] = 0; }
                    //else if ( ( (unitsArray[i, j] ==2) | (unitsArray[i, j] == 3) ) & (dishArray[i, j] == 1) ) { dishArray[i, j] = 1; } NOT NEEDED - happens anyway.
                    else if ((unitsArray[i, j] >= 4) & (dishArray[i, j] == 1)) { dishArray[i, j] = 0; }
                    else if ((unitsArray[i, j] == 3) & (dishArray[i, j] == 0)) { dishArray[i, j] = 1; }

                }
            }
        }

        //method that sets the pattern
        static void Mode(int setMode, int[,] dishArray)
        {

            if (setMode == 1)
            {
                Random rnd = new Random();
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        int random = rnd.Next(1, 101);

                        if ((random >= 1) & (random < 51))
                        {
                            dishArray[i, j] = 1;
                        }

                        else
                        {
                            dishArray[i, j] = 0;
                        }
                    }
                }



            }

            if (setMode == 2)
            {
                dishArray[1, 1] = 1;
                dishArray[1, 2] = 1;
                dishArray[2, 1] = 1;
                dishArray[2, 2] = 1;

                dishArray[1, 7] = 1;
                dishArray[2, 6] = 1;
                dishArray[2, 8] = 1;
                dishArray[3, 7] = 1;

                dishArray[7, 0] = 1;
                dishArray[6, 1] = 1;
                dishArray[6, 2] = 1;
                dishArray[7, 3] = 1;
                dishArray[8, 2] = 1;
                dishArray[8, 1] = 1;

                dishArray[6, 7] = 1;
                dishArray[6, 8] = 1;
                dishArray[7, 7] = 1;
                dishArray[8, 8] = 1;
                dishArray[7, 9] = 1;
            }

            if (setMode == 3)
            {
                dishArray[1, 1] = 1;
                dishArray[2, 1] = 1;
                dishArray[3, 1] = 1;

                dishArray[2, 4] = 1;
                dishArray[3, 4] = 1;
                dishArray[4, 5] = 1;
                dishArray[1, 6] = 1;
                dishArray[2, 7] = 1;
                dishArray[3, 7] = 1;

                dishArray[6, 2] = 1;
                dishArray[6, 3] = 1;
                dishArray[7, 2] = 1;
                dishArray[7, 3] = 1;
                dishArray[8, 4] = 1;
                dishArray[8, 5] = 1;
                dishArray[9, 4] = 1;
                dishArray[9, 5] = 1;
            }

            if (setMode == 4)
            {
                dishArray[2, 0] = 1;
                dishArray[2, 1] = 1;
                dishArray[2, 2] = 1;
                dishArray[1, 2] = 1;
                dishArray[0, 1] = 1;

            }

        }

        //method that checks if Emulation must stop
        static bool TerminateExecution(int[,] dishArray, int[,] previousDishArray)
        {

            bool decision;

            if (dishArray.Cast<int>().SequenceEqual(previousDishArray.Cast<int>()))
            {
                decision = true;
            }
            else
            {
                decision = false;
            }

            ArrayTransferer(dishArray, previousDishArray);
            return decision;
        }

        //Starts the Emulation
        static void ExecuteModel(int modeSelection, int[,] dishArray, int[,] previousDishArray, int[,] tempDishArray, int[,] unitsArray)
        {
            //2d arrays' initialization
            InitiateArray(dishArray);
            InitiateArray(previousDishArray);
            InitiateArray(tempDishArray);
            InitiateArray(unitsArray);

            int generations = 0;
            int turns = 0;

            Mode(modeSelection, dishArray);

            while ((TerminateExecution(dishArray, previousDishArray) == false) & (turns < 100))
            {

                generations++;
                turns++;

                ArrayTransferer(dishArray, tempDishArray);
                ArrayTransferer(dishArray, previousDishArray);

                UnitsCalculator(tempDishArray, unitsArray);

                EvolutionRules(tempDishArray, unitsArray);

                ArrayTransferer(tempDishArray, dishArray);


                TimeLapse(generations);
                ArrayPrinter(dishArray);

                UnitsCalculator(dishArray, unitsArray);
                UnitsCounterPrinter(unitsArray);

                Thread.Sleep(500);
                Console.Clear();

            }
            Wait();

        }

        //the Mother Brain of the whole operation.
        static void Menu(int[,] dishArray, int[,] previousDishArray, int[,] tempDishArray, int[,] unitsArray)
        {
            string input;
            int option;

            Console.Clear();
            Logo();
            Thread.Sleep(2000); //waits for 2 seconds


            do
            {

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;

                Console.WriteLine(" __  __                  ");
                Console.WriteLine("|  \\/  |                 ");
                Console.WriteLine("| \\  / | ___ _ __  _   _ ");
                Console.WriteLine("| |\\/| |/ _ \\ '_ \\| | | |");
                Console.WriteLine("| |  | |  __/ | | | |_| |");
                Console.WriteLine("|_|  |_|\\___|_| |_|\\__,_|");
                Console.WriteLine();
                Console.WriteLine();
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("1) ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Random Unit Generation");
                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("2) ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Still Lifes");
                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("3) ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Oscillators (Stops at the 100th generation)");
                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("4) ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Spaceships (Glider)");

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("----------------------------");

                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("5) ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("About above Options");
                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("6) ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("About Game");
                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("7) ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Programmer's Github Page");
                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("0) ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Quit");
                Console.WriteLine();
                Console.WriteLine();

                Console.Write("Choose an Option: ");
                Console.ResetColor();


                do //checking for empty entry (just pressing enter).
                {
                    input = Console.ReadLine();

                    if (string.IsNullOrEmpty(input))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("*");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("You need to enter a value!");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("*");
                        Console.ResetColor();
                    }

                } while (string.IsNullOrEmpty(input));
                ;

                option = int.Parse(input); //String to int conversion.

                Console.Clear();


                if ((option > 0) & (option < 5)) //game mode setting and launching. let's have fun!
                {
                    ExecuteModel(option, dishArray, previousDishArray, tempDishArray, unitsArray);
                }

                else if (option == 5) //user needs to know what the options are.
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Blue;

                    Console.WriteLine("          _                 _           _                       ____        _   _");
                    Console.WriteLine("    /\\   | |               | |         | |                     / __ \\      | | (_)");
                    Console.WriteLine("   /  \\  | |__   ___  _   _| |_    __ _| |__   _____   _____  | |  | |_ __ | |_ _  ___  _ __  ___");
                    Console.WriteLine("  / /\\ \\ | '_ \\ / _ \\| | | | __|  / _` | '_ \\ / _ \\ \\ / / _ \\ | |  | | '_ \\| __| |/ _ \\| '_ \\/ __|");
                    Console.WriteLine(" / ____ \\| |_) | (_) | |_| | |_  | (_| | |_) | (_) \\ V /  __/ | |__| | |_) | |_| | (_) | | | \\__ \\");
                    Console.WriteLine("/_/    \\_\\_.__/ \\___/ \\__,_|\\__|  \\__,_|_.__/ \\___/ \\_/ \\___|  \\____/| .__/ \\__|_|\\___/|_| |_|___/");
                    Console.WriteLine("                                                                      | |                          ");
                    Console.WriteLine("                                                                      |_| ");
                    Console.WriteLine();
                    Console.WriteLine();

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("1) ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("Random Unit Generation: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Generate a random pattern and observe the units evolve with time. The outcome is almost always different.");
                    Console.WriteLine();

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("2) ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("Still Lifes: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("A still life is a pattern that does not change from one generation to the next. A still life can be thought of as an oscillator with unit period.");
                    Console.WriteLine();

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("3) ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("Oscillators: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("In a cellular automaton, an oscillator is a pattern that returns to its original state, in the same orientation and position, ");
                    Console.WriteLine("after a finite number of generations. Thus the evolution of such a pattern repeats itself indefinitely. Depending on context, the term may also include spaceships as well.");
                    Console.WriteLine();

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("4) ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("Spaceships (Glider): ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("A spaceship (also referred to as a glider or less commonly a fish, and commonly shortened to \"ship\" ");
                    Console.WriteLine("is a finite pattern that returns to its initial state after a number of generations (known as its period) but in a different location.");
                    Console.WriteLine("after a finite number of generations. Thus the evolution of such a pattern repeats itself indefinitely. Depending on context, the term may also include spaceships as well.");
                    Console.WriteLine();

                    Console.WriteLine("~By Wikipedia.");
                    Console.WriteLine();
                    Console.ResetColor();
                    Wait();
                }

                else if (option == 6) //user needs to know what this game is about.
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Blue;

                    Console.WriteLine("          _                 _      _____");
                    Console.WriteLine("    /\\   | |               | |    / ____|");
                    Console.WriteLine("   /  \\  | |__   ___  _   _| |_  | |  __  __ _ _ __ ___   ___");
                    Console.WriteLine("  / /\\ \\ | '_ \\ / _ \\| | | | __| | | |_ |/ _` | '_ ` _ \\ / _ \\");
                    Console.WriteLine(" / ____ \\| |_) | (_) | |_| | |_  | |__| | (_| | | | | | |  __/");
                    Console.WriteLine("/_/    \\_\\_.__/ \\___/ \\__,_|\\__|  \\_____|\\__,_|_| |_| |_|\\___|");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.White;

                    Console.WriteLine("The Game of Life, also known simply as Life, is a cellular automaton devised by the British mathematician John Horton Conway in 1970.");
                    Console.WriteLine();
                    Console.WriteLine("The game is a zero - player game, meaning that its evolution is determined by its initial state, requiring no further input.");
                    Console.WriteLine("One interacts with the Game of Life by creating an initial configuration and observing how it evolves, or, for advanced players, by creating patterns with particular properties.");
                    Console.WriteLine();
                    Console.WriteLine("The universe of the Game of Life is an infinite, two - dimensional orthogonal grid of square cells, each of which is in one of two possible states, alive or dead, (or populated and unpopulated, respectively).");
                    Console.WriteLine();
                    Console.WriteLine("Every cell interacts with its eight neighbours, which are the cells that are horizontally, vertically, or diagonally adjacent.At each step in time, the following transitions occur:");
                    Console.WriteLine("Any live cell with fewer than two live neighbors dies, as if by under population.");
                    Console.WriteLine("Any live cell with two or three live neighbors lives on to the next generation.");
                    Console.WriteLine("Any live cell with more than three live neighbors dies, as if by overpopulation.");
                    Console.WriteLine("Any dead cell with exactly three live neighbors becomes a live cell, as if by reproduction.");
                    Console.WriteLine();
                    Console.WriteLine("The initial pattern constitutes the seed of the system.The first generation is created by applying the above rules simultaneously to every cell in the seed; births and deaths occur simultaneously, ");
                    Console.WriteLine("and the discrete moment at which this happens is sometimes called a tick. Each generation is a pure function of the preceding one.");
                    Console.WriteLine("The rules continue to be applied repeatedly to create further generations.");
                    Console.WriteLine();
                    Console.WriteLine("~By Wikipedia.");
                    Console.WriteLine();

                    Wait();
                }

                else if (option == 7) //opens that link on the default browser
                {
                    System.Diagnostics.Process.Start("https://github.com/creatorpanda");
                }

                else if (option == 0) //Bye World
                {


                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Clear();
                    Console.WriteLine(" ______                 _       _               _______                  _             _           _ ");
                    Console.WriteLine("|  ____|               | |     | |             |__   __|                (_)           | |         | |");
                    Console.WriteLine("| |__   _ __ ___  _   _| | __ _| |_ ___ _ __      | | ___ _ __ _ __ ___  _ _ __   __ _| |_ ___  __| |");
                    Console.WriteLine("|  __| | '_ ` _ \\| | | | |/ _` | __/ _ \\| '__|    | |/ _ \\ '__| '_ ` _ \\| | '_ \\ / _` | __/ _ \\/ _` |");
                    Console.WriteLine("| |____| | | | | | |_| | | (_| | || (_) | |       | |  __/ |  | | | | | | | | | | (_| | ||  __/ (_| |");
                    Console.WriteLine("|______|_| |_| |_|\\__,_|_|\\__,_|\\__\\___/|_|       |_|\\___|_|  |_| |_| |_|_|_| |_|\\__,_|\\__\\___|\\__,_|");
                    Console.WriteLine();
                    Console.WriteLine();

                    Signature();
                }

            } while (option != 0);
        }


        static void Main(string[] args)
        {
            //Console.SetWindowSize(189, 57); //Change window size to recommended. Disabled this command because the program crashes on some other devices.

            //2d arrays' creation
            int[,] petriDish = new int[10, 10];           //2D array that trades values with "tempDish" and carries the units' positions.
            int[,] previousPetriDish = new int[10, 10];   //2D array for comparing to "petriDish".
            int[,] tempDish = new int[10, 10];            //2D array for processing info.
            int[,] unitsCounter = new int[10, 10];        //2D array for saving neighbors' quantity.

            Menu(petriDish, previousPetriDish, tempDish, unitsCounter); //everything starts here.

        }
    }
}
