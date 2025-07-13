using System.Diagnostics;

namespace AssetTool
{
    public static class Program
    {
        static async Task Main(string[] args)
        {
            Stopwatch w = new Stopwatch();
            w.Start();
            string file = "C:/Program Files/Epic Games/UE_5.5/Engine/Plugins/Animation/ControlRigModules/Content/Modules/Neck.uasset";
            bool success = await StructWriter.RebuildAssetFastAsync(file, "");
            w.Stop();
            Console.WriteLine($"\n\nSuccess: {success}.\n\n{file}\n\nTotal Seconds: {w.Elapsed.TotalSeconds:0.00}");
        }
    }
}