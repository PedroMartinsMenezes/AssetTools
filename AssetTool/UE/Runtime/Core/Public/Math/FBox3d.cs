using System.Diagnostics;

namespace AssetTool
{
    [TransferibleStruct("Box3d")]
    [DebuggerDisplay("Min{Min} Max{Max} {IsValid}")]
    public class FBox3d : ITransferible
    {
        public FVector3d Min;
        public FVector3d Max;
        public byte IsValid;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Min);
            transfer.Move(ref Max);
            transfer.Move(ref IsValid);
            return this;
        }
    }

    [TransferibleStruct("Box3f")]
    [DebuggerDisplay("Min{Min} Max{Max} {IsValid}")]
    public class FBox3f : ITransferible
    {
        public FVector3f Min;
        public FVector3f Max;
        public byte IsValid;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Min);
            transfer.Move(ref Max);
            transfer.Move(ref IsValid);
            return this;
        }
    }

    [TransferibleStruct("Box")]
    [DebuggerDisplay("Min{Min} Max{Max} {IsValid}")]
    public class FBox : ITransferible
    {
        public FVector Min;
        public FVector Max;
        public byte IsValid;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Min);
            transfer.Move(ref Max);
            transfer.Move(ref IsValid);
            return this;
        }
    }
}
