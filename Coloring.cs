using System;

namespace MoneyTracking;

public class Coloring
    {
        // Method to set the console text color
        public static void SetColor(ConsoleColor color)
        {
            Console.ForegroundColor = color;
        }

        // Method to center text in the console, It looks good I guess!
        public static string CenterText(string text, int windowWidth)
        {
            int spaces = (windowWidth - text.Length) / 2;
            return new string(' ', spaces) + text;
        }

        // Method to display centered text
        public static void DisplayCenteredText(string text1, string text2)
        {
            int windowWidth = Console.WindowWidth;
            Console.WriteLine(CenterText(text1, windowWidth));
            Console.WriteLine(CenterText(text2, windowWidth));
        }
    }
