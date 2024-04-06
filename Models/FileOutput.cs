namespace cSharp_Animals.Models;

using System;
using System.IO;

public class FileOutput : IDisposable
{
    private StreamWriter _writer;
    private string _fileName;

    public FileOutput(string fileName)
    {
        // Get the full path in the current working directory
        string fullPath = Path.Combine(Directory.GetCurrentDirectory(), fileName);

        this._fileName = fullPath;
        try
        {
            _writer = new StreamWriter(fullPath);
        }
        catch (FileNotFoundException e)
        {
            Console.WriteLine($"File Open Error: {fullPath} {e}");
        }
    }

    public void FileWrite(string line)
    {
        try
        {
            _writer.WriteLine(line); // StreamWriter.WriteLine automatically appends a newline character
        }
        catch (Exception e)
        {
            Console.WriteLine($"File Write Error: {_fileName} {e}");
        }
    }

    public void FileClose()
    {
        Dispose();
    }

    public void Dispose()
    {
        if (_writer != null)
        {
            _writer.Dispose();
        }
    }
}
