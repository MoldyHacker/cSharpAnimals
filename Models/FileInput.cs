using System;
using System.IO;

public class FileInput : IDisposable
{
    private StreamReader _reader = null;
    private string _fileName;

    public FileInput(string fileName)
    {
        // Get the full path in the current working directory
        string fullPath = Path.Combine(Directory.GetCurrentDirectory(), fileName);

        this._fileName = fullPath;
        try
        {
            _reader = new StreamReader(fullPath);
        }
        catch (FileNotFoundException e)
        {
            Console.WriteLine($"File Open Error: {fullPath} {e}");
        }
    }

    public void FileRead()
    {
        string line;
        try
        {
            while ((line = _reader.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"File Write Error: {_fileName} {e}");
        }
    }

    public string FileReadLine()
    {
        try
        {
            return _reader.ReadLine();
        }
        catch (Exception e)
        {
            Console.WriteLine($"File Write Error: {_fileName} {e}");
            return null;
        }
    }

    public void FileClose()
    {
        Dispose();
    }

    public void Dispose()
    {
        if (_reader != null)
        {
            _reader.Dispose();
        }
    }
}
