using System;
using System.Collections.Generic;

namespace bingoTask {
    class Program {
        static void Main (string[] args) {
            System.Console.WriteLine ("Please input a number, all generated numbers will be between 1 and your chosen number:");
            System.Console.Write ("Magic Number: ");

            var magicNumber = int.Parse (Console.ReadLine ());

            if (magicNumber > 0) {
                List<int> drawnNumbers = new List<int> ();
                Random rnd = new Random ();
                var userInput = 0;

                while (userInput != 4) {
                    Menu ();
                    userInput = int.Parse (Console.ReadLine ());

                    if (userInput == 1) {

                        var drawn = rnd.Next (1, magicNumber + 1);

                        //prevent duplicate draws
                        while (drawnNumbers.Contains (drawn)) {
                            drawn = rnd.Next (1, magicNumber + 1);
                        }

                        System.Console.WriteLine ("====================================");
                        System.Console.WriteLine ("Drawn number is: " + drawn);

                        drawnNumbers.Add (drawn);

                    } else if (userInput == 2) {
                        var orderChoice = 0;

                        while (orderChoice != 1 && orderChoice != 2) {
                            System.Console.WriteLine ("====================================");
                            System.Console.WriteLine ("In what order would you like the numbers displayed in?");
                            System.Console.WriteLine ("1. Drawn sequence");
                            System.Console.WriteLine ("2. Ascending");
                            System.Console.Write ("What will you choose?: ");
                            orderChoice = int.Parse (Console.ReadLine ());
                            System.Console.WriteLine ("====================================");
                        }

                        if (orderChoice == 1) {
                            for (var i = 0; i < drawnNumbers.Count; i++) {
                                System.Console.Write (drawnNumbers[i] + " ");
                            }
                        }
                        if (orderChoice == 2) {
                            List<int> ascendingDrawn = drawnNumbers;
                            var maxValue = 0;

                        for (var i = 0; i < drawnNumbers.Count; i++) {
                            if (drawnNumbers[i] > maxValue) {
                                maxValue = drawnNumbers[i];
                            }
                        }
                            for (var i = 0; i <= maxValue; i++) {
                                if (ascendingDrawn.Contains(i))
                                System.Console.Write (i + " ");
                            }
                        }
                        System.Console.WriteLine ();

                    } else if (userInput == 3) {
                        System.Console.WriteLine ("====================================");
                        System.Console.Write ("What number are we checking for?: ");
                        var checkNum = int.Parse (Console.ReadLine ());
                        System.Console.WriteLine ("====================================");

                        for (var i = 0; i < drawnNumbers.Count; i++) {
                            if (drawnNumbers[i] == checkNum) {
                                System.Console.WriteLine ("This number HAS been drawn.");
                                break;
                            } else if (i == drawnNumbers.Count - 1) {
                                System.Console.WriteLine ("This number HAS NOT been drawn.");
                            }
                        }
                    } else if (userInput == 4) {
                        System.Console.WriteLine ("====================================");
                        System.Console.WriteLine ("Goodbye");
                        System.Console.WriteLine ("====================================");
                    } else {
                        System.Console.WriteLine ("====================================");
                        System.Console.WriteLine ("That isn't a valid option, try again.");
                    }
                }
            } else {
                System.Console.WriteLine ("Don't try and mess with me.");
                System.Environment.Exit (0);
            }

        }
        static public void Menu () {
            System.Console.WriteLine ("====================================");
            System.Console.WriteLine ("Welcome to the Swinburne Bingo Club");
            System.Console.WriteLine ("1. Draw next number");
            System.Console.WriteLine ("2. View all drawn numbers");
            System.Console.WriteLine ("3. Check specific number");
            System.Console.WriteLine ("4. Exit");
            System.Console.Write ("What will you choose?: ");
        }
    }
}