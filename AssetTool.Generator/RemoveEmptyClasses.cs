using System.Text.RegularExpressions;

namespace AssetTool.Generator
{
    public class RemoveEmptyClasses
    {
        public void RemoveUObjectClasses(string[] files)
        {
            string pattern = @"namespace AssetTool\s*{\s*\[JsonAsset\(""\w+""\)\]\s*public class \w+ : UObject\s*{\s*public override ITransferable Move\(Transfer transfer\)\s*{\s*return base\.Move\(transfer\);\s*}\s*}\s*}";

            foreach (string file in files)
            {
                string input = File.ReadAllText(file);
                if (Regex.IsMatch(input, pattern, RegexOptions.Multiline))
                {
                    File.Delete(file);
                }
            }
        }
    }
}
