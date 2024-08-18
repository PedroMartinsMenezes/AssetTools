namespace AssetTool
{
    //@@@ declarar FBox2f e FBox2d e FBox2Selector
    public class FBox2
    {
        public const string StructName = "Box2D";

        public FVector2d Min = new();
        public FVector2d Max = new();
        public byte IsValid;

        public FBox2 Move(Transfer transfer)
        {
            Min.Move(transfer);
            Max.Move(transfer);
            transfer.Move(ref IsValid);
            return this;
        }
    }
}
