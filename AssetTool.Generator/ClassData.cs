namespace AssetTool.Generator
{
    public class ClassData
    {
        public string ClassName { get; set; }
        public string BaseClassName { get; set; }
        public string ClassAttribute
        {
            get
            {
                if (!ClassName.Contains("DEPRECATED_"))
                    return ClassName.Substring(1);
                else
                    return ClassName.Replace("DEPRECATED_", "").Substring(1);
            }
        }
    }
}
