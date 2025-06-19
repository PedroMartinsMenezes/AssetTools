namespace AssetTool
{
    [TransferibleStruct("Box3d")]
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
    public class FBox : ITransferible
    {
        public FVector3 Min;
        public FVector3 Max;
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
