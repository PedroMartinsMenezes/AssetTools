namespace AssetTool
{
    [StructSerializable("IntPoint")]
    public class FIntPoint : ITransferible
    {
        public const string StructName = "IntPoint";

        public int X;
        public int Y;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref X);
            transfer.Move(ref Y);
            return this;
        }
    }
}
