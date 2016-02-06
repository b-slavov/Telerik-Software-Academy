using System;
using System.IO;

class ReadFileContents
{
    static void Main()
    {
        Console.Write("Enter file name (with full path): ");
        string fileName = Console.ReadLine();

        try
        {
            Console.WriteLine(File.ReadAllText(fileName));
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Invalid path or file name");
        }
        catch (PathTooLongException)
        {
            Console.WriteLine("Path is too long");
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("Directory not found");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("No access to file");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not found");
        }
        catch (IOException)
        {
            Console.WriteLine("An I/O error occurred while opening the file");
        }
        catch (NotSupportedException)
        {
            Console.WriteLine("Path is in an invalid format.");
        }
    }
}