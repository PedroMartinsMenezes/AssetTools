namespace AssetTool.Model
{
    public class FObjectImport
    {
        public string ClassPackage = string.Empty; //FName 
        public string ClassName = string.Empty; //FName
        public FPackageIndex OuterIndex = new();
        public string ObjectName = string.Empty;
        public string PackageName = string.Empty;
        public bool bImportOptional;
    }

    public class FPackageIndex
    {
        public Int32 Index;
    }
}
