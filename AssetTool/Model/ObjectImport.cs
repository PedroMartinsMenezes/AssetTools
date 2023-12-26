using AssetTool.Model.Basic;

namespace AssetTool.Model
{
    public class FObjectResource
    {
        //public FName ObjectName = new();
        //public FPackageIndex OuterIndex = new();
        //public FName OldClassName = new();
    }

    public class FObjectImport : FObjectResource
    {
        //public FName PackageName = new();
        //public FName ClassPackage = new();
        //public FName ClassName = new();
        //public bool bImportOptional;

        public FName A = new();
        public FName B = new();
        public FName C = new();
        public FPackageIndex D = new();
    }

    public class FPackageIndex
    {
        public Int32 Index;
    }


}
