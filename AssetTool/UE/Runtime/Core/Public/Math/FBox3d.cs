namespace AssetTool
{
    [TransferibleStruct("Box3d")]
    public class FBox3d : ITransferible
    {
        public FVector3d Min = new();
        public FVector3d Max = new();
        public byte IsValid;

        public ITransferible Move2(Transfer transfer)
        {
            Min.Move2(transfer);
            Max.Move2(transfer);
            transfer.Move(ref IsValid);
            return this;
        }
    }

    [TransferibleStruct("Box3f")]
    public class FBox3f : ITransferible
    {
        public FVector3f Min = new();
        public FVector3f Max = new();
        public byte IsValid;

        public ITransferible Move2(Transfer transfer)
        {
            Min.Move2(transfer);
            Max.Move2(transfer);
            transfer.Move(ref IsValid);
            return this;
        }
    }

    [TransferibleStruct("Box")]
    public class FBox : ITransferible
    {
        public FVector3 Min = new();
        public FVector3 Max = new();
        public byte IsValid;

        public ITransferible Move2(Transfer transfer)
        {
            Min.Move2(transfer);
            Max.Move2(transfer);
            transfer.Move(ref IsValid);
            return this;
        }
    }
}
