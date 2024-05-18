namespace AssetTool
{
    public class FBox2D
    {
        public FVector2D Min = new();
        public FVector2D Max = new();
        public byte IsValid;

        public const string StructName = "Box2D";

        public FBox2D Move(Transfer transfer)
        {
            Min.Move(transfer);
            Max.Move(transfer);
            transfer.Move(ref IsValid);
            return this;
        }
    }
}
