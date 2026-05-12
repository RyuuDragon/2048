namespace _2048WinFormsApp
{
    public class FileManager
    {
        public static FileInfo Info(string path)
        {
            FileInfo fileInfo = new FileInfo(path);

            return fileInfo;
        }

        public static void Save(string path, string data)
        {
            using (var writer = new StreamWriter(path, false))
            {
                writer.WriteLine(data);
            }
        }

        public static string Load(string path)
        {
            using var reader = new StreamReader(path);
            var data = reader.ReadToEnd();
            return data;
        }
    }
}
