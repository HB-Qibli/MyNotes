using System;
using System.Collections.Generic;
using System.Threading;

namespace System{
public class Book
{
    public string Title;
    public List<Chapter> Chapters;

    List<ConsoleColor> colors = new List<ConsoleColor> //list of colours to go trough when wanting to print rainbow shit
        {
            ConsoleColor.Red,
            ConsoleColor.Green,
            ConsoleColor.Blue,
            ConsoleColor.Yellow,
            ConsoleColor.Magenta,
            ConsoleColor.Cyan
        };

        int colorIdx = 0; //index of color list


    public Book(string title)
    {
        Console.BackgroundColor = ConsoleColor.Black;
        Title = title;
        Chapters = new List<Chapter>();
    }

    public Book(string title, List<Chapter> chapters)
    {
        Console.BackgroundColor = ConsoleColor.Black;
        Title = title;
        Chapters = chapters;
    }

    public void PrintChapters()
    {
        //Print chapter titles
        Console.WriteLine("\nChapter titles:");
        Console.ForegroundColor = ConsoleColor.White;
        foreach (Chapter chapter in Chapters)
        {
            Console.ForegroundColor = colors[colorIdx]; //loop trough colours in list so each title has diff, unless is mare than 6.
            Console.WriteLine(chapter.Title);
            colorIdx = (colorIdx + 1) % colors.Count; // if over last index, loop back to first
        }
        Console.ResetColor();
    }

    private Chapter GetChapter(string title)
    {
        foreach (Chapter chapter in Chapters)
        {
            if (chapter.Title == title)
            {
                return chapter;
            }
        }
        return null;
    }

    public string RecursiveWriteLine(string text)
    {
        if (text.Length == 0)
        {
            return "";
        }
        else
        {
            Console.Write(text[0]);
            Thread.Sleep(1);
            return RecursiveWriteLine(text.Substring(1));
        }
    }

    public static void WriteLine(string text)
    {
        foreach (char letter in text)
        {
            Console.Write(letter);
            Thread.Sleep(1);
        }
    }

    public void Start()
    {
        while (true)
        {
            //Print book title and introduction
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(Title);
            Console.ResetColor();

            Book.WriteLine("\nWelcome to your programming notes. " +
                "This program will help you keep track of your notes " +
                "for your programming projects.\n");

            //Print chapter titles
            PrintChapters();

            Console.WriteLine("\nEnter a chapter title (or 'quit/q/exit' to exit):");
            string input = Console.ReadLine();
            if (input.ToLower() == "quit" || input.ToLower() == "q" || input.ToLower() == "exit")
            {
                break;
            }
            Chapter chapterToRead = GetChapter(input);
            if (chapterToRead == null)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Chapter not found.\n");
                Console.ResetColor();
                continue;
                
            }
            chapterToRead.Read();
        }
    }
}
}