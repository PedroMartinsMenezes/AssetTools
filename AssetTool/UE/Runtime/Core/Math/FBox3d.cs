namespace AssetTool
{
    //@@@ declarar FBox3f e FBox3d e FBox3Selector
    [TransferibleStruct("Box")]
    public class FBox3d : ITransferible
    {
        public const string StructName = "Box";

        public FVector3d Min = new();
        public FVector3d Max = new();
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
