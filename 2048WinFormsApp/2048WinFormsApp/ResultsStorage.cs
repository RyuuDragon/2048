using Newtonsoft.Json;

namespace _2048WinFormsApp
{
    public class ResultsStorage
    {
        private const string Path = "result.json";

        public static void Append(string[] results)
        {
            var userResult = GetAll();
            userResult.Add(results);
            Save(userResult);
        }

        public static int GetBestResult(string name)
        {
            var usersResult = GetAll();
            var results = new List<string[]>();

            foreach (var result in usersResult)
            {
                if (result[0] == name)
                {
                    results.Add(result);
                }
            }

            var bestResult = 0;
            foreach(var result in results)
            {
                if (int.Parse(result[1]) > bestResult)
                {
                    bestResult = int.Parse(result[1]);
                }
            }

            return bestResult;
        }

        public static void Save(List<string[]> results)
        {
            var data = JsonConvert.SerializeObject(results, Formatting.Indented);
            FileManager.Save(Path, data);
        }

        public static List<string[]> GetAll()
        {
            if (IsEmpty())
            {
                return [];
            }

            var data = FileManager.Load(Path);
            var userResult = JsonConvert.DeserializeObject<List<string[]>>(data);
            return userResult;
        }

        public static bool IsEmpty()
        {
            var info = FileManager.Info(Path);
            if (!info.Exists || info.Length == 0)
            {
                return true;
            }

            return false;
        }
    }
}
