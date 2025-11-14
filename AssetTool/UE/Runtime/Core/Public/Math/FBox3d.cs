using System.Diagnostics;

namespace AssetTool
{
    [TransferableStruct("Box3d")]
    [DebuggerDisplay("Min{Min} Max{Max} {IsValid}")]
    public class FBox3d : ITransferable
    {
        public FVector3d Min;
        public FVector3d Max;
        public byte IsValid;

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref Min);
            transfer.Move(ref Max);
            transfer.Move(ref IsValid);
            return this;
        }
    }

    [TransferableStruct("Box3f")]
    [DebuggerDisplay("Min{Min} Max{Max} {IsValid}")]
    public class FBox3f : ITransferable
    {
        public FVector3f Min;
        public FVector3f Max;
        public byte IsValid;

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref Min);
            transfer.Move(ref Max);
            transfer.Move(ref IsValid);
            return this;
        }
    }

    [TransferableStruct("Box")]
    [DebuggerDisplay("Min{Min} Max{Max} {IsValid}")]
    public class FBox : ITransferable
    {
        public FVector Min;
        public FVector Max;
        public byte IsValid;

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref Min);
            transfer.Move(ref Max);
            transfer.Move(ref IsValid);
            return this;
        }
    }
}
