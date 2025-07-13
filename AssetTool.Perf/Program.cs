using System.Diagnostics;

namespace AssetTool
{
    public static class Program
    {
        static async Task Main(string[] args)
        {
            string path = "Cropout_Files.txt";
            Stopwatch w = new Stopwatch();
            var files = await File.ReadAllLinesAsync(path);
            Console.WriteLine($"File Count   : {files.Length}");
            w.Start();
            bool success = false;
            string file = null;
            int i = 0;
            for (i = 145; i < files.Length; i++)
            {
                file = files[i]; ;
                success = await StructWriter.RebuildAssetFastAsync(file, "");
                if (!success)
                {
                    Log.Enabled = true;
                    success = await StructWriter.RebuildAssetFastAsync(file, "");
                    break;
                }
            }
            w.Stop();

            Console.WriteLine($"\n\nSuccess: {success}.\n\n[{i}] {file}\n\nTotal Seconds: {w.Elapsed.TotalSeconds:0.00}");
        }
    }
}