using System.Diagnostics;
using System.Globalization;

namespace AssetTool
{
    public static class Program
    {
        static async Task Main(string[] args)
        {
            var cultureInfo = CultureInfo.InvariantCulture;
            CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
            CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;
            string path = "StackOBot_Files.txt";
            Console.WriteLine($"Processing: {path} ...");

            Stopwatch w = new Stopwatch();
            var files = await File.ReadAllLinesAsync(path);
            w.Start();
            Log.Enabled = true;
            CancellationTokenSource cts = new();
            await Parallel.ForEachAsync(files, new ParallelOptions { CancellationToken = cts.Token }, async (file, ct) =>
            {
                bool success = await StructWriter.RebuildAssetFastAsync(file, "");
                if (!success)
                {
                    await cts.CancelAsync();
                    return;
                }
            });
            cts.Dispose();
            w.Stop();
            Console.WriteLine($"File Count   : {files.Length}");
            Console.WriteLine($"Total Seconds: {w.Elapsed.TotalSeconds:0.00}");
        }
    }
}