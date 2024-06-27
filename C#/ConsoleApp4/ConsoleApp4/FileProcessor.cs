namespace ConsoleApp4;

public class FileProcessor
{
    public void ProcessFile(string FileName)
    {
        FileStream fileStream = null;
        try
        {
            fileStream = new FileStream("Filename.txt", FileMode.Open);
            //perform some operations
            //...

            fileStream.Close();
        }
        catch (IOException ex)
        {
            //handle exception
            Console.WriteLine(ex.Message);
        }
        finally
        {
            if (fileStream != null)
            {
                fileStream.Dispose();
            }
        }
    }
}