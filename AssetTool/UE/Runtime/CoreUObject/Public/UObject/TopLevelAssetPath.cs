using System.Diagnostics;

namespace AssetTool
{
    [DebuggerDisplay("{PackageName} {AssetName}")]
    public class FTopLevelAssetPath : ITransferable
    {
        public FName PackageName;
        public FName AssetName;

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref PackageName);
            transfer.Move(ref AssetName);
            return this;
        }

        public bool IsNull(Transfer transfer)
        {
            return !PackageName.IsFilled() || PackageName.IsNone(transfer);
        }
    }
}
