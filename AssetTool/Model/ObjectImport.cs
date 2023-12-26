using AssetTool.Model.Basic;

namespace AssetTool.Model
{
    public class FObjectImport
    {
        public FName PackageName = new();
        public FName ClassPackage = new();
        public FName ClassName = new();
        public FPackageIndex OuterIndex = new();

        public FObjectImport() { }

        public FObjectImport(FName a, FName b, FName c, Int32 d)
        {
            PackageName = a;
            ClassPackage = b;
            ClassName = c;
            OuterIndex = new() { Index = d };
        }
    }
}
