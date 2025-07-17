using System.Diagnostics;

namespace AssetTool
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Log.Enabled = true;
            Stopwatch w = new Stopwatch();
            var files = File.ReadAllLines("Lyra_Failed.txt");
            var Lyra_Failed = files.ToList();
            w.Start();
            foreach (var file in files)
            {
                bool success = StructWriter.RebuildAssetFast(file, "");
                if (success) Lyra_Failed.Remove(file);
            }
            w.Stop();
            Console.WriteLine($"File Count   : {files.Length}");
            Console.WriteLine($"Total Seconds: {w.Elapsed.TotalSeconds:0.00}");
            File.WriteAllLines("Lyra_Failed.txt", Lyra_Failed);
        }
    }
}