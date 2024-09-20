namespace AssetTool
{
    //[StructAsset("IntPoint")]
    public class FIntPoint
    {
        public const string StructName = "IntPoint";

        public int X;
        public int Y;

        public FIntPoint Move(Transfer transfer)
        {
            transfer.Move(ref X);
            transfer.Move(ref Y);
            return this;
        }
    }
}
