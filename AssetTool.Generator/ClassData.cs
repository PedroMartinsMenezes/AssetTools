namespace AssetTool.Generator
{
    public class ClassData
    {
        public string ClassName { get; set; }
        public string BaseClassName { get; set; }
        public string ClassAttribute => ClassName.Substring(1);
    }
}
