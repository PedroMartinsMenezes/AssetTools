namespace AssetTool
{
    public class FBox
    {
        public const string StructName = "Box";

        public FVector Min = new();
        public FVector Max = new();
        public byte IsValid;

        public FBox Move(Transfer transfer)
        {
            Min.Move(transfer);
            Max.Move(transfer);
            transfer.Move(ref IsValid);
            return this;
        }
    }
}
