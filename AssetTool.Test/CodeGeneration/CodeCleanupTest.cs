using NUnit.Framework;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;

namespace AssetTool.Test.CodeGeneration
{
    public class CodeCleanupTest : TestBase
    {
        [Test]
        public void ListJsonAssetClasses()
        {
            Assembly asm = Assembly.LoadFrom(@"AssetTool\bin\Debug\net8.0\AssetTool.dll");
            var types = asm.GetTypes().Where(t => t.IsDefined(typeof(JsonAssetAttribute), false)).ToList();
            Dictionary<string, string> classNames = [];
            foreach (var type in types)
            {
                string className = type.Name.Substring(1);
                string baseClass = type.BaseType.Name.Substring(1);
                classNames.Add(className, baseClass);
            }
            File.WriteAllText("C:/Temp/JsonAssetClasses.json", classNames.ToJson());
        }

        [Test]
        public void ListEmptyClasses()
        {
            var regex = new Regex(@"\[JsonAsset\(""[^""]+""\)\]\s*public\s+class\s+(\w+)\s*:\s*(\w+)\s*\{\s*public\s+override\s+ITransferable\s+Move\(Transfer\s+transfer\)\s*\{\s*return\s+base\.Move\(transfer\);\s*\}\s*\}", RegexOptions.Singleline);
            string folder = @"AssetTool";
            string[] files = Directory.GetFiles(folder, "*.cs", SearchOption.AllDirectories);
            Dictionary<string, string> classNames = [];
            HashSet<string> filesToDelete = [];
            foreach (string file in files)
            {
                long fileLength = new FileInfo(file).Length;
                var code = File.ReadAllText(file);
                var matches = regex.Matches(code);
                foreach (Match match in matches)
                {
                    filesToDelete.Add(file);
                    if (match.Success)
                    {
                        string className = match.Groups[1].Value.Substring(1);
                        string baseClass = match.Groups[2].Value.Substring(1);
                        classNames.Add(className, baseClass);
                    }
                }
            }
            File.WriteAllText("C:/Temp/EmptyClasses.json", classNames.ToJson());
            File.WriteAllLines("C:/Temp/FilesToDelete.txt", filesToDelete);
        }
    }
}
