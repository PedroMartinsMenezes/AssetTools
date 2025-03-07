using System.Diagnostics;
using System.Text;
using System.Text.RegularExpressions;

namespace AssetTool.Test.CodeGeneration
{
    public class SetDeclarationTest
    {
        ///[Fact]
        public void ListSetDeclarations_From_Plugins()
        {
            string inputDir = "C:\\Program Files\\Epic Games\\UE_5.3\\Engine\\Plugins";
            string pattern = @"UPROPERTY.*\r\n.*TSet<(.*)>\s*(\w+);";
            string declaration = "TransfersForName.Add(\"{0}\", (transfer, value) => {1}.MoveValue(transfer, value.ToObject<{1}>()));";
            StringBuilder declarations = new();
            try
            {
                foreach (string file in Directory.GetFiles(inputDir, "*.h", SearchOption.AllDirectories))
                {
                    if (Regex.Matches(File.ReadAllText(file), pattern) is MatchCollection matches)
                    {
                        foreach (Match match in matches)
                        {
                            string type = match.Groups[1].Value;
                            string name = match.Groups[2].Value;
                            string text = string.Format(declaration, name, type);
                            declarations.AppendLine(text);
                        }
                    }
                }
                File.WriteAllText("C:/Temp/SetDeclarations.txt", declarations.ToString());
            }
            catch (UnauthorizedAccessException ex)
            {
                Debug.WriteLine($"Access to the path {inputDir} is denied. {ex.Message}");
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        ///[Fact]
        public void ListSetDeclarations_From_Source()
        {
            string inputDir = "C:\\src\\UnrealEngine\\Engine\\Source";
            string pattern = @"UPROPERTY.*\r\n.*TSet<(.*)>\s*(\w+);";
            string declaration = "TransfersForName.Add(\"{0}\", (transfer, value) => {1}.MoveValue(transfer, value.ToObject<{1}>()));";
            StringBuilder declarations = new();
            try
            {
                foreach (string file in Directory.GetFiles(inputDir, "*.h", SearchOption.AllDirectories))
                {
                    if (Regex.Matches(File.ReadAllText(file), pattern) is MatchCollection matches)
                    {
                        foreach (Match match in matches)
                        {
                            string type = match.Groups[1].Value;
                            string name = match.Groups[2].Value;
                            string text = string.Format(declaration, name, type);
                            declarations.AppendLine(text);
                        }
                    }
                }
                File.WriteAllText("C:/Temp/SetDeclarations2.txt", declarations.ToString());
            }
            catch (UnauthorizedAccessException ex)
            {
                Debug.WriteLine($"Access to the path {inputDir} is denied. {ex.Message}");
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}
