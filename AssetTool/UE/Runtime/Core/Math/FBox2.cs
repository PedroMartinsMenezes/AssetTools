namespace AssetTool
{
    public class FBox2d : ITransferible
    {
        public FVector2d Min = new();
        public FVector2d Max = new();
        public byte IsValid;

        public ITransferible Move(Transfer transfer)
        {
            Min.Move(transfer);
            Max.Move(transfer);
            transfer.Move(ref IsValid);
            return this;
        }
    }

    public class FBox2f : ITransferible
    {
        public FVector2f Min = new();
        public FVector2f Max = new();
        public byte IsValid;

        public ITransferible Move(Transfer transfer)
        {
            Min.Move(transfer);
            Max.Move(transfer);
            transfer.Move(ref IsValid);
            return this;
        }
    }
}
