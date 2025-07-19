using System.Diagnostics;

namespace AssetTool
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Log.Enabled = true;

            Stopwatch w = new Stopwatch();
            var files = File.ReadAllLines("Lyra_Failed.txt").Where(x => x == "C:\\Program Files\\Epic Games\\UE_5.5\\Samples\\Games\\Lyra\\Content\\Tools\\B_GeneratedTube.uasset").ToArray();
            var Lyra_Failed = files.ToList();
            w.Start();
            for (int i = 0; i < files.Length; i++)
            {
                string file = files[i];

                Console.WriteLine($"{file}");

                bool success = StructWriter.RebuildAssetFast(file, "");

                if (success) Lyra_Failed.Remove(file);
                if (!success)
                {
                    Log.Enabled = true;
                    --i;
                }
            }
            w.Stop();
            Console.WriteLine($"File Count   : {files.Length}");
            Console.WriteLine($"Total Seconds: {w.Elapsed.TotalSeconds:0.00}");
            File.WriteAllLines("Lyra_Failed.txt", Lyra_Failed);
        }
    }
}