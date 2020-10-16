using System.IO;
using System.Text;

class WorkingWithFile
{
    public bool WriteTextIntoFile(string fileName, string content)
    {
        bool result = false;
        FileStream file = new FileStream(fileName, FileMode.OpenOrCreate);
        using (StreamWriter writer = new StreamWriter(file, Encoding.Unicode))
        {
            writer.WriteLine(content);
            result = true;
        }

        return result;
    }

    public string ReadTextFromFile(string fileName)
    {
        string jsonTextFromFile;
        using (StreamReader reader = new StreamReader(fileName, Encoding.Unicode))
        {
            jsonTextFromFile = reader.ReadToEnd();
            
        }

        return jsonTextFromFile;
    }
}